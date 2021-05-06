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

        public Combattimento()
        {
            InitializeComponent();
        }

        public Duello Duello
        {
            get;
            set;
        }

        public void SparaRosso()
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public void NuovoRound()
        {
            throw new System.NotImplementedException();
        }

        public void TornaHome()
        {
            throw new System.NotImplementedException();
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
    }
}
