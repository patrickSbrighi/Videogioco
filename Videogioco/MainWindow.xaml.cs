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

namespace Videogioco
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
