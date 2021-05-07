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
        public Utente(Personaggio personaggio, Queue<Arma> armi, int puntiAttacco, string sourcePersonaggio, Squadre squadra, int vitaUtente, bool schivato = false)
        {
            Personaggio = personaggio;
            Armi = armi;
            PuntiAttacco = puntiAttacco;            
            SourcePersonaggio = sourcePersonaggio;
            Schivato = schivato;
            Squadra = squadra;
            VitaUtente = vitaUtente;
            Carico = true;
        }

        public Utente()
        {

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

        private Personaggio _personaggio;
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
            _personaggio.CalcolaSkin();
            if (_squadra == Squadre.Rossa)
            {
                if (_personaggio.LivelloSkin == 1)
                {
                    if (_personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 1.png";
                    }
                    else if (_personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 1.png";
                    }
                    else if (_personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 1.png";
                    }
                    else if (_personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 1.png";
                    }
                    else if (_personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 1.png";
                    }
                    else if (_personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 1.png";
                    }
                }
                else if (_personaggio.LivelloSkin == 2)
                {
                    if (_personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 2.png";
                    }
                    else if (_personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 2.png";
                    }
                    else if (_personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 2.png";
                    }
                    else if (_personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 2.png";
                    }
                    else if (_personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 2.png";
                    }
                    else if (_personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 2.png";
                    }
                }
                else if (_personaggio.LivelloSkin == 3)
                {
                    if (_personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 3.png";
                    }
                    else if (_personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 3.png";
                    }
                    else if (_personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 3.png";
                    }
                    else if (_personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 3.png";
                    }
                    else if (_personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 3.png";
                    }
                    else if (_personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 3.png";
                    }
                }
            }
            else if (_squadra == Squadre.Blu)
            {
                if (_personaggio.LivelloSkin == 1)
                {
                    if (_personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 1.png";
                    }
                    else if (_personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 1.png";
                    }
                    else if (_personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 1.png";
                    }
                    else if (_personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman blu 1.png";
                    }
                    else if (_personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 1.png";
                    }
                    else if (_personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/VALKIRIA/Valkiria blu 1.png";
                    }
                }
                else if (_personaggio.LivelloSkin == 2)
                {
                    if (_personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 2.png";
                    }
                    else if (_personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 2.png";
                    }
                    else if (_personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 2.png";
                    }
                    else if (_personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman roblusso 2.png";
                    }
                    else if (_personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 2.png";
                    }
                    else if (_personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/VALKIRIA/Valkiria blu 2.png";
                    }
                }
                else if (_personaggio.LivelloSkin == 3)
                {
                    if (_personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 3.png";
                    }
                    else if (_personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 3.png";
                    }
                    else if (_personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 3.png";
                    }
                    else if (_personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman blu 3.png";
                    }
                    else if (_personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 3.png";
                    }
                    else if (_personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/VALKIRIA/Valkiria blu 3.png";
                    }
                }
            }
        }

        public bool Carico
        {
            get;
            set;
        }
    }
}