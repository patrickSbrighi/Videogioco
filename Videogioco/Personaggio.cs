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
        private int _pA;
        private int _esperienza;
        private int _livelloSkin;

        public Personaggio(string id, string nome, int pV, int pA, int esperienza)
        {
            Id = id;
            Nome = nome;
            PuntiVita = pV;
            PuntiAttacco = pA;
            Esperienza = esperienza;
        }

        public int LivelloSkin
        {
            get
            {
                return _livelloSkin;
            }
            set
            {
                if(value == 1 || value == 2 || value == 3)
                {
                    _livelloSkin = value;
                }
                else
                {
                    throw new Exception("il livello può essere impostato a 1, 2 o 3, riprovare.");
                }
            }
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
                    throw new Exception("id vuoto");
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
                if (value > 0)
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
                return _pA;
            }
            set
            {
                if (value > 0)
                {
                    _pA = value;
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
            if (_esperienza < 300)
            {
                _livelloSkin = 1;
            }else if (_esperienza >= 300 && _esperienza < 600)
            {
                _livelloSkin = 2;
            }
            else
            {
                _livelloSkin = 3;
            }
        }
    }
}