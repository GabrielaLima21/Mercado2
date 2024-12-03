using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MercadoSeuZe.Modelo;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using MercadoSeuZe.UI.Pesquisa;

namespace MercadoSeuZe.Dao
{
    public class ClienteDao
    {

        private const int tamanhoPagina = 10;
        private int indicePaginaAtual = 1;
        private int totalPaginas = 0;
        private int totalLinhas = 0;
        private string pesquisaAtual = "";


        public void Salva(Cliente cliente)
        {
            // Obtém a conexão com o banco de dados
            MySqlConnection con = Conexao.ObterConexao();
            string sql;

            if (cliente.GetCodigo() == 0) // Novo cliente
            {
                sql = "INSERT INTO Cliente (Nome, Estado_Civil, Sexo) VALUES (@Nome, @EstadoCivil, @Sexo)";
            }
            else // Cliente existente (edição)
            {
                sql = "UPDATE Cliente SET Nome = @Nome, Estado_Civil = @EstadoCivil, Sexo = @Sexo WHERE codigo = @Codigo";
            }


            try
            {
                // Abre a conexão
                con.Open();

                // Cria o comando SQL com os parâmetros
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    // Adiciona os parâmetros ao comando
                    cmd.Parameters.AddWithValue("@Nome", cliente.GetNome());
                    cmd.Parameters.AddWithValue("@EstadoCivil", cliente.GetEstadoCivil());
                    cmd.Parameters.AddWithValue("@Sexo", cliente.GetSexo());
                    
                    if (cliente.GetCodigo() != 0) // Adiciona o código para atualização
                    {
                        cmd.Parameters.AddWithValue("@Codigo", cliente.GetCodigo());
                    }

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                // Trata possíveis erros no banco de dados
                throw new Exception("Erro ao cadastrar o cliente: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }


            }

        }

        public void MostraTodos(DataGridView dataGridView, Label Lbl_TotalPaginas, Label Lbl_TotalLinhas, 
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo, string textoAPesquisar)
        {

            // Verifica se o texto de pesquisa mudou
            if (textoAPesquisar != pesquisaAtual)
            {
                indicePaginaAtual = 1;  // Redefine a página para 1 apenas se o texto de pesquisa for alterado
                pesquisaAtual = textoAPesquisar;  // Atualiza a pesquisa atual
            }

            MySqlConnection con = Conexao.ObterConexao();

            try
            {
                con.Open();

                // Obtem o total de linhas
                string sqlCount = "SELECT COUNT(*) FROM Cliente";

                if (!string.IsNullOrEmpty(textoAPesquisar))
                {
                    sqlCount += " WHERE nome LIKE @textoAPesquisar";
                }


                using (MySqlCommand cmdCount = new MySqlCommand(sqlCount, con))
                {
                    if (!string.IsNullOrEmpty(textoAPesquisar))
                    {
                        cmdCount.Parameters.AddWithValue("@textoAPesquisar", textoAPesquisar + "%");
                    }

                    totalLinhas = Convert.ToInt32(cmdCount.ExecuteScalar());
                }

                // Calcula o total de páginas
                totalPaginas = (int)Math.Ceiling((double)totalLinhas / tamanhoPagina);
                
                // Atualiza os rótulos de página
                Lbl_TotalPaginas.Text = totalPaginas.ToString();
                Lbl_TotalLinhas.Text = totalLinhas.ToString();
                Lbl_PaginaAtual.Text = indicePaginaAtual.ToString();

                // Obtém os registros paginados
                string sql = "SELECT codigo, nome 'Nome', estado_civil 'Estado Civil', sexo 'Sexo' FROM Cliente";

                if (!string.IsNullOrEmpty(textoAPesquisar))
                {
                    sql += " WHERE nome LIKE @textoAPesquisar";
                }
                sql += " ORDER BY nome LIMIT @tamanhoPagina OFFSET @offset";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (!string.IsNullOrEmpty(textoAPesquisar))
                    {
                        cmd.Parameters.AddWithValue("@textoAPesquisar", textoAPesquisar + "%");
                    }

                    cmd.Parameters.AddWithValue("@tamanhoPagina", tamanhoPagina);
                    cmd.Parameters.AddWithValue("@offset", (indicePaginaAtual - 1) * tamanhoPagina);

                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;

                    }
                }

                // Adiciona as colunas Alterar e Excluir
                if (dataGridView.Columns["Alterar"] == null && dataGridView.Columns["Excluir"] == null)
                {
                    DataGridViewImageColumn colAlterar = new DataGridViewImageColumn();
                    colAlterar.Name = "Alterar";
                    colAlterar.HeaderText = "Alterar";
                    colAlterar.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, @"..\..\Imagens\alterar.jpg"));
                    //colAlterar.Image = Image.FromFile(@"C:\WindowsForms\Curso\Mercado\MercadoSeuZe\Imagens\alterar.jpg");

