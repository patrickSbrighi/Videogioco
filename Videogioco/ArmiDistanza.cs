using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class ArmaDistanza : Arma
    {
        //Classe tenuta per una divisione mentale delle armi e per eventuali sviluppi futuri con movimento e animazione del colpo
        public ArmaDistanza(int puntiFerita, string id, string nome) : base(id, nome, puntiFerita) { }

        public ArmaDistanza() { }
    }
}