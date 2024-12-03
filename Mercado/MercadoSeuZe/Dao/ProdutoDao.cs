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
using MercadoSeuZe.UI.Cadastro;

namespace MercadoSeuZe.Dao
{
    public class ProdutoDao
    {
        private const int tamanhoPagina = 10;
        private int indicePaginaAtual = 1;
        private int totalPaginas = 0;
        private int totalLinhas = 0;
        private string pesquisaAtual = "";

        public void Salva(Produto produto)
        {
            MySqlConnection con = Conexao.ObterConexao();
            string sql;

            try
            {
                con.Open();

                if (produto.GetCodigo() == 0) // Novo produto
                {
                    sql = "INSERT INTO Produto (nome, preco) VALUES (@Nome, @Preco)";
                }
                else // Produto existente (edição)
                {
                    sql = "UPDATE Produto SET nome = @Nome, preco = @Preco WHERE codigo = @Codigo";
                }

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", produto.GetNome());
                    cmd.Parameters.AddWithValue("@Preco", produto.GetPreco());

                    if (produto.GetCodigo() != 0) // Adiciona o código para atualização
                    {
                        cmd.Parameters.AddWithValue("@Codigo", produto.GetCodigo());
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                // Trata possíveis erros no banco de dados
                throw new Exception("Erro ao cadastrar o produto: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão
                if (con.State == ConnectionState.Open)
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
                string sqlCount = "SELECT COUNT(*) FROM Produto";

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
                string sql = "SELECT codigo, nome 'Nome', preco 'Preço' FROM Produto";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public void ExcluirProduto(object idProduto)
        {
            MySqlConnection con = Conexao.ObterConexao();

            try
            {
                con.Open();

                string sql = "DELETE FROM Produto WHERE codigo = @codigo";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", idProduto);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo, string textoAPesquisar)
        {
            if (indicePaginaAtual < totalPaginas)
            {
                indicePaginaAtual++;
                MostraTodos(dataGridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, textoAPesquisar);
            }
        }

        public void NavegarParaPaginaAnterior(DataGridView dataGridView, Label Lbl_TotalPaginas, Label Lbl_TotalLinhas,
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo, string textoAPesquisar)
        {
            if (indicePaginaAtual > 1)
            {
                indicePaginaAtual--;
                MostraTodos(dataGridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, textoAPesquisar);
            }
        }

        public void IrParaPrimeiraPagina(DataGridView dataGridView, Label Lbl_TotalPaginas, Label Lbl_TotalLinhas,
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo, string textoAPesquisar)
        {
            if (indicePaginaAtual != 1)
            {
                indicePaginaAtual = 1;
                MostraTodos(dataGridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, textoAPesquisar);
            }
        }

        public void IrParaUltimaPagina(DataGridView dataGridView, Label Lbl_TotalPaginas, Label Lbl_TotalLinhas,
            Label Lbl_PaginaAtual, Button Btn_Proximo, Button Btn_Anterior, Button Btn_Primeiro, Button Btn_Ultimo, string textoAPesquisar)
        {
            if (indicePaginaAtual != totalPaginas)
            {
                indicePaginaAtual = totalPaginas;
                MostraTodos(dataGridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, textoAPesquisar);
            }
        }
    }
}
