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
    /// Logique d'interaction pour meteoWindow.xaml
    /// </summary>
    public partial class MeteoWindow : Window
    {
        Controleur controleurAccueil = null;
        NouvelleDAO nouvelleDAO = new NouvelleDAO();



        public MeteoWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            
        }
        public void afficherMeteoVue(List<Nouvelle> listeMeteo)
        {
            Console.WriteLine("MeteoWindow.affchicherMeteoVue()");
            temperature.Text = "";
            foreach (Nouvelle nouvelle in listeMeteo)
            {
                temperature.Text += nouvelle.titre + " ";
                Console.WriteLine("Nouvelle:" + nouvelle.titre);
            }
        }
        

        public void activerControleur(Controleur controleur)
        {
            Console.WriteLine("MeteoWindow.activerControleur()");
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
            Console.WriteLine("MeteoWindow.Meteo_Click()");
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

        private void temperature_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
