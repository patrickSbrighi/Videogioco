using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Videogioco
{
    public class Duello
    {
        private Utente[] _utenti;
        public Utente[] Utenti 
        {
            get => _utenti;
            set
            {
                if (value.Length > 2)
                    throw new Exception("Ci sono troppi utenti");
                if (value[0].Squadra == value[1].Squadra)
                    throw new Exception("Gli utenti hanno la stessa squadra");

                _utenti = value;
            } 
        }

        public Duello(Utente[] utenti)
        {
            Utenti = utenti;
        }

        private int _roundCorrente;
        public int RoundCorrente
        {
            get => _roundCorrente;
            set
            {
                if (value < 1 || value > 3)
                    throw new Exception("Round non valido");
                _roundCorrente = value;
            }
        }

        public void SparaRosso()
        {
            //if()
        }

        public void SparaBlu()
        {
            throw new System.NotImplementedException();
        }
        public void SchivaRosso()
        {
            throw new System.NotImplementedException();
        }

        public void SchivaBlu()
        {
            throw new System.NotImplementedException();
        }

        public void RicaricaBlu()
        {
            throw new System.NotImplementedException();
        }

        public void RicaricaRosso()
        {
            throw new System.NotImplementedException();
        }

        public void SetSchivati()
        {
            throw new System.NotImplementedException();
        }

        public void ColpoCritico()
        {
            throw new System.NotImplementedException();
        }

        public void NuovoRound()
        {
            throw new System.NotImplementedException();
        }

        public void AumentaPuntiEseprienza()
        {
            throw new System.NotImplementedException();
        }

        public void ControllaVittoria()
        {
            throw new System.NotImplementedException();
        }
    }
}