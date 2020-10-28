using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    public class Valutazione
    {
        private double voto;
        private DateTime data;
        private Materia materia;

        public Valutazione(double voto, Studente studente, Materia materia)
        {
            this.voto = voto;
            studente.AddVoto(this);
            this.materia = materia;
        }

        public Valutazione GetVoto()
        {
            return this;
        }

        public Materia GetMateria()
        {
            return materia;
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
