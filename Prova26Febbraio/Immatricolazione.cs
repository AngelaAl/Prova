using System;
namespace Prova26Febbraio
{
    public class Immatricolazione
    {
        public string Matricola {get;}
        public DateTime DataInizio { get; set; }
        public CorsoDiLaurea CorsoLaurea { get; set; }
        public bool FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }

        private static int MatricolaSeed = 1000;

        public Immatricolazione(DateTime dataInizio, CorsoDiLaurea corsoDiLaurea)
        {
            Matricola = MatricolaSeed.ToString();
            MatricolaSeed++;
            DataInizio = dataInizio;
            CorsoLaurea = corsoDiLaurea;
            FuoriCorso = false;
            CFUAccumulati = 0;

        }
    }
}
