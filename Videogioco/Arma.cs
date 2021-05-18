using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public abstract class Arma
    {
        string _id;
        string _nome;
        int _puntiFerita;
        public Arma(string id, string nome, int puntiFerita)
        {
            _id = id;
            _nome = nome;
            _puntiFerita = puntiFerita;
        }
        public Arma()
        {
            
        }

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != "")
                {
                    _id = value;
                }
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != "")
                {
                    _nome = value;
                }
            }
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