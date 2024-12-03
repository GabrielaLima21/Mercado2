using MercadoSeuZe.UI;
using MercadoSeuZe.UI.Pesquisa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoSeuZe
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastraCliente f = new Frm_CadastraCliente();
            f.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PesquisaCliente f = new Frm_PesquisaCliente();
            f.ShowDialog();
        }


        // Evento para abrir o formulário de cadastro de Produto
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastrarProduto f = new Frm_CadastrarProduto();
            f.ShowDialog();
        }

        // Evento para abrir o formulário de pesquisa de Produto
        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PesquisaProduto f = new Frm_PesquisaProduto();
            f.ShowDialog();
        }


    }
}
