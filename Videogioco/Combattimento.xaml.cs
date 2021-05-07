using System;
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
        //private int _nRound;
        private Utente _rosso;
        private Utente _blu;
        private string _idUltimoCampoScelto;

        public Combattimento(Utente Rosso, Utente Blu)
        {
            InitializeComponent();
            _rosso = Rosso;
            _blu = Blu;
            _duello = new Duello(ref _rosso, ref _blu);
            InizializzazioneElementi();
        }

        private void InizializzazioneElementi()
        {
            progressBlu.Maximum = _blu.VitaUtente;
            progressRosso.Maximum = _rosso.VitaUtente;
            progressBlu.Value = progressBlu.Maximum;
            progressRosso.Value = progressRosso.Maximum;
            RandomCampo();
            btnSessione.Visibility = Visibility.Hidden;
            _rosso.CalcoloSource();
            _blu.CalcoloSource();
            imgBlu.Source = new BitmapImage(new Uri (_blu.SourcePersonaggio));
            imgRosso.Source = new BitmapImage(new Uri(_rosso.SourcePersonaggio));
            
            
            //imgArmaBlu.Source = new BitmapImage(new Uri(_blu.Armi.Peek.SourceArma);
            //imgArmaRossa.Source = new BitmapImage(new Uri(_rosso.Armi.Peek.SourceArma));
        }

        private Duello _duello
        {
            get;
            set;
        }

        public void SparaRosso()
        {
            _duello.SparaRosso();
            progressBlu.Value = _blu.VitaUtente;

            string vincitore = _duello.ControllaVittoria();

            if (vincitore != "Nan")
                Vittoria(vincitore);
        }

        public void SparaBlu()
        {
            _duello.SparaBlu();
            progressRosso.Value = _rosso.VitaUtente;
        }

        public void SchivaRosso()
        {
            _duello.SchivaRosso();
        }

        public void SchivaBlu()
        {
            _duello.SchivaBlu();
        }

        
        public void RandomCampo()
        {
            Random rand = new Random();
            int nScelto = rand.Next(0, 5);
            Campo campo = _campi[nScelto];
            _idUltimoCampoScelto = campo.Id;

            Uri a = new Uri(campo.Source, UriKind.Relative);
            ImageSource b = new BitmapImage(a);
            imgSfondo.Source = b;

        }

        private void NuovoRound()
        {
            _duello.NuovoRound();
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
            if (e.Key == Key.A)
            {
                SchivaBlu();
            }
            else if(e.Key == Key.D)
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

        private void LeggiFileCampi()
        {
            using (StreamReader sr = new StreamReader("Campi.xml"))
            {
                while (sr.EndOfStream)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Campo));

                    _campi.Add((Campo)serializer.Deserialize(sr));
                }
            }
        }

        private void Vittoria(string vincitore)
        {
            lblVincitore.Content = "Ha vinto il giocatore " + vincitore;
            btnSessione.Visibility = Visibility.Visible;

            if (_duello.RoundCorrente != 3)
                btnSessione.Content = "Prossimo round";
            else
                btnSessione.Content = "Home";
        }

        private void btnSessione_Click(object sender, RoutedEventArgs e)
        {
            btnSessione.Visibility = Visibility.Hidden;

            if (_duello.RoundCorrente != 3)
                NuovoRound();
            else
                TornaHome();
        }
    }
}
