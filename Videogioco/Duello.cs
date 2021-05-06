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
        //utente 0 = blu, utente 1 = rosso
        //TO DO SOSTITUIRE L'ARRAY DI UTENTI CON UTENTEROSSO E UTENTEBLU
        private Utente _utenteBlu;
        private Utente _utenteRosso;
        public Utente UtenteRosso 
        {
            get => _utenteRosso;
            set
            {
                /*
                if (value.Length > 2)
                    throw new Exception("Ci sono troppi utenti");
                if (value[0].Squadra == value[1].Squadra)
                    throw new Exception("Gli utenti hanno la stessa squadra");

                _utenti = value;*/

                //TO DO gestire il set dell'utente
            }
        }
        public Utente UtenteBlu
        {
            get => _utenteBlu;
            set
            {
                /*
                if (value.Length > 2)
                    throw new Exception("Ci sono troppi utenti");
                if (value[0].Squadra == value[1].Squadra)
                    throw new Exception("Gli utenti hanno la stessa squadra");

                _utenti = value;*/

                //TO DO gestire il set dell'utente
            }
        }

        public Duello(Utente utenteBlu, Utente utenteRosso, int round = 1)
        {
            
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
            /*if(Utenti[0].Squadra == Squadre.Rossa)
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
            }*/

            Random rand = new Random();
            int dannoColpo = rand.Next(1, 4);
            UtenteBlu.VitaUtente -= (UtenteRosso.PuntiAttacco + dannoColpo + ColpoCritico());
            UtenteRosso.Carico = false;
            Thread ricarica = new Thread(new ThreadStart(RicaricaRosso));
            ricarica.Start();
        }

        public void SparaBlu()
        {
            /*if (Utenti[0].Squadra == Squadre.Blu)
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
            }*/

            Random rand = new Random();
            int dannoColpo = rand.Next(1, 4);
            UtenteRosso.VitaUtente -= (UtenteBlu.PuntiAttacco + dannoColpo + ColpoCritico());
            UtenteBlu.Carico = false;
            Thread ricarica = new Thread(new ThreadStart(RicaricaBlu));
            ricarica.Start();
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
            int scelta = rand.Next(1, 51);

            if (scelta == 1)
                return 50;
            return 0;
        }

        public void NuovoRound()
        {
            UtenteBlu.VitaUtente = UtenteBlu.Personaggio.PuntiVita;
            UtenteRosso.VitaUtente = UtenteRosso.Personaggio.PuntiVita;

            UtenteBlu.CambioArma();
            UtenteBlu.CambioArma();

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