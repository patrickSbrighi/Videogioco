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
        ArmaVicino arma2;
        Personaggio personaggio;
        List<Personaggio> listaPersonaggiDaSerializzare;
        List<ArmaDistanza> listaArmiDistanza;
        List<ArmaVicino> listaArmiVicino;
        public MainWindow()
        {
            InitializeComponent();
            listaArmiDaSerializzare = new List<Arma>();
            listaPersonaggiDaSerializzare = new List<Personaggio>();
            listaArmiDistanza = new List<ArmaDistanza>();
            listaArmiVicino = new List<ArmaVicino>();
            arma = new ArmaDistanza(2000,"3242","arco");
            listaArmiDistanza.Add(arma);
            arma = new ArmaDistanza(300, "2434", "lancia");
            listaArmiDistanza.Add(arma);
            arma2 = new ArmaVicino(232, "6479", "guantone");
            listaArmiVicino.Add(arma2);
            arma = new ArmaDistanza(212, "5248", "balestra");
            listaArmiDistanza.Add(arma);
            arma = new ArmaDistanza(344, "7458", "fucile");
            listaArmiDistanza.Add(arma);
            arma2 = new ArmaVicino(400, "5437", "spada");
            listaArmiVicino.Add(arma2);
            listaPersonaggiDaSerializzare = new List<Personaggio>();
            personaggio = new Personaggio("3245", "valkiria", 323, 354, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "maga", 323, 354, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "marksman", 323, 354, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "golem", 323, 354, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "guerriero", 323, 354, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3245", "ninja", 323, 354, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);

            ScriviFileArmiDistanza();
            ScriviFileArmiVicino();
            ScriviFilePersonaggi();



        }

        public void ScriviFileArmiDistanza()
        {
            using (StreamWriter sr = new StreamWriter("ArmiDistanza.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ArmaDistanza>));
                /*foreach (ArmaDistanza a in listaArmiDistanza)
                {

                    serializer.Serialize(sr, a);
                    
                }*/

                serializer.Serialize(sr, listaArmiDistanza);
            }
        }
        public void ScriviFileArmiVicino()
        {
            using (StreamWriter sr = new StreamWriter("ArmiVicino.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ArmaVicino>));

                serializer.Serialize(sr, listaArmiVicino);
            }
        }
        
        public void ScriviFilePersonaggi()
        {
            using (StreamWriter sr = new StreamWriter("Personaggi.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Personaggio>));
                
                serializer.Serialize(sr, listaPersonaggiDaSerializzare);
            }
        }

        private const string FILE_REGOLE = ""; //TODO zutty pdf
        private const string FILE_PERSONAGGI = "";//TODO zutty pdf
        private const string FILE_ARMI = " ";//TODO zutty pdf

        public void PassaASceltaPersonaggi()
        {
            SceltaIniziale s = new SceltaIniziale();
            s.Show();
            this.Close();
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
            PassaASceltaPersonaggi();
        }
    }
}
