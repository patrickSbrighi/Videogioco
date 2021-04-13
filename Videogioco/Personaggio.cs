using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class Personaggio
    {
        private string _id;
        private string _nome;
        private int _pV;
        private int _pF;
        private int _esperienza;
        private int _lSkin=0;
        public Personaggio()
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
                if (String.IsNullOrEmpty(value) == true)
                {
                    throw new Exception("id vuoto ");
                }
                else
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
                if (String.IsNullOrEmpty(value) == true)
                {
                    throw new Exception("nome non valido");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public int PuntiVita
        {
            get
            {
                return _pV;
            }
            set
            {
                if (value >= 0)
                {
                    _pV = value;
                }
                else
                {
                    throw new Exception("La vita non può essere negativa");
                }
            }
        }

        public int PuntiAttacco
        {
            get
            {
                return _pF;
            }
            set
            {
                if (value > 0)
                {
                    _pF = value;
                }
                else
                {
                    throw new Exception("L'attacco non può essere negativo");
                }
            }
        }

        public int Esperienza
        {
            get
            {
                return _esperienza;
            }
            set
            {
                if (value >= 0)
                {
                    _esperienza = value;
                }
                else
                {
                    throw new Exception("L'esperienza non può essere negativa");
                }
            }
        }

        public void CalcolaSkin()
        {
            if (_esperienza>=300/*||_esperienza>=600||_esperienza>=1000*/)
            {
                _lSkin++;
            }
        }
    }
}