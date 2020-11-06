using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    public class Classe
    {
        private int anno;
        private string sezione;
        List<Studente> studenti = new List<Studente>();
        List<Docente> docenti = new List<Docente>();

        public Classe(int anno, string sezione)
        {
            this.anno = anno;
            this.sezione = sezione;
        }

        public string GetNome()
        {
            return anno.ToString() + sezione;
        }

        public List<Studente> GetStudenti()
        {
            return studenti;
        }

        public void AddStudente(Studente studente)
        {
            studenti.Add(studente);
        }

        public void AddDocente(Docente docente)
        {
            docenti.Add(docente);
        }

        public List<Docente> GetDocenti()
        {
            return docenti;
        }

        public Valutazione TrovaVotoMassimo()
        {
            double max = -1;
            int indice = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                Valutazione voto = studenti[i].TrovaVotoMassimo();
                if (voto.GetVotoDouble() > max)
                {
                    max = voto.GetVotoDouble();
                    indice = i;
                }
            }
            return studenti[indice].TrovaVotoMassimo();
        }

        public Valutazione TrovaVotoMinimo()
        {
            double min = 11;
            int indice = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                Valutazione voto = studenti[i].TrovaVotoMassimo();
                if (voto.GetVotoDouble() < min)
                {
                    min = voto.GetVotoDouble();
                    indice = i;
                }
            }
            return studenti[indice].TrovaVotoMassimo();
        }
    }
}
