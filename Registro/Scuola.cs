using System;
using System.Collections.Generic;

namespace Registro
{
    public class Scuola
    {
        private string nome;
        List<Classe> classi = new List<Classe>();
        List<Materia> materie = new List<Materia>();

        public Scuola(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public Classe CreateClasse(int anno, string sezione)
        {
            Classe classe = new Classe(anno, sezione);
            classi.Add(classe);
            return classe;
        }
        
        public List<Classe> GetClassi ()
        {
            return classi;
        }

        public Materia CreateMateria(string nome)
        {
            Materia materia = new Materia(nome);
            materie.Add(materia);
            return materia;
        }

        public List<Materia> GetMaterie()
        {
            return materie;
        }

        public Valutazione TrovaVotoMassimo()
        {
            double max = -1;
            int indice = 0;
            for (int i = 0; i < classi.Count; i++)
            {
                Valutazione voto = classi[i].TrovaVotoMassimo();
                if (voto.GetVotoDouble() > max)
                {
                    max = voto.GetVotoDouble();
                    indice = i;
                }
            }
            return classi[indice].TrovaVotoMassimo();
        }
    }
}
