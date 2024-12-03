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
    public static class ValidaFrmProduto
    {
        public static bool Valida(Produto produto)
        {
            // Valida o nome do produto
            if (string.IsNullOrWhiteSpace(produto.GetNome()))
            {
                MessageBox.Show("O nome do produto � obrigat�rio.", "Erro de Valida��o", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Valida o pre�o do produto
            if (produto.GetPreco() <= 0)
            {
                MessageBox.Show("O pre�o do produto deve ser maior que zero.", "Erro de Valida��o", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
