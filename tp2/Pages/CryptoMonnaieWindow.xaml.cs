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

namespace tp2
{
    /// <summary>
    /// Logique d'interaction pour CryptoMonnaieWindow.xaml
    /// </summary>
    public partial class CryptoMonnaieWindow : Window
    {
        public CryptoMonnaieWindow()
        {
            MainWindow mainWindow = new MainWindow();

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainPage = new MainWindow();
            mainPage.Show();
            this.Close();
        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow.AfficherMeteo();
            MeteoWindow meteoPage = new MeteoWindow();
            meteoPage.Show();
            this.Close();
        }

        private void Rss_Click(object sender, RoutedEventArgs e)
        {
            
            RedditWindow RedditPage = new RedditWindow();
            RedditPage.Show();
            this.Close();
        }

        private void slack_Click(object sender, RoutedEventArgs e)
        {
            
            SlackWindow slackPage = new SlackWindow();
            slackPage.Show();
            this.Close();
        }

        private void cryptomo_Click(object sender, RoutedEventArgs e)
        {
            
            CryptoMonnaieWindow CryptoPage = new CryptoMonnaieWindow();
            CryptoPage.Show();
            this.Close();
            //AfficherCryptomonaie();
        }

        private void pokemon_Click(object sender, RoutedEventArgs e)
        {
            
            PokemonWindow PokemonPage = new PokemonWindow();
            PokemonPage.Show();
            this.Close();
        }
    }
}
