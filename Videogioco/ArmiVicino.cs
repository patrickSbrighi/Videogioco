using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class ArmaVicino : Arma
    {
        int _puntiFerita;
        public ArmaVicino(int puntiFerita, string id, string nome) : base(id, nome)
        {
            PuntiFerita = puntiFerita;
        }
        public ArmaVicino()
        {
            
        }

        public int PuntiFerita
        {
            get
            { return _puntiFerita; }
            set
            {
                if (value > 0)
                {
                    _puntiFerita = value;
                }
            }
        }
    }
}