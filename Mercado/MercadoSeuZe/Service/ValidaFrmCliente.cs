using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoSeuZe.Modelo;

namespace MercadoSeuZe.Service
{
    public class ValidaFrmCliente
    {

        public static bool Valida(Cliente cliente) 
        {
            
            if(cliente.GetNome().Trim() == "")
            {
                MessageBox.Show("Você Deve Digitar Um Nome","Mensagem de Validação",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else if (cliente.GetEstadoCivil() == "")
            {
                MessageBox.Show("Você Deve Escolher Um Estado Civil", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cliente.GetSexo() == '\0')
            {
                MessageBox.Show("Escolha a Opção de Sexo", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

    }

}
