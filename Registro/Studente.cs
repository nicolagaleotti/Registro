using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Registro
{
    public class Studente
    {
        private string nome;
        private string cognome;
        private DateTime dataDiNascita;
        List<Valutazione> voti = new List<Valutazione>();

        public Studente(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCognome()
        {
            return cognome;
        }

        public DateTime GetDataDiNascita()
        {
            return dataDiNascita;
        }

        public void SetDataDiNascita(DateTime data)
        {
            dataDiNascita = data;
        }

        public List<Valutazione> GetVoti()
        {
            return voti;
        }

        public void AddVoto(Valutazione voto)
        {
            voti.Add(voto);
        }

        public Valutazione TrovaVotoMassimo()
        {
            int indice = 0;
            double max = -1;
            for (int i = 0; i < voti.Count; i++)
            {
                if (voti[i].GetVotoDouble() > max)
                    indice = i;
            }
            return voti[indice].GetVoto();
        }

        public Valutazione TrovaVotoMinimo()
        {
            int indice = 0;
            double min = 11;
            for (int i = 0; i < voti.Count; i++)
            {
                if (voti[i].GetVotoDouble() < min)
                    indice = i;
            }
            return voti[indice].GetVoto();
        }
    }
}
