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

        public int VitaUtente
        {
            get => default;
            set
            {
            }
        }

        public int PuntiFerita
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

        public void CalcoloSource()
        {
            throw new System.NotImplementedException();
        }
    }
}