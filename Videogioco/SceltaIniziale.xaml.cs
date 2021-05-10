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
        private List<Arma> armi;// lista che contiene tutte le armi del gioco(variabile globale)
        private List<Personaggio> personaggi;//lista che contiene tutti i personaggi del gioco(variabile globale)
        private List<Arma> armiScelteRosso;
        private List<Arma> armiScelteBlu;
        private Personaggio personaggioSceltoBlu;
        private Personaggio personaggioSceltoRosso;
        private int nArmiBluScelte;
        private int nArmiRosseScelte;
        private Utente utenteRosso;
        private Utente utenteBlu;
        private int isSetPersonaggioBlu;
        private int isSetPeronaggioRosso;
        private int FILE_XML_PERSONAGGI;
        private int FILE_XML_ARMI;
        bool sceltaPersPossibileRosso;
        bool sceltaPersPossibileBlu;

        public SceltaIniziale()
        {
            InitializeComponent();
            personaggioSceltoBlu = null;
            personaggioSceltoRosso = null;
            nArmiBluScelte = 0;
            nArmiRosseScelte = 0;
            armiScelteRosso = new List<Arma>();
            armiScelteBlu = new List<Arma>();
            btnInizia.IsEnabled = false;
            ImpostaBottoni(true,0);
            sceltaPersPossibileRosso = true;
            sceltaPersPossibileBlu = true;
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
        //inizio metodi bottoni--------------------------------------------------------------------------------
        // METODI CLICK PERSONAGGIO BLU
        private void btnBP1_Click(object sender, RoutedEventArgs e)
        { 
            string nome = "valkiria";
            SceltaPersonaggioBlu(nome);
        }
        private void btnBP2_Click(object sender, RoutedEventArgs e)
        {        
            string nome = "maga";
            SceltaPersonaggioBlu(nome);
        }
        private void btnBP3_Click(object sender, RoutedEventArgs e)
        {
            string nome = "marksman";
            SceltaPersonaggioBlu(nome);
        }
        private void btnBP4_Click(object sender, RoutedEventArgs e)
        {
            string nome = "golem";
            SceltaPersonaggioBlu(nome);
        }
        private void btnBP5_Click(object sender, RoutedEventArgs e)
        {
            string nome = "guerriero";
            SceltaPersonaggioBlu(nome);
        }
        private void btnBP6_Click(object sender, RoutedEventArgs e)
        {
            string nome = "ninja";
            SceltaPersonaggioBlu(nome);
        }
        
        // METODI CLICK PERSONAGGIO ROSSO
        private void btnRP1_Click(object sender, RoutedEventArgs e)
        {
            string nome = "valkiria";
            SceltaPersonaggioRosso(nome);
        }
        private void btnRP2_Click(object sender, RoutedEventArgs e)
        {          
            string nome = "maga";
            SceltaPersonaggioRosso(nome);
        }
        private void btnRP3_Click(object sender, RoutedEventArgs e)
        {           
            string nome = "marksman";
            SceltaPersonaggioRosso(nome);
        }
        private void btnRP4_Click(object sender, RoutedEventArgs e)
        {           
            string nome = "golem";
            SceltaPersonaggioRosso(nome);
        }
        private void btnRP5_Click(object sender, RoutedEventArgs e)
        {           
            string nome = "guerriero";
            SceltaPersonaggioRosso(nome);
        }
        private void btnRP6_Click(object sender, RoutedEventArgs e)
        {         
            string nome = "ninja";
            SceltaPersonaggioRosso(nome);
        }
        // METODI CLICK ARMA BLU
        private void btnBA1_Click(object sender, RoutedEventArgs e)
        {
            string nome = "arco";
            sceltaArmaBlu(nome,1);
        }
        private void btnBA2_Click(object sender, RoutedEventArgs e)
        {
            string nome = "lancia";
            sceltaArmaBlu(nome,2);
        }
        private void btnBA3_Click(object sender, RoutedEventArgs e)
        {
            string nome = "guantone";
            sceltaArmaBlu(nome,3);
        }
        private void btnBA4_Click(object sender, RoutedEventArgs e)
        {
            string nome = "balestra";
            sceltaArmaBlu(nome,4);
        }
        private void btnBA5_Click(object sender, RoutedEventArgs e)
        {
            string nome = "fucile";
            sceltaArmaBlu(nome,5);
        }
        private void btnBA6_Click(object sender, RoutedEventArgs e)
        {
            string nome = "spada";
            sceltaArmaBlu(nome,6);
        }
        // METODI CLICK ARMA ROSSO
        private void btnRA1_Click(object sender, RoutedEventArgs e)
        {
            string nome = "arco";
            sceltaArmaRossa(nome,1);
        }
        private void btnRA2_Click(object sender, RoutedEventArgs e)
        {
            string nome = "lancia";
            sceltaArmaRossa(nome,2);
        }
        private void btnRA3_Click(object sender, RoutedEventArgs e)
        {
            string nome = "guantone";
            sceltaArmaRossa(nome,3);
        }
        private void btnRA4_Click(object sender, RoutedEventArgs e)
        {
            string nome = "balestra";
            sceltaArmaRossa(nome,4);
        }
        private void btnRA5_Click(object sender, RoutedEventArgs e)
        {
            string nome = "fucile";
            sceltaArmaRossa(nome,5);
        }
        private void btnRA6_Click(object sender, RoutedEventArgs e)
        {
            string nome = "spada";
            sceltaArmaRossa(nome,6);
        }
        //fine metodi bottoni--------------------------------------------------------------------------------
        private void btnInizia_Click(object sender, RoutedEventArgs e)
        {
            Combattimento combattimento = new Combattimento(utenteRosso, utenteBlu);
            combattimento.Show();
            this.Close();
        }

        private void ImpostaBottoni(bool impostazione, int opzioni)
        {
            /* 0 = imposta tutti
             * 1= imposta personaggi blu
             * 2 = imposta armi blu
             * 3 = imposta personaggi rossi
             * 4 = imposta armi rosse
             */
            if (opzioni == 0)
            {
                //personaggi blu
                btnBP1.IsEnabled = impostazione;
                btnBP2.IsEnabled = impostazione;
                btnBP3.IsEnabled = impostazione;
                btnBP4.IsEnabled = impostazione;
                btnBP5.IsEnabled = impostazione;
                btnBP6.IsEnabled = impostazione;
                //armi blu
                btnBA1.IsEnabled = impostazione;
                btnBA2.IsEnabled = impostazione;
                btnBA3.IsEnabled = impostazione;
                btnBA4.IsEnabled = impostazione;
                btnBA5.IsEnabled = impostazione;
                btnBA6.IsEnabled = impostazione;
                //personaggi rossi
                btnRP1.IsEnabled = impostazione;
                btnRP2.IsEnabled = impostazione;
                btnRP3.IsEnabled = impostazione;
                btnRP4.IsEnabled = impostazione;
                btnRP5.IsEnabled = impostazione;
                btnRP6.IsEnabled = impostazione;
                //armi rosse
                btnRA1.IsEnabled = impostazione;
                btnRA2.IsEnabled = impostazione;
                btnRA3.IsEnabled = impostazione;
                btnRA4.IsEnabled = impostazione;
                btnRA5.IsEnabled = impostazione;
                btnRA6.IsEnabled = impostazione;
            }
            else if (opzioni == 1)
            {
                //personaggi blu
                btnBP1.IsEnabled = impostazione;
                btnBP2.IsEnabled = impostazione;
                btnBP3.IsEnabled = impostazione;
                btnBP4.IsEnabled = impostazione;
                btnBP5.IsEnabled = impostazione;
                btnBP6.IsEnabled = impostazione;
            }
            else if (opzioni == 2)
            {
                //armi blu
                btnBA1.IsEnabled = impostazione;
                btnBA2.IsEnabled = impostazione;
                btnBA3.IsEnabled = impostazione;
                btnBA4.IsEnabled = impostazione;
                btnBA5.IsEnabled = impostazione;
                btnBA6.IsEnabled = impostazione;
            }
            else if (opzioni == 3)
            {
                //personaggi rossi
                btnRP1.IsEnabled = impostazione;
                btnRP2.IsEnabled = impostazione;
                btnRP3.IsEnabled = impostazione;
                btnRP4.IsEnabled = impostazione;
                btnRP5.IsEnabled = impostazione;
                btnRP6.IsEnabled = impostazione;
            }
            else if (opzioni == 4)
            {
                //armi rosse
                btnRA1.IsEnabled = impostazione;
                btnRA2.IsEnabled = impostazione;
                btnRA3.IsEnabled = impostazione;
                btnRA4.IsEnabled = impostazione;
                btnRA5.IsEnabled = impostazione;
                btnRA6.IsEnabled = impostazione;
            }
        }

        private void ControlloSelezione()
        {
            if(nArmiBluScelte == 3)
            {
                ImpostaBottoni(false, 2);
            }
            if(nArmiRosseScelte == 3)
            {
                ImpostaBottoni(false, 4);
            }
            if(nArmiBluScelte == 3 && nArmiRosseScelte == 3 && personaggioSceltoRosso != null && personaggioSceltoBlu != null)
            {
                ImpostaBottoni(false, 0);
                btnInizia.IsEnabled = true;
            }
        }

        private void SceltaPersonaggioBlu(string nome)
        {
            if (personaggioSceltoBlu == null)
            {
                foreach (Personaggio personaggioScelto in personaggi)
                {
                    if (personaggioScelto.Nome == nome)
                    {
                        personaggioSceltoBlu = personaggioScelto;
                    }
                }
                ImpostaBottoni(false, 1);
            }
        }

        private void SceltaPersonaggioRosso(string nome)
        {
            if (personaggioSceltoRosso == null)
            {
                foreach (Personaggio personaggioScelto in personaggi)
                {
                    if (personaggioScelto.Nome == nome)
                    {
                        personaggioSceltoRosso = personaggioScelto;
                    }
                }
                ImpostaBottoni(false, 3);
            }
        }

        private void sceltaArmaBlu(string nome,int n)
        {
            if (nArmiBluScelte <= 3)
            {
                foreach (Arma armaScelta in armi)
                {
                    if (armaScelta.Nome == nome)
                    {
                        armiScelteBlu.Add(armaScelta);
                    }
                }
                IsEnabled = false;
                ControlloSelezione();
                if (n == 1)
                { btnBA1.IsEnabled = false; }
                else if (n == 2)
                { btnBA2.IsEnabled = false; }
                else if (n == 3)
                { btnBA3.IsEnabled = false; }
                else if (n == 4)
                { btnBA4.IsEnabled = false; }
                else if (n == 5)
                { btnBA5.IsEnabled = false; }
                else if (n == 6)
                { btnBA6.IsEnabled = false; }
            }
        }

        private void sceltaArmaRossa(string nome, int n)
        {
            if (nArmiRosseScelte <= 3)
            {
                foreach (Arma armaScelta in armi)
                {
                    if (armaScelta.Nome == nome)
                    {
                        armiScelteRosso.Add(armaScelta);
                    }
                }
                IsEnabled = false;
                ControlloSelezione();
                if(n==1)
                { btnRA1.IsEnabled = false; }
                else if(n ==2)
                { btnRA2.IsEnabled = false; }
                else if(n==3)
                { btnRA3.IsEnabled = false; }
                else if(n==4)
                { btnRA4.IsEnabled = false; }
                else if(n==5)
                { btnRA5.IsEnabled = false; }
                else if(n==6)
                { btnRA6.IsEnabled = false; }
            }


        }

        
    }
}
