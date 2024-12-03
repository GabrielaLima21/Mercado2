using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSeuZe.Modelo
{
    public class Cliente
    {

        private int Codigo;
        private string Nome;
        private string EstadoCivil;
        private char Sexo;

        public int GetCodigo() {  return Codigo; }
        public void SetCodigo(int codigo) { Codigo = codigo; }
        public string GetNome() { return Nome; }
        public void SetNome(string nome) { Nome = nome; }
        public string GetEstadoCivil() { return EstadoCivil; }
        public void SetEstadoCivil(string estadoCivil) { EstadoCivil = estadoCivil; }
        public char GetSexo() { return Sexo; }
        public void SetSexo(char sexo) { Sexo = sexo; }

    }
}
