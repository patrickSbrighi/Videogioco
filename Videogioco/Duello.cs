using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Timers;
using System.Threading;

namespace Videogioco
{
    public class Duello
    {
        public Utente UtenteRosso 
        {
            get;
            set;
        }
        public Utente UtenteBlu
        {
            get;
            set;
        }

        public Duello(Utente utenteBlu, Utente utenteRosso, int round = 1)
        {
            UtenteBlu = utenteBlu;
            UtenteRosso = utenteRosso;
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
            if (UtenteRosso.Carico && !UtenteBlu.Schivato)
            {
                Random rand = new Random();
                int dannoColpo = rand.Next(1, 8);
                UtenteBlu.VitaUtente -= (UtenteRosso.PuntiAttacco + dannoColpo + ColpoCritico() + UtenteRosso.Armi.Peek().PuntiFerita);
                UtenteRosso.Carico = false;
                Thread ricarica = new Thread(new ThreadStart(RicaricaRosso));
                ricarica.Start();
            }
        }

        public void SparaBlu()
        {
            if (UtenteBlu.Carico && !UtenteRosso.Schivato)
            {
                Random rand = new Random();
                int dannoColpo = rand.Next(1, 8);
                UtenteRosso.VitaUtente -= (UtenteBlu.PuntiAttacco + dannoColpo + ColpoCritico() + UtenteBlu.Armi.Peek().PuntiFerita);
                UtenteBlu.Carico = false;
                Thread ricarica = new Thread(new ThreadStart(RicaricaBlu));
                ricarica.Start();
            }
        }
        public void SchivaRosso()
        {
            UtenteRosso.Schivato = true;
            Thread t1 = new Thread(new ThreadStart(TogliSchivaRosso));
            t1.Start();
        }

        public void SchivaBlu()
        {
            UtenteBlu.Schivato = true;
            Thread t1 = new Thread(new ThreadStart(TogliSchivaBlu));
            t1.Start();
        }

        private void RicaricaBlu()
        {
            Thread.Sleep(1500);
            UtenteBlu.Carico = true;
        }

        private void RicaricaRosso()
        {
            Thread.Sleep(1500);
            UtenteRosso.Carico = true;
        }

        private void TogliSchivaRosso()
        {
            Thread.Sleep(3000);
            UtenteRosso.Schivato = false;
        }

        private void TogliSchivaBlu()
        {
            Thread.Sleep(3000);
            UtenteBlu.Schivato = false;
        }

        public int ColpoCritico()
        {
            //Il colpo critico avviene solo se il random è uguale a 1
            Random rand = new Random();
            int scelta = rand.Next(1, 41);

            if (scelta == 1)
                return 37;
            return 0;
        }

        public void NuovoRound()
        {
            UtenteBlu.VitaUtente = UtenteBlu.Personaggio.PuntiVita;
            UtenteRosso.VitaUtente = UtenteRosso.Personaggio.PuntiVita;

            UtenteBlu.CambioArma();
            UtenteRosso.CambioArma();

            RoundCorrente++;
        }

        private void AumentaPuntiEseprienza(Squadre vincitore)
        {
            if(RoundCorrente == 3)
            {
                if(Squadre.Blu == vincitore)
                {
                    UtenteBlu.AggiungiPuntiEsperienza(100);
                    UtenteRosso.AggiungiPuntiEsperienza(25);
                }
                else
                {
                    UtenteRosso.AggiungiPuntiEsperienza(100);
                    UtenteBlu.AggiungiPuntiEsperienza(50);
                }
            }
        }

        public string ControllaVittoria()
        {
            if (UtenteBlu.VitaUtente <= 0)
            {
                if (RoundCorrente == 3)
                {
                    AumentaPuntiEseprienza(Squadre.Rossa);
                }
                return "Rosso";
            }
            else if (UtenteRosso.VitaUtente <= 0)
            {
                if (RoundCorrente == 3)
                {
                    AumentaPuntiEseprienza(Squadre.Blu);
                }

                return "Blu";
            }
            else
                return "Nan";
        }
    }
}