using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSeuZe.Modelo
{
    public class Produto
    {
        private int Codigo;
        private string Nome;
        private decimal Preco;

        // M�todos Get e Set para C�digo
        public int GetCodigo() { return Codigo; }
        public void SetCodigo(int codigo) { Codigo = codigo; }

        // M�todos Get e Set para Nome
        public string GetNome() { return Nome; }
        public void SetNome(string nome) { Nome = nome; }

        // M�todos Get e Set para Pre�o
        public decimal GetPreco() { return Preco; }
        public void SetPreco(decimal preco) { Preco = preco; }
    }
}
