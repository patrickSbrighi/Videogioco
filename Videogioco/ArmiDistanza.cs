using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class ArmaDistanza : Arma
    {
        int _puntiFerita;
        public ArmaDistanza(int puntiFerita, string id, string nome) : base(id, nome)
        {
            _puntiFerita = puntiFerita;
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