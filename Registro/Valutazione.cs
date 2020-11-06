using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    public class Valutazione
    {
        private double voto;
        private DateTime data;

        public Valutazione(double voto, Studente studente, Docente docente)
        {
            this.voto = voto;
            docente.AssegnaVoto(studente, this);
        }

        public Valutazione GetVoto()
        {
            return this;
        }

        public DateTime GetData()
        {
            return data;
        }

        public bool IsSufficiente()
        {
            if (voto >= 6)
                return true;
            else return false;
        }

        public double GetVotoDouble()
        {
            return voto;
        }
    }
}
