using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoSeuZe.Dao;
using MySql.Data.MySqlClient;

namespace MercadoSeuZe.UI.Pesquisa
{
    public partial class Frm_PesquisaCliente : Form
    {
        ClienteDao clienteDao = new ClienteDao();
        public Frm_PesquisaCliente()
        {
            InitializeComponent();
        }

        private void Frm_PesquisaCliente_Load(object sender, EventArgs e)
        {
            clienteDao.MostraTodos(DGrid_GridView,Lbl_TotalPaginas,Lbl_TotalLinhas,Lbl_PaginaAtual,Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Btn_Proximo_Click(object sender, EventArgs e)
        {
            clienteDao.NavegarParaProximaPagina(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            clienteDao.NavegarParaPaginaAnterior(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Btn_Primeiro_Click(object sender, EventArgs e)
        {
            clienteDao.IrParaPrimeiraPagina(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {
            clienteDao.IrParaUltimaPagina(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            string textoAPesquisar = Txt_Pesquisa.Text.Trim();
            clienteDao.MostraTodos(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, textoAPesquisar);
        }

        private void DGrid_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na coluna "Excluir"
            if (e.RowIndex >= 0 && DGrid_GridView.Columns[e.ColumnIndex].Name == "Excluir")
            {
                // Obtém o nome do cliente (ou o ID, se estiver disponível no DataGridView)
                var nomeCliente = DGrid_GridView.Rows[e.RowIndex].Cells["Nome"].Value?.ToString();

                DialogResult resultado = MessageBox.Show($"Deseja excluir o cliente {nomeCliente}?", "Confirmação",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Identifica o ID do cliente para exclusão
                    // Supondo que exista uma coluna oculta "id" no DataGridView
                    var idCliente = DGrid_GridView.Rows[e.RowIndex].Cells["codigo"].Value;

                    // Executa a exclusão no banco de dados
                    clienteDao.ExcluirCliente(idCliente);

                    // Limpa o conteúdo do Txt_Pesquisa
                    Txt_Pesquisa.Text = string.Empty;

                    // Atualiza os dados na tela
                    clienteDao.MostraTodos(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, "");
                }
            }
            else if (DGrid_GridView.Columns[e.ColumnIndex].Name == "Alterar")
            {
                string codigo = DGrid_GridView.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                string nome = DGrid_GridView.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                string estadoCivil = DGrid_GridView.Rows[e.RowIndex].Cells["Estado Civil"].Value.ToString();
                char sexo = DGrid_GridView.Rows[e.RowIndex].Cells["Sexo"].Value.ToString()[0];

                Frm_CadastraCliente frmEditarCliente = new Frm_CadastraCliente(int.Parse(codigo), nome, estadoCivil, sexo);
                frmEditarCliente.ShowDialog();

                // Atualiza o grid após edição
                clienteDao.MostraTodos(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, "");
            }
        }

    }
}
