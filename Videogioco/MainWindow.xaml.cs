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
        /*List<Arma> listaArmiDaSerializzare;
        ArmaDistanza arma;
        ArmaVicino arma2;
        Personaggio personaggio;
        List<Personaggio> listaPersonaggiDaSerializzare;
        List<ArmaDistanza> listaArmiDistanza;
        List<ArmaVicino> listaArmiVicino;
        List<Campo> listaCampi;*/
        public MainWindow()
        {
            InitializeComponent();/*
            listaArmiDaSerializzare = new List<Arma>(); 
            listaPersonaggiDaSerializzare = new List<Personaggio>();
            listaArmiDistanza = new List<ArmaDistanza>();
            listaCampi = new List<Campo>();
            listaArmiVicino = new List<ArmaVicino>();
            arma = new ArmaDistanza(5,"1","arco");
            listaArmiDistanza.Add(arma);
            arma = new ArmaDistanza(8, "2", "lancia");
            listaArmiDistanza.Add(arma);
            arma2 = new ArmaVicino(2, "3", "guantone");
            listaArmiVicino.Add(arma2);
            arma = new ArmaDistanza(10, "4", "balestra");
            listaArmiDistanza.Add(arma);
            arma = new ArmaDistanza(7, "5", "fucile");
            listaArmiDistanza.Add(arma);
            arma2 = new ArmaVicino(6, "6", "spada");
            listaArmiVicino.Add(arma2);
            listaPersonaggiDaSerializzare = new List<Personaggio>();
            personaggio = new Personaggio("5", "valkiria", 210, 10, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("1", "maga", 170, 15, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("3", "marksman", 190, 13, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("2", "golem", 250, 7, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("6", "guerriero", 200, 11, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);
            personaggio = new Personaggio("4", "ninja", 155, 18, 1, 1);
            listaPersonaggiDaSerializzare.Add(personaggio);

            ScriviFileArmiDistanza();
            ScriviFileArmiVicino();
            ScriviFilePersonaggi();


            Campo c1 = new Campo("1", "/Personaggi Videogioco/Sfondi/Campo1.png");
            Campo c2 = new Campo("2", "/Personaggi Videogioco/Sfondi/Campo2.jpg");
            Campo c3 = new Campo("3", "/Personaggi Videogioco/Sfondi/Campo3.jpg");

            listaCampi.Add(c1);
            listaCampi.Add(c2);
            listaCampi.Add(c3);

            ScriviFileCampi();

            */
        }

       /* public void ScriviFileArmiDistanza()
        {
            using (StreamWriter sr = new StreamWriter("ArmiDistanza.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ArmaDistanza>));

                serializer.Serialize(sr, listaArmiDistanza);
            }
        }

        public void ScriviFileCampi()
        {
            using (StreamWriter sr = new StreamWriter("Campi.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Campo>));

                serializer.Serialize(sr, listaCampi);
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
        }*/

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
