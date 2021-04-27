using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Videogioco
{
    public class Duello
    {
        //utente 0 = blu, utente 1 = rosso

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

        public Duello(Utente[] utenti, int round = 1)
        {
            Utenti = utenti;
            RoundCorrente = round;
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
            if(Utenti[0].Squadra == Squadre.Rossa)
            {
                Random rand = new Random();
                int dannoColpo = rand.Next(1, 4);
                Utenti[1].VitaUtente -= (Utenti[0].PuntiAttacco + dannoColpo + ColpoCritico());
                
            }
            else
            {
                Random rand = new Random();
                int dannoColpo = rand.Next(1, 4);
                Utenti[0].VitaUtente -= (Utenti[1].PuntiAttacco + dannoColpo + ColpoCritico());
            }
        }

        public void SparaBlu()
        {
            if (Utenti[0].Squadra == Squadre.Blu)
            {
                Random rand = new Random();
                int dannoColpo = rand.Next(1, 4);
                Utenti[1].VitaUtente -= (Utenti[0].PuntiAttacco + dannoColpo + ColpoCritico());

            }
            else
            {
                Random rand = new Random();
                int dannoColpo = rand.Next(1, 4);
                Utenti[0].VitaUtente -= (Utenti[1].PuntiAttacco + dannoColpo + ColpoCritico());
            }
        }
        public void SchivaRosso()
        {
            //timer
            Utenti[1].Schivato = true;
        }

        public void SchivaBlu()
        {
            //tiemr
            Utenti[0].Schivato = true;
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
            
        }

        public int ColpoCritico()
        {
            //Il colpo critico avviene solo se il random è uguale a 1
            Random rand = new Random();
            int scelta = rand.Next(1, 21);

            if (scelta == 1)
                return 50;
            return 0;
        }

        public void NuovoRound()
        {
            Utenti[0].VitaUtente = Utenti[0].Personaggio.PuntiVita;
            Utenti[1].VitaUtente = Utenti[1].Personaggio.PuntiVita;

            Utenti[0].CambioArma();
            Utenti[1].CambioArma();

            RoundCorrente++;
        }

        private void AumentaPuntiEseprienza(int indiceVincente)
        {
            if(RoundCorrente == 3)
            {
                if(indiceVincente == 0)
                {
                    Utenti[indiceVincente].AggiungiPuntiEsperienza(100);
                    Utenti[indiceVincente + 1].AggiungiPuntiEsperienza(50);
                }
                else
                {
                    Utenti[indiceVincente].AggiungiPuntiEsperienza(100);
                    Utenti[indiceVincente - 1].AggiungiPuntiEsperienza(50);
                }
            }
        }

        public string ControllaVittoria()
        {
            if (Utenti[0].VitaUtente <= 0)
            {
                if (RoundCorrente == 3)
                {
                    AumentaPuntiEseprienza(1);
                }

                if (Utenti[1].Squadra == Squadre.Blu)
                    return "Blu";

                return "Rosso";
            }
            else if (Utenti[1].VitaUtente <= 0)
            {
                if (RoundCorrente == 3)
                {
                    AumentaPuntiEseprienza(0);
                }

                if (Utenti[0].Squadra == Squadre.Blu)
                    return "Blu";
                return "Rosso";
            }
            else
                return "Nan";
        }
    }
}