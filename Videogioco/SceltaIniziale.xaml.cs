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
using System.Xml.Serialization;

namespace Videogioco
{
    /// <summary>
    /// Logica di interazione per SceltaIniziale.xaml
    /// </summary>
    public partial class SceltaIniziale : Window
    {
        private List<Arma> _armiRosso;
        private List<Arma> _armiBlu;
        private List<Arma> _armi;
        private List<Personaggio> _personaggi;
        private Personaggio _blu;
        private Personaggio _rosso;
        private int _numeroArmaBlu;
        private int _numeroArmaRossa;
        private Utente _utenteRosso;
        private Utente _utenteBlu;
        private int _isSetPersonaggioBlu;
        private int _isSetPeronaggioRosso;
        private int FILE_XML_PERSONAGGI;
        private int FILE_XML_ARMI;

        public SceltaIniziale()
        {
            InitializeComponent();
            btnInizia.IsEnabled = false;
            //LeggiFileArmi();
            //LeggiFilePersonaggi();
        }       

        public void ApriCampo()
        {
            Combattimento c = new Combattimento();

            c.Show();

            this.Close();
        }
      

        public void AggiungePersonaggioRosso(Personaggio p)
        {
            if (_personaggi.Contains(p))
            {
                _rosso = p;
            }
            else
            {
                throw new Exception("Personaggio not found");
            }
            
        }

        public void AggiungiPersonaggioBlu(Personaggio p)
        {
            if (_personaggi.Contains(p))
            {
                _blu = p;
            }
            else
            {
                throw new Exception("Personaggio not found");
            }
        }

        public void AggiungiArmaRossa(Arma a)
        {
            if (_armi.Contains(a)&&_armiRosso.Count<3)
            {
                _armiRosso.Add(a);
            }
            else
            {
                throw new Exception("arma inesistente o numero massimo di armi raggiunto");
            }
            
        }

        public void AggiungiArmaBlu(Arma a)
        {
            if (_armi.Contains(a) && _armiBlu.Count < 3)
            {
                _armiBlu.Add(a);
            }
            else
            {
                throw new Exception("arma inesistente o numero massimo di armi raggiunto");
            }

        }

        public void LeggiFileArmi()
        {
            using (StreamReader sr = new StreamReader("Armi.xml"))
            {
                while (sr.EndOfStream)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Personaggio));

                    _personaggi.Add((Personaggio)serializer.Deserialize(sr));
                }
            }
        }

        public void LeggiFilePersonaggi()
        {

            using (StreamReader sr = new StreamReader("Personaggi.xml"))
            {
                while (sr.EndOfStream)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Personaggio));

                    _personaggi.Add((Personaggio)serializer.Deserialize(sr));
                }
            }
        }

        private void btnInizia_Click(object sender, RoutedEventArgs e)
        {
            Queue<Arma> aR = new Queue<Arma>(_armiRosso);
            Queue<Arma> aB = new Queue<Arma>(_armiBlu);
            _utenteBlu = new Utente(aB, _blu.PuntiAttacco, _blu.Id, Squadre.Blu, _blu.PuntiVita);
            _utenteRosso= new Utente(aR, _rosso.PuntiAttacco, _rosso.Id, Squadre.Rossa, _rosso.PuntiVita);
            ApriCampo();
        }
    }
}
