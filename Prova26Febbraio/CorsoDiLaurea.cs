using System;
using System.Collections.Generic;

namespace Prova26Febbraio
{
    public class CorsoDiLaurea
    {
        public enum NomeCorso { Matematica, Fisica, Informatica, Ingegneria, Lettere }
        public NomeCorso NomeCorsoLaurea { get; set; }
        
        public static int AnniDiCorso { get; set; }
        public int CfuLaurea { get; set; }
        public List<Corso> Corsi { get; set; }

        public CorsoDiLaurea()
        {
            
            AnniDiCorso = 3;
            CfuLaurea = 180;
            Corsi = new List<Corso>();
        }

        //Creazione Lista Corsi di Laurea
        public static List<CorsoDiLaurea> CreazioneCorsiDiLaurea()
        {
            List<CorsoDiLaurea> CorsiDiLaurea = new List<CorsoDiLaurea>();
            

            for(int i=0; i<5; i++)
            {
                CorsoDiLaurea corsoDiLaurea = new CorsoDiLaurea();
                corsoDiLaurea.NomeCorsoLaurea = (NomeCorso)i;
                CorsiDiLaurea.Add(corsoDiLaurea);
            }
            return CorsiDiLaurea;
        }
    }
}
