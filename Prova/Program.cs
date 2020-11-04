using System;
using Registro;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Scuola scuola = new Scuola("Rosselli_Rasetti");
            Classe classe = scuola.CreateClasse(4, "AI");
            Studente studente1 = new Studente("Nicola", "Galeotti");
            Studente studente2 = new Studente("Narcis", "Buzatu");
            classe.AddStudente(studente1);
            classe.AddStudente(studente2);
            Materia materia1 = new Materia("Matematica");
            Valutazione voto1 = new Valutazione(8, studente1, materia1);
            Valutazione voto2 = new Valutazione(7, studente2, materia1);
            Valutazione votomax = scuola.TrovaVotoMassimo();
            Valutazione votomin = scuola.TrovaVotoMinimo();
            Console.WriteLine($"Il voto massimo della scuola {scuola.GetNome()} è {votomax.GetVotoDouble()}.");
            Console.WriteLine($"Il voto minimo della scuola {scuola.GetNome()} è {votomin.GetVotoDouble()}.");
        }
    }
}
