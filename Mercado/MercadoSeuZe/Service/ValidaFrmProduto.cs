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
                MessageBox.Show("O nome do produto é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Valida o preço do produto
            if (produto.GetPreco() <= 0)
            {
                MessageBox.Show("O preço do produto deve ser maior que zero.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
