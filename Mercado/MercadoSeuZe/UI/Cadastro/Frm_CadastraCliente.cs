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


namespace MercadoSeuZe.UI
{
    public partial class Frm_CadastraCliente : Form
    {

        int codigo = 0; // Variável para controlar o código do cliente

        public Frm_CadastraCliente(int? sCodigo, string nome, string estadoCivil, char sexo)
        {
            InitializeComponent();

            if (sCodigo.HasValue) // Modo de edição
            {
                codigo = sCodigo.Value;
                Txt_Nome.Text = nome;
                Cmb_EstadoCivil.SelectedItem = estadoCivil;
                Rad_Masculino.Checked = sexo == 'M';
                Rad_Feminino.Checked = sexo == 'F';
            }
        }

        public Frm_CadastraCliente()
        {
            InitializeComponent();
        }

        private void Btn_CadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            objCliente.SetCodigo(codigo); // Passa o código atual (0 para novo cliente)
            objCliente.SetNome(Txt_Nome.Text);
            objCliente.SetEstadoCivil(Cmb_EstadoCivil.Text);
            objCliente.SetSexo(Rad_Masculino.Checked ? 'M' : Rad_Feminino.Checked ? 'F' : '\0');


            bool clienteValidado = ValidaFrmCliente.Valida(objCliente);

            if (clienteValidado)
            {
                ClienteDao clienteDao = new ClienteDao();
                clienteDao.Salva(objCliente);
                MessageBox.Show("Cliente salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa();
                //this.Close(); // Fecha o formulário após salvar
                if(objCliente.GetCodigo()!=0) this.Close();
            }

        }

        private void Limpa()
        {
            Txt_Nome.Clear();
            Cmb_EstadoCivil.SelectedIndex = -1;

            foreach (Control itensDoGrupo in Gbox_Sexo.Controls)
            {
                if (itensDoGrupo is RadioButton itemRadio)
                {
                    itemRadio.Checked = false;
                }
            }

        }


    }


}
