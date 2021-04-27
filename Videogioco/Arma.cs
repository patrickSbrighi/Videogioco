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
        public Arma(string id, string nome)
        {
            _id = id;
            _nome = nome;
        }

        public string Id
        {
            get
            {
                return Id;
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
    }
}