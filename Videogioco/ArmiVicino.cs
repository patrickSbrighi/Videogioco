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
            throw new System.NotImplementedException();
        }

        public int PuntiFerita
        {
            get
            { return _puntiFerita; }
            set
            {
                if (value != null)
                {
                    _puntiFerita = value;
                }
            }
        }
    }
}