                    DataGridViewImageColumn colExcluir = new DataGridViewImageColumn();
                    colExcluir.Name = "Excluir";
                    colExcluir.HeaderText = "Excluir";
                    colExcluir.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, @"..\..\Imagens\excluir.jpg"));
                    //colExcluir.Image = Image.FromFile(@"C:\WindowsForms\Curso\Mercado\MercadoSeuZe\Imagens\excluir.jpg");

                    dataGridView.Columns.Add(colAlterar);
                    dataGridView.Columns.Add(colExcluir);
                }

                // Ajusta as larguras das colunas
                //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Desabilita ajuste automático
                int larguraTotal = dataGridView.Width;
                dataGridView.Columns["codigo"].Visible = false;
                dataGridView.Columns["Nome"].Width = (int)(larguraTotal * 0.55);  // 55%
                dataGridView.Columns["Estado Civil"].Width = (int)(larguraTotal * 0.15); // 15%
                dataGridView.Columns["Sexo"].Width = (int)(larguraTotal * 0.1); // 10%
                dataGridView.Columns["Alterar"].Width = (int)(larguraTotal * 0.1); // 10%
                dataGridView.Columns["Excluir"].Width = (int)(larguraTotal * 0.1); // 10%

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public void ExcluirCliente(object idCliente)
        {
            MySqlConnection con = Conexao.ObterConexao();

            try
            {
                con.Open();

                string sql = "DELETE FROM Cliente WHERE codigo = @codigo";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", idCliente);
                    cmd.ExecuteNonQuery();
                }


                //MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        public void NavegarParaProximaPagina(DataGridView dataGridView, Label Lbl_TotalPaginas, Label Lbl_TotalLinhas, 
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo,string textoAPesquisar)
        {
            if (indicePaginaAtual < totalPaginas)
            {
                indicePaginaAtual++;
                MostraTodos(dataGridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual,Btn_Proximo, Btn_Anterior,Btn_Primeiro,Btn_Ultimo, textoAPesquisar);
            }

        }

        public void NavegarParaPaginaAnterior(DataGridView dataGridView, Label Lbl_TotalPaginas, Label Lbl_TotalLinhas, 
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo, string textoAPesquisar)
        {
            // Verifica se a página atual não é a primeira
            if (indicePaginaAtual > 1)
            {
                indicePaginaAtual--;  // Decrementa o número da página
            }

            // Atualiza os dados da nova página
            MostraTodos(dataGridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo,textoAPesquisar);
        }

        public void IrParaPrimeiraPagina(DataGridView dataGridView, Label Lbl_TotalPaginas, Label Lbl_TotalLinhas, 
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo, string textoAPesquisar)
        {
            // Verifica se não está na primeira página
            if (indicePaginaAtual != 1)
            {
                // Define o índice da página como 1 (primeira página)
                indicePaginaAtual = 1;

                // Atualiza os dados da primeira página
                MostraTodos(dataGridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, textoAPesquisar);
            }

        }

        public void IrParaUltimaPagina(DataGridView dataGridView, Label Lbl_TotalPaginas, Label Lbl_TotalLinhas, 
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo, string textoAPesquisar)
        {
            // Verifica se não está na última página
            if (indicePaginaAtual != totalPaginas)
            {
                // Define o índice da página como a última página
                indicePaginaAtual = totalPaginas;

                // Atualiza os dados da última página
                MostraTodos(dataGridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, textoAPesquisar);
            }

        }


    }
}
