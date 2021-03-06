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
using System.Windows.Shapes;

namespace tp2
{
    /// <summary>
    /// Logique d'interaction pour SlackWindow.xaml
    /// </summary>
    public partial class SlackWindow : Window
    {
        Controleur controleurAccueil = null;

        public SlackWindow()
        {

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }
        public void activerControleur(Controleur controleur)
        {
            Console.WriteLine("SlackWindow.activerControleur()");
            this.controleurAccueil = controleur;
        }

        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainPage = new MainWindow();
            mainPage.Show();
            this.Close();
        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            controleurAccueil.notifierMeteo();
        }

        private void Rss_Click(object sender, RoutedEventArgs e)
        {
            controleurAccueil.notifierRss();
        }

        private void slack_Click(object sender, RoutedEventArgs e)
        {
            controleurAccueil.notifierSlack();
        }

        private void cryptomo_Click(object sender, RoutedEventArgs e)
        {
            controleurAccueil.notifierCryptoM();
        }

        private void pokemon_Click(object sender, RoutedEventArgs e)
        {
            controleurAccueil.notifierPokemon();
        }
    }
}
