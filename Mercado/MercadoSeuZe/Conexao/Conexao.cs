using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MercadoSeuZe
{
    public class Conexao
    {

        public static MySqlConnection ObterConexao()
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection("datasource=localhost;username=root;password=;database=dbmercado");
                //con.Open();
                //MessageBox.Show("Banco de Dados Foi Conectado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL CONECTAR: " + ex.Message);
            }

            return con;

        }

    }
}
