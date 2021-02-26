using System;
using System.Collections.Generic;

namespace Prova26Febbraio
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoDiNascita { get; set; }
        public Immatricolazione ImmatricolazioneStudente { get; set; }
        public List<Esame> Esami { get; set; }
        public bool RichiestaLaurea { get; set; }

        public Studente(string nome, string cognome, int annoDiNascita, Immatricolazione immatricolazione)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
            ImmatricolazioneStudente = immatricolazione;
            Esami = new List<Esame>();
            RichiestaLaurea = false;
        }

        //Richiesta esame
        public static void RichiestaEsame (Esame esame, Studente studente)
        {
            //Se esame non è nel corso di laurea dello studente
            if (!studente.ImmatricolazioneStudente.CorsoLaurea.Corsi.Contains(esame.CorsoEsame))
            {
                Console.WriteLine("Esame non disponibile nel Corso di Laurea");
            }
            //Se Richiesta Laurea è disponibile
            else if (studente.RichiestaLaurea == true)
            {
                Console.WriteLine("Richiesta Laurea disponibile, non servono altri esami");
            }
            //Se i cfu esame + cfu accumulati superano i Cfu del corso di laurea
            else if(esame.CorsoEsame.CfuCorso + studente.ImmatricolazioneStudente.CFUAccumulati > studente.ImmatricolazioneStudente.CorsoLaurea.CfuLaurea)
            {
                Console.WriteLine("I Cfu del corso sommati ai CFU accumulati superano i CFU massimi del Corso di Laurea");
            }
            
            else
            {
                studente.Esami.Add(esame);
                Console.WriteLine("Esame aggiunto correttamente");
            }
        }

        //Esame passato
        public static void EsamePassato(Studente studente, Esame esame)
        {
            if(!studente.Esami.Contains(esame))
            {
                Console.WriteLine("Lo studente non si è iscritto a questo esame");
            }
            else
            {
                //Aggiorno CFU accumulati
                int cfuCorsoEsame = esame.CorsoEsame.CfuCorso;
                studente.ImmatricolazioneStudente.CFUAccumulati += cfuCorsoEsame;

                //Flag passato
                foreach(Esame e in studente.Esami)
                {
                    if(e == esame)
                    {
                        e.EsameSuperato = true;
                    }    
                }

                //Verifica CFU per laurea
                if(studente.ImmatricolazioneStudente.CFUAccumulati == studente.ImmatricolazioneStudente.CorsoLaurea.CfuLaurea)
                {
                    Console.WriteLine("Richiesta di Laurea disponibile");
                    studente.RichiestaLaurea = true;
                }
            }
        }
    }
}
