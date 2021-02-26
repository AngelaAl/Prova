using System;
using System.Collections.Generic;

namespace Prova26Febbraio
{
    public class Esame
    {
        public Corso CorsoEsame { get; set; }
        public bool EsameSuperato { get; set; }

        public Esame(Corso corsoEsame)
        {
            CorsoEsame = corsoEsame;
            EsameSuperato = false;
        }

        

    }
}
