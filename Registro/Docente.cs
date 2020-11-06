using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    public class Docente
    {
        private string nome, cognome;
        List<Materia> materie = new List<Materia>();
        List<Valutazione> voti = new List<Valutazione>();

        public Docente(string nome, string cognome, Materia materia)
        {
            this.nome = nome;
            this.cognome = cognome;
            materie.Add(materia);
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCognome()
        {
            return cognome;
        }

        public string GetNomeCompleto()
        {
            return (nome + " " + cognome);
        }

        public void AddMateria(Materia materia)
        {
            materie.Add(materia);
        }

        public List<Materia> GetMaterie()
        {
            return materie;
        }

        public void AssegnaVoto(Studente studente, Valutazione voto)
        {
            studente.AddVoto(voto);
            voti.Add(voto);
        }

        public Valutazione TrovaVotoMassimo()
        {
            Valutazione max = voti[0];
            foreach(Valutazione v in voti)
            {
                if (v.GetVotoDouble() > max.GetVotoDouble())
                    max = v;
            }
            return max;
        }

        public Valutazione TrovaVotoMinimo()
        {
            Valutazione min = voti[0];
            foreach(Valutazione v in voti)
            {
                if (v.GetVotoDouble() < min.GetVotoDouble())
                    min = v;
            }
            return min;
        }
    }
}
