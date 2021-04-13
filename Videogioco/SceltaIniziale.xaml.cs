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
    /// Logica di interazione per SceltaIniziale.xaml
    /// </summary>
    public partial class SceltaIniziale : Window
    {
        private List<Arma> _armi;
        private List<Personaggio> _personaggi;
        private int _numeroArmaBlu;
        private int _numeroArmaRossa;
        private Utente[] _utenti;
        private int _isSetPersonaggioBlu;
        private int _isSetPeronaggioRosso;
        private int FILE_XML_PERSONAGGI;
        private int FILE_XML_ARMI;

        public SceltaIniziale()
        {
            InitializeComponent();
        }

        public Combattimento Combattimento
        {
            get => default;
            set
            {
            }
        }

        public void ApriCampo()
        {
            throw new System.NotImplementedException();
        }

        public void AggiungePersonaggioRosso()
        {
            throw new System.NotImplementedException();
        }

        public void AggiungiPersonaggioBlu()
        {
            throw new System.NotImplementedException();
        }

        public void AggiungiAmraRossa()
        {
            throw new System.NotImplementedException();
        }

        public void AggiungiArmaBlu()
        {
            throw new System.NotImplementedException();
        }

        public void LeggiFileArmi()
        {
            throw new System.NotImplementedException();
        }

        public void LeggiFilePersonaggi()
        {
            throw new System.NotImplementedException();
        }
    }
}
