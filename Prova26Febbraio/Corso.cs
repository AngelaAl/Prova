using System;
using System.Collections.Generic;

namespace Prova26Febbraio
{
    public class Corso
    {
        public string NomeCorso { get; set; }
        public int CfuCorso { get; set; }

        public Corso(string nomeCorso, int cfuCorso)
        {
            NomeCorso = nomeCorso;
            CfuCorso = cfuCorso;
        }

        //Creazione Lista Corsi
        public static void CreazioneCorsi(CorsoDiLaurea corsoDiLaurea, int numeroCorsi)
        {
            for(int i=0; i<numeroCorsi; i++)
            {
                Random x = new Random();
                int cfuCorso = x.Next(3, 13);

                string nomeCorso = corsoDiLaurea.NomeCorsoLaurea.ToString() + (i + 1);

                Corso corso = new Corso(nomeCorso, cfuCorso);

                corsoDiLaurea.Corsi.Add(corso);

            }
        }
    }
}
