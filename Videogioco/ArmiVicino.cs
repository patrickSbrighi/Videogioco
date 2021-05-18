using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class ArmaVicino : Arma
    {
        //Classe tenuta per una divisione mentale delle armi e per eventuali sviluppi futuri con movimento e animazione del colpo
        public ArmaVicino(int puntiFerita, string id, string nome) : base(id, nome, puntiFerita) { }

        public ArmaVicino() { }
    }
}