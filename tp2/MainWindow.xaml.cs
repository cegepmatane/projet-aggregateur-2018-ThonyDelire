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
        PokemonDAO pokemonDAO = new PokemonDAO();
        //CryptoMonnaieDAO cryptomonnaieDAO = new CryptoMonnaieDAO();
        //cryptomonnaieDAO.listerMonnaies();

        public MainWindow()
        {
            InitializeComponent();

            /*string redditRss = "https://www.reddit.com/r/dankmemes/.rss";
            List<RedditRss> listeRedditRss = redditDAO.listerNouvelles(redditRss);
	        foreach (RedditRss redditRss in listeRedditRss)
		    {
		       Console.WriteLine(nouvelle.titre);
	    	}*/

            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();
            foreach (Pokemon pokemon in listePokemon)
            {
                Console.WriteLine("Pokemon : " + pokemon.nom);
            }
        }


        
    }
}
