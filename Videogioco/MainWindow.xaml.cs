﻿using System;
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
            throw new System.NotImplementedException();
        }

        public void ApriArmi()
        {
            throw new System.NotImplementedException();
        }

        public void ApriPersonaggi()
        {
            throw new System.NotImplementedException();
        }

        private void BtnInizia_Click(object sender, RoutedEventArgs e)
        {
            SceltaIniziale s = new SceltaIniziale();

            s.Show();
            
            this.Close();
        }
    }
}
