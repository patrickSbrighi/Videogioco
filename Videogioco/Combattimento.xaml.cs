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
            get => default;
            set
            {
            }
        }

        public void SparaRosso()
        {
<<<<<<< Updated upstream
            throw new System.NotImplementedException();
=======
           // Duello.Utenti
>>>>>>> Stashed changes
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
    }
}
