using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MercadoSeuZe.Dao;

namespace MercadoSeuZe.UI.Pesquisa
{
    public partial class Frm_PesquisaProduto : Form
    {
        ProdutoDao produtoDao = new ProdutoDao();
        public Frm_PesquisaProduto()
        {
            InitializeComponent();
        }


        private void Frm_PesquisaProduto_Load(object sender, EventArgs e)
        {
            produtoDao.MostraTodos(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Btn_Proximo_Click(object sender, EventArgs e)
        {
            produtoDao.NavegarParaProximaPagina(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            produtoDao.NavegarParaPaginaAnterior(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Btn_Primeiro_Click(object sender, EventArgs e)
        {
            produtoDao.IrParaPrimeiraPagina(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {
            produtoDao.IrParaUltimaPagina(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, Txt_Pesquisa.Text);
        }

        private void Txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            string textoAPesquisar = Txt_Pesquisa.Text.Trim();
            produtoDao.MostraTodos(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, textoAPesquisar);
        }

        private void DGrid_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na coluna "Excluir"
            if (e.RowIndex >= 0 && DGrid_GridView.Columns[e.ColumnIndex].Name == "Excluir")
            {
                var nomeProduto = DGrid_GridView.Rows[e.RowIndex].Cells["Nome"].Value?.ToString();
                DialogResult resultado = MessageBox.Show($"Deseja excluir o produto {nomeProduto}?", "Confirmação",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var idProduto = DGrid_GridView.Rows[e.RowIndex].Cells["codigo"].Value;
                    produtoDao.ExcluirProduto(idProduto);
                    Txt_Pesquisa.Text = string.Empty;
                    produtoDao.MostraTodos(DGrid_GridView, Lbl_TotalPaginas, Lbl_TotalLinhas, Lbl_PaginaAtual, Btn_Proximo, Btn_Anterior, Btn_Primeiro, Btn_Ultimo, "");
                }
            }
        }
   
    
    }
}
