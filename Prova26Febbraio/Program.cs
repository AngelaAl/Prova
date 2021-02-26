using System;
using System.Collections.Generic;

namespace Prova26Febbraio
{
    class Program
    {
        static void Main(string[] args)
        {

            List<CorsoDiLaurea> ListaCorsiDiLaurea = CorsoDiLaurea.CreazioneCorsiDiLaurea();

            //Corsi in Matematica
            Corso.CreazioneCorsi(ListaCorsiDiLaurea[0], 7);

            //Corsi in Fisica
            Corso.CreazioneCorsi(ListaCorsiDiLaurea[1], 10);

            //Corsi in Informatica
            Corso.CreazioneCorsi(ListaCorsiDiLaurea[2], 4);

            //Corsi in Ingegneria
            Corso.CreazioneCorsi(ListaCorsiDiLaurea[3], 8);

            //Corsi in Lettere
            Corso.CreazioneCorsi(ListaCorsiDiLaurea[4], 9);

            //Creazione immatricolazione e studente
            Immatricolazione immatricolazione = new Immatricolazione(DateTime.Today, ListaCorsiDiLaurea[0]);
            Studente studente = new Studente("Angela", "Alunni", 1995, immatricolazione);

            
            
            //Richiesta esame che va bene
            Esame esame = new Esame(ListaCorsiDiLaurea[0].Corsi[0]);
            Studente.RichiestaEsame(esame, studente);

            //Richiesta esame che non è nel corso di laurea
            Esame esame3 = new Esame(ListaCorsiDiLaurea[1].Corsi[0]);
            Studente.RichiestaEsame(esame3, studente);

            //Richiesta esame con cfu esame + cfu accumulati superano i Cfu del corso di laurea
            Corso corso = new Corso("TantiCfu", 200); //corso con 200 cfu
            ListaCorsiDiLaurea[0].Corsi.Add(corso);
            Esame esame4 = new Esame(ListaCorsiDiLaurea[0].Corsi[7]);
            Studente.RichiestaEsame(esame4, studente);



            //EsamePassato con esame non presente nella lista esami dello studente
            Esame esame2 = new Esame(ListaCorsiDiLaurea[0].Corsi[2]);
            Studente.EsamePassato(studente, esame2);


            //Esame che va bene
            Studente.EsamePassato(studente, esame);

            Console.WriteLine("---------------------------");
            //Esame che fa arrivare CFU accumulati = CFU per laurea
            int cfuAccumulati = studente.ImmatricolazioneStudente.CFUAccumulati;
            int cfUTotali = studente.ImmatricolazioneStudente.CorsoLaurea.CfuLaurea;
            int cfuMancanti = cfUTotali - cfuAccumulati;

            Corso corso1 = new Corso("CFUperLaurea", cfuMancanti);
            ListaCorsiDiLaurea[0].Corsi.Add(corso1);
            Esame esame5 = new Esame(ListaCorsiDiLaurea[0].Corsi[8]);

            //Richiesta esame (va a buon fine)
            Studente.RichiestaEsame(esame5, studente);
            //EsamePassato --> Richiesta laurea disponibile
            Studente.EsamePassato(studente, esame5);


            //Richiesta esame se richiesta Laurea è disponibile
            Esame esame6 = new Esame(ListaCorsiDiLaurea[0].Corsi[3]);
            Studente.RichiestaEsame(esame6, studente);
        }
    }
}
