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

        // Métodos Get e Set para Código
        public int GetCodigo() { return Codigo; }
        public void SetCodigo(int codigo) { Codigo = codigo; }

        // Métodos Get e Set para Nome
        public string GetNome() { return Nome; }
        public void SetNome(string nome) { Nome = nome; }

        // Métodos Get e Set para Preço
        public decimal GetPreco() { return Preco; }
        public void SetPreco(decimal preco) { Preco = preco; }
    }
}
