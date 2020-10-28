using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    public class Materia
    {
        private string nome;

        public Materia(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }
    }
}
