using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public enum Squadre
    {
        Rossa,
        Blu
    }
    public class Utente
    {
        public Utente()
        {
            
        }

        public Squadre Squadra
        {
            get;
            set;
        }

        public Personaggio Personaggio
        {
            get;
            set;
        }

        private int _vita;
        public int Vita
        {
            get => _vita;
            set
            {
                if (value < 0)
                    throw new Exception("La vita non può essere negativa");
                _vita = value;
            }
        }

        public Queue<Arma> Armi
        {
            get;
            set;
        }

        public string SourcePersonaggio
        {
            get => default;
            private set
            {
            }
        }

        public int SourceArma
        {
            get => default;
            private set
            {
            }
        }

        public bool Schivato
        {
            get => default;
            set
            {
            }
        }

        public void AggiungiPuntiEsperienza()
        {
            throw new System.NotImplementedException();
        }

        public void CambioArma()
        {
            throw new System.NotImplementedException();
        }

        public void ColpoCritico(int danno)
        {
            throw new System.NotImplementedException();
        }

        public void Colpisci()
        {
            throw new System.NotImplementedException();
        }

        public void CalcoloSource()
        {
            throw new System.NotImplementedException();
        }
    }
}