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
        public Utente(Personaggio personaggio, Queue<Arma> armi, Squadre squadra)
        {
            Personaggio = personaggio;
            Armi = armi;
            CalcoloSource();
            Squadra = squadra;
            VitaUtente = Personaggio.PuntiVita;
            Schivato = false;
            Carico = true;
        }

        public Utente()
        {
            CalcoloSource();
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

        public bool Schivato
        {
            get;
            set;
        }

        private int _vitaUtente;
        public int VitaUtente
        {
            get => _vitaUtente;
            set
            {
                // _vitaUtente = Personaggio.PuntiVita;
                _vitaUtente = value;
            }
        }

        private int _puntiAttacco;
        public int PuntiAttacco
        {
            get => _puntiAttacco;
            private set
            {
                _puntiAttacco = Personaggio.PuntiAttacco;
            }
        }

        public void AggiungiPuntiEsperienza(int puntiEsperienzaDaAggiungere)
        {
            Personaggio.Esperienza += puntiEsperienzaDaAggiungere;
        }

        public void CambioArma()
        {
            Armi.Dequeue();
        }

        public void CalcoloSource()
        {
            Personaggio.CalcolaSkin();
            if (_squadra == Squadre.Rossa)
            {
                if (Personaggio.LivelloSkin == 1)
                {
                    if (Personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 1.png";
                    }
                    else if (Personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 1.png";
                    }
                    else if (Personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 1.png";
                    }
                    else if (Personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 1.png";
                    }
                    else if (Personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 1.png";
                    }
                    else if (Personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 1.png";
                    }
                }
                else if (Personaggio.LivelloSkin == 2)
                {
                    if (Personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 2.png";
                    }
                    else if (Personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 2.png";
                    }
                    else if (Personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 2.png";
                    }
                    else if (Personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 2.png";
                    }
                    else if (Personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 2.png";
                    }
                    else if (Personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 2.png";
                    }
                }
                else if (Personaggio.LivelloSkin == 3)
                {
                    if (Personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 3.png";
                    }
                    else if (Personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 3.png";
                    }
                    else if (Personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 3.png";
                    }
                    else if (Personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 3.png";
                    }
                    else if (Personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 3.png";
                    }
                    else if (Personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 3.png";
                    }
                }
            }
            else if (_squadra == Squadre.Blu)
            {
                if (Personaggio.LivelloSkin == 1)
                {
                    if (Personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 1.png";
                    }
                    else if (Personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 1.png";
                    }
                    else if (Personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 1.png";
                    }
                    else if (Personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman blu 1.png";
                    }
                    else if (Personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 1.png";
                    }
                    else if (Personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/VALKIRIA/Valkiria blu 1.png";
                    }
                }
                else if (Personaggio.LivelloSkin == 2)
                {
                    if (Personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 2.png";
                    }
                    else if (Personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 2.png";
                    }
                    else if (Personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 2.png";
                    }
                    else if (Personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman roblusso 2.png";
                    }
                    else if (Personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 2.png";
                    }
                    else if (Personaggio.Nome == "Valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/VALKIRIA/Valkiria blu 2.png";
                    }
                }
                else if (Personaggio.LivelloSkin == 3)
                {
                    if (Personaggio.Nome == "Golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 3.png";
                    }
                    else if (Personaggio.Nome == "Guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 3.png";
                    }
                    else if (Personaggio.Nome == "Maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 3.png";
                    }
                    else if (Personaggio.Nome == "Marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman blu 3.png";
                    }
                    else if (Personaggio.Nome == "Ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 3.png";
                    }
                    else if (Personaggio.Nome == "Valkiria")
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