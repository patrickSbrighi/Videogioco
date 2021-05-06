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

namespace Videogioco
{
    /// <summary>
    /// Logica di interazione per Combattimento.xaml
    /// </summary>
    public partial class Combattimento : Window
    {
        private List<Campo> _campi;
        private int _nRound;
        private Random r;

        public Combattimento()
        {
            InitializeComponent();
            r = new Random();
            RandomCampo();
        }

        public Duello Duello
        {
            get => default;
            set
            {
            }
        }

        public void SparaRosso()
        {
            
        }

        public void SparaBlu()
        {
            throw new System.NotImplementedException();
        }

        public void SchivaRosso()
        {
            throw new System.NotImplementedException();
        }

        public void SchivaBlu()
        {
            throw new System.NotImplementedException();
        }

        
        public void RandomCampo()
        {
            int campo = r.Next(1, 4);
            BitmapImage img= new BitmapImage(new Uri("Campo"+campo.ToString()+".png", UriKind.Relative));
            image.Source = img;
        }

        public void NuovoRound()
        {
            throw new System.NotImplementedException();
        }

        public void TornaHome()
        {
            MainWindow home = new MainWindow();

            home.Show();

            this.Close();
        }
    }
}
