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
        public Utente(Queue<Arma> armi, int puntiAttacco, string sourceArma, string sourcePersonaggio, bool schivato = false, Squadre squadra, int vitaUtente)
        {
            Armi = armi;
            PuntiAttacco = puntiAttacco;
            SourceArma = sourceArma;
            SourcePersonaggio = sourcePersonaggio;
            Schivato = schivato;
            Squadra = squadra;
            VitaUtente = vitaUtente;
        }

        private Squadre _squadra;
        public Squadre Squadra
        {
            get => default;
            set
            {
                if (value == Squadre.Rossa || value == Squadre.Blu)
                {
                    _squadra = value;
                }
                else
                {
                    throw new Exception("Errore inserimento squadra utente");
                }
            }
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
            get;
            private set;
        }

        private string _sourceArma;
        public string SourceArma
        {
            get;
            private set;
        }

        public bool Schivato
        {
            get;
            set;
        }

        private int _vitaUtente;
        public int VitaUtente
        {
            get => default;
            set
            {
                if (value >= 0)
                {
                    _vitaUtente = value;
                }
                else
                {
                    throw new Exception("Errore inserimento vita utente");
                }
            }
        }

        private int _puntiAttacco;
        public int PuntiAttacco
        {
            get => _puntiAttacco;
            set
            {
                if (value >= 0)
                {
                    _puntiAttacco = value;
                }
                else
                {
                    throw new Exception("Errore inserimento attacco utente");
                }
            }
        }

        private Personaggio _personaggio;
        public void AggiungiPuntiEsperienza(int puntiEsperienzaDaAggiungere)
        {
            _personaggio.Esperienza += puntiEsperienzaDaAggiungere;
        }

        private Queue<Arma> _armi;
        public void CambioArma()
        {
            _armi.Dequeue();
        }

        public void CalcoloSource()
        {
            throw new System.NotImplementedException();
            //TODO
        }
    }
}