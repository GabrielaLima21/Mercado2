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
using MercadoSeuZe.Modelo;
using MercadoSeuZe.Service;
using MercadoSeuZe.Dao;


namespace MercadoSeuZe.UI.Produto
{
    public partial class Frm_CadastrarProduto : Form
    {
        private int codigo = 0; // Variável para controlar o código do produto

        public Frm_CadastrarProduto(int? sCodigo, string nome, decimal preco)
        {
            InitializeComponent();

            if (sCodigo.HasValue) // Modo de edição
            {
                codigo = sCodigo.Value;
                Txt_Nome.Text = nome;
                Txt_Preco.Text = preco.ToString("F2"); // Formata o preço com duas casas decimais
            }
        }

        public Frm_CadastrarProduto()
        {
            InitializeComponent();
        }

        private void Btn_SalvarProduto_Click(object sender, EventArgs e)
        {
            Produto objProduto = new Produto();
            objProduto.SetCodigo(codigo); // Passa o código atual (0 para novo produto)
            objProduto.SetNome(Txt_Nome.Text);

            // Valida e define o preço
            if (decimal.TryParse(Txt_Preco.Text, out decimal preco))
            {
                objProduto.SetPreco(preco);
            }
            else
            {
                MessageBox.Show("O preço deve ser um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida o produto antes de salvar
            bool produtoValidado = ValidaFrmProduto.Valida(objProduto);

            if (produtoValidado)
            {
                ProdutoDao produtoDao = new ProdutoDao();
                produtoDao.Salva(objProduto);
                MessageBox.Show("Produto salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa();
                if (objProduto.GetCodigo() != 0) this.Close(); // Fecha o formulário se for edição
            }
        }

        private void Limpa()
        {
            Txt_Nome.Clear();
            Txt_Preco.Clear();
        }
    }
}
