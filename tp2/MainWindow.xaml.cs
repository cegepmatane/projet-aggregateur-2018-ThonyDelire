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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace tp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RedditDAO redditDao = new RedditDAO();
        NouvelleDAO nouvelleDAO = new NouvelleDAO();
        PokemonDAO pokemonDAO = new PokemonDAO();
        SalonDAO salonDAO = new SalonDAO();
        CryptoMonnaieDAO cryptomonnaieDAO = new CryptoMonnaieDAO();
        Controleur controleurAccueil =  null;

        
        

        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            this.controleurAccueil = new Controleur();
            this.controleurAccueil.setAccueilPage(this);

           

        }

        private void Button_Click(object sender, RoutedEventArgs e)//Button Accueil
        {
            
        }

        private void slack_Click(object sender, RoutedEventArgs e)
        {
            controleurAccueil.notifierSlack();
            

        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            controleurAccueil.notifierMeteo();
            
        }

       private void Rss_Click(object sender, RoutedEventArgs e)
        {
            controleurAccueil.notifierRss();
            
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
