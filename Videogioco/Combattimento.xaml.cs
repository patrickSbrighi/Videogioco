﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Videogioco
{
    /// <summary>
    /// Logica di interazione per Combattimento.xaml
    /// </summary>
    public partial class Combattimento : Window
    {
        private List<Campo> _campi;
        private List<Campo> _campiDisponibili;
        private string _idUltimoCampoScelto;
        private bool _finitoRound;
        private const int NUMERO_ROUND_TOTALE = 3;
        private int _roundVintiBlu;
        private int _roundVintiRosso;
        private string _vincitorePartita;

        public Combattimento(Utente rosso, Utente blu)
        {
            InitializeComponent();
            duello = new Duello(rosso, blu);
            InizializzazioneElementi();
            _roundVintiRosso = 0;
            _roundVintiBlu = 0;
        }

        private void InizializzazioneElementi()
        {
            progressBlu.Maximum = duello.UtenteBlu.VitaUtente;
            progressRosso.Maximum = duello.UtenteRosso.VitaUtente;
            progressBlu.Value = progressBlu.Maximum;
            progressRosso.Value = progressRosso.Maximum;
            _finitoRound = false;

            _campi = new List<Campo>();
            LeggiFileCampi();
            RandomCampo();
            btnSessione.Visibility = Visibility.Hidden;

            duello.UtenteRosso.CalcoloSource();
            duello.UtenteBlu.CalcoloSource();

            Uri uriBlu = new Uri(duello.UtenteBlu.SourcePersonaggio, UriKind.Relative);
            ImageSource sourceBlu = new BitmapImage(uriBlu);
            imgBlu.Source = sourceBlu;

            Uri uriRosso = new Uri(duello.UtenteRosso.SourcePersonaggio, UriKind.Relative);
            ImageSource sourceRosso = new BitmapImage(uriRosso);
            imgRosso.Source = sourceRosso;

            lblVincitoreRound.Content = "";
            lblVincitorePartita.Content = "";
        }

        private Duello duello
        {
            get;
            set;
        }

        public void SparaRosso()
        {
            duello.SparaRosso();
            progressBlu.Value = duello.UtenteBlu.VitaUtente;

            string vincitore = duello.ControllaVittoria();

            if (vincitore != "Nan")
                Vittoria(vincitore);
        }

        public void SparaBlu()
        {
            duello.SparaBlu();
            progressRosso.Value = duello.UtenteRosso.VitaUtente;

            string vincitore = duello.ControllaVittoria();

            if (vincitore != "Nan")
                Vittoria(vincitore);
        }

        public void SchivaRosso()
        {
            duello.SchivaRosso();
        }

        public void SchivaBlu()
        {
            duello.SchivaBlu();
        }

        
        public void RandomCampo()
        {
            if(duello.RoundCorrente == 1) //se è il primo round carico un campo casuale
            {
                Random rand = new Random();
                int nScelto = rand.Next(0, NUMERO_ROUND_TOTALE);
                Campo campo = _campi[nScelto];
                _idUltimoCampoScelto = campo.Id;
                _campiDisponibili = _campi;
                _campiDisponibili.Remove(campo);

                Uri a = new Uri(campo.Source, UriKind.Relative);
                ImageSource b = new BitmapImage(a);
                imgSfondo.Source = b;
            }
            else
            {
                Random rand = new Random();
                int nScelto = rand.Next(0, NUMERO_ROUND_TOTALE - duello.RoundCorrente);
                Campo campo = _campiDisponibili[nScelto];
                _idUltimoCampoScelto = campo.Id;
                _campiDisponibili.Remove(campo);

                Uri a = new Uri(campo.Source, UriKind.Relative);
                ImageSource b = new BitmapImage(a);
                imgSfondo.Source = b;
            }

        }

        private void NuovoRound()
        {
            duello.NuovoRound();
            InizializzazioneElementi();
        }

        public void TornaHome()
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        /*A = schiva sinistra
          D = spara sinistra
          right = schiva destra
          left = spara destra
        */
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_finitoRound)
            {
                if (e.Key == Key.A)
                {
                    SchivaBlu();
                }
                else if (e.Key == Key.D)
                {
                    SparaBlu();
                }
                else if (e.Key == Key.Right)
                {
                    SchivaRosso();
                }
                else if (e.Key == Key.Left)
                {
                    SparaRosso();
                }
            }
        }

        private void LeggiFileCampi()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Campo>));
            List<Campo> lista = new List<Campo>();

            using (StreamReader sr = new StreamReader("Campi.xml"))
            {
                lista = (List<Campo>)serializer.Deserialize(sr);
            }

            foreach (Campo c in lista)
            {
                _campi.Add(c);
            }
        }

        private void Vittoria(string vincitoreRound)
        {
            lblVincitoreRound.Content = "Il vincitore del round " + duello.RoundCorrente + " è: " + vincitoreRound;
            btnSessione.Visibility = Visibility.Visible;
            if (vincitoreRound == "Rosso")
            {
                _roundVintiRosso++;
            }
            else if (vincitoreRound == "Blu")
            {
                _roundVintiBlu++;
            }
            lblRoundVintiRosso.Content = _roundVintiRosso;
            lblRoundVintiBlu.Content = _roundVintiBlu;

            if (duello.RoundCorrente != 3)
            {
                _finitoRound = true;
                btnSessione.Content = "Prossimo round";
            }
            else
            {
                btnSessione.Content = "Home";
                if (_roundVintiBlu > _roundVintiRosso)
                {
                    _vincitorePartita = "Blu";
                }
                else if (_roundVintiRosso > _roundVintiBlu)
                {
                    _vincitorePartita = "Rosso";
                }
                lblVincitorePartita.Content = "Vince la partita: " + _vincitorePartita;
            }
        }

        private void btnSessione_Click(object sender, RoutedEventArgs e)
        {
            btnSessione.Visibility = Visibility.Hidden;

            if (duello.RoundCorrente != 3)
                NuovoRound();
            else
                TornaHome();
        }
    }
}
