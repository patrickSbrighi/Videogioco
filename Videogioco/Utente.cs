using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

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

        private string _sourcePersonaggio;
        public string SourcePersonaggio
        {
            get => _sourcePersonaggio;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Valore source non valido");
                _sourcePersonaggio = value;
            }
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
            if (Squadra == Squadre.Rossa)
            {
                if (Personaggio.LivelloSkin == 1)
                {
                    if (Personaggio.Nome == "golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 1.png";
                    }
                    else if (Personaggio.Nome == "guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 1.png";
                    }
                    else if (Personaggio.Nome == "maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 1.png";
                    }
                    else if (Personaggio.Nome == "marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 1.png";
                    }
                    else if (Personaggio.Nome == "ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 1.png";
                    }
                    else if (Personaggio.Nome == "valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 1.png";
                    }
                }
                else if (Personaggio.LivelloSkin == 2)
                {
                    if (Personaggio.Nome == "golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 2.png";
                    }
                    else if (Personaggio.Nome == "guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 2.png";
                    }
                    else if (Personaggio.Nome == "maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 2.png";
                    }
                    else if (Personaggio.Nome == "marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 2.png";
                    }
                    else if (Personaggio.Nome == "ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 2.png";
                    }
                    else if (Personaggio.Nome == "valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 2.png";
                    }
                }
                else if (Personaggio.LivelloSkin == 3)
                {
                    if (Personaggio.Nome == "golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GOLEM/Golem rosso 3.png";
                    }
                    else if (Personaggio.Nome == "guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/GUERRIERO/Guerriero rosso 3.png";
                    }
                    else if (Personaggio.Nome == "maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MAGA/Maga rosso 3.png";
                    }
                    else if (Personaggio.Nome == "marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/MARKSMAN/Marksman rosso 3.png";
                    }
                    else if (Personaggio.Nome == "ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/NINJA/Ninja rosso 3.png";
                    }
                    else if (Personaggio.Nome == "valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Rossi/VALKIRIA/Valkiria rosso 3.png";
                    }
                }
            }
            else if (Squadra == Squadre.Blu)
            {
                if (Personaggio.LivelloSkin == 1)
                {
                    if (Personaggio.Nome == "golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 1.png";
                    }
                    else if (Personaggio.Nome == "guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 1.png";
                    }
                    else if (Personaggio.Nome == "maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 1.png";
                    }
                    else if (Personaggio.Nome == "marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman blu 1.png";
                    }
                    else if (Personaggio.Nome == "ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 1.png";
                    }
                    else if (Personaggio.Nome == "valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/VALKIRIA/Valkiria blu 1.png";
                    }
                }
                else if (Personaggio.LivelloSkin == 2)
                {
                    if (Personaggio.Nome == "golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 2.png";
                    }
                    else if (Personaggio.Nome == "guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 2.png";
                    }
                    else if (Personaggio.Nome == "maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 2.png";
                    }
                    else if (Personaggio.Nome == "marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman roblusso 2.png";
                    }
                    else if (Personaggio.Nome == "ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 2.png";
                    }
                    else if (Personaggio.Nome == "valkiria")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/VALKIRIA/Valkiria blu 2.png";
                    }
                }
                else if (Personaggio.LivelloSkin == 3)
                {
                    if (Personaggio.Nome == "golem")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GOLEM/Golem blu 3.png";
                    }
                    else if (Personaggio.Nome == "guerriero")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/GUERRIERO/Guerriero blu 3.png";
                    }
                    else if (Personaggio.Nome == "maga")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MAGA/Maga blu 3.png";
                    }
                    else if (Personaggio.Nome == "marksman")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/MARKSMAN/Marksman blu 3.png";
                    }
                    else if (Personaggio.Nome == "ninja")
                    {
                        SourcePersonaggio = "/Personaggi Videogioco/Personaggi Blu/NINJA/Ninja blu 3.png";
                    }
                    else if (Personaggio.Nome == "valkiria")
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