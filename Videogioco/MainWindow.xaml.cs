using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Videogioco
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Arma> listaArmiDaSerializzare;
        ArmaDistanza arma;
        Personaggio personaggio;
        List<Personaggio> listaPersonaggiDaSerializzare;
        List<ArmaDistanza> listaArmiDistanza;
        public MainWindow()
        {
            InitializeComponent();
            listaArmiDaSerializzare = new List<Arma>();
            listaPersonaggiDaSerializzare = new List<Personaggio>();
            listaArmiDistanza = new List<ArmaDistanza>();
            arma = new ArmaDistanza(2000,"3242","arco");
            listaArmiDistanza.Add(arma);
            arma = new ArmaDistanza(300, "2434", "lancia");
            listaArmiDistanza.Add(arma);
            //arma = new ArmaVicino(232, "6479", "guantone");
            listaArmiDistanza.Add(arma);
            arma = new ArmaDistanza(212, "5248", "balestra");
            listaArmiDistanza.Add(arma);
            arma = new ArmaDistanza(344, "7458", "fucile");
            listaArmiDistanza.Add(arma);
            //arma = new ArmaVicino(400, "5437", "spada");
            listaArmiDistanza.Add(arma);
            listaPersonaggiDaSerializzare = new List<Personaggio>();
            personaggio = new Personaggio("3245", "valkiria", 323, 354, 0);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "maga", 323, 354, 0);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "marksman", 323, 354, 0);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "golem", 323, 354, 0);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "guerriero", 323, 354, 0);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "ninja", 323, 354, 0);
            listaPersonaggiDaSerializzare.Add(personaggio);

            ScriviFileArmi();
            ScriviFilePersonaggi();



        }

        public void ScriviFileArmi()
        {
            using (StreamWriter sr = new StreamWriter("Armi.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ArmaDistanza));
                foreach (Arma a in listaArmiDistanza)
                {

                    serializer.Serialize(sr, a);
                    
                }
            }
        }
        public void ScriviFilePersonaggi()
        {
            using (StreamWriter sr = new StreamWriter("Personaggi.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Personaggio));
                foreach (Personaggio p in listaPersonaggiDaSerializzare)
                {

                    serializer.Serialize(sr, p);

                }
            }
        }

        public SceltaIniziale SceltaIniziale
        {
            get => default;
            set
            {
            }
        }

        private const string FILE_REGOLE = "";
        private const string FILE_PERSONAGGI = "";
        private const string FILE_ARMI = " ";

        public void PassaASceltaPersonaggi()
        {
            throw new System.NotImplementedException();
        }

        public void ApriRegolamento()
        {
            Process.Start(FILE_REGOLE); 
        }

        public void ApriArmi()
        {
            Process.Start(FILE_ARMI);
        }

        public void ApriPersonaggi()
        {
            Process.Start(FILE_PERSONAGGI);
        }

        private void BtnInizia_Click(object sender, RoutedEventArgs e)
        {
            SceltaIniziale s = new SceltaIniziale();
            s.Show();            
            this.Close();
        }
    }
}
