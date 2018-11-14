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
        Controleur controleur = new Controleur();

        
        

        public MainWindow()
        {
            InitializeComponent();



        }

        public void AfficherMeteo()
        {
            string rssMeteoQuebec = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles(rssMeteoQuebec);
            foreach (Nouvelle nouvelle in listeNouvelles)
            {
                Console.WriteLine(nouvelle.titre);
            }
}

        public void AfficherPokemon()
        {
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();
            foreach (Pokemon pokemon in listePokemon)
            {
                Console.WriteLine("Pokemon : " + pokemon.nom);
            }
        }

        public void AfficherCryptomonaie()
        {
            string listeMonnaies = cryptomonnaieDAO.listerMonnaies();
            Console.WriteLine(listeMonnaies);
        }

        public void AfficherReddit()
        {
            string redditRss = "https://www.reddit.com/r/dankmemes/.rss";
            List<RedditRss> listeRedditRss = redditDao.listerRedditRss(redditRss);
            foreach (RedditRss reddit in listeRedditRss)
            {
                Console.WriteLine(reddit.title);
            }
        }

        public void SalonSlack()
        {
            string listeSalons = salonDAO.listerSalons();
            Console.WriteLine(listeSalons);
        }


        private void Button_Click(object sender, RoutedEventArgs e)//Button Accueil
        {
            
        }

        private void slack_Click(object sender, RoutedEventArgs e)
        {
            SlackWindow slackPage = new SlackWindow();
            slackPage.Show();
            this.Close();

        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Rss_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void cryptomo_Click(object sender, RoutedEventArgs e)
        {
            AfficherCryptomonaie();
        }

        private void pokemon_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

}
