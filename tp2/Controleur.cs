using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace tp2
{


    public class Controleur
    {
        RedditDAO redditDao = new RedditDAO();
        NouvelleDAO nouvelleDAO = new NouvelleDAO();
        PokemonDAO pokemonDAO = new PokemonDAO();
        SalonDAO salonDAO = new SalonDAO();
        CryptoMonnaieDAO cryptomonnaieDAO = new CryptoMonnaieDAO();

        protected MainWindow accueilPage = null;
        //public MainWindow accueilPage { get; set; }

        public void setAccueilPage(MainWindow accueilPage)
        {
            this.accueilPage = accueilPage;

        }

        protected Window dernierePage = null;

        public void notifierAccueil()
        {
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = accueilPage;
        }

        public void notifierMeteo()
         {
            Console.WriteLine("Controleur.notifierMeteo()");
            MeteoWindow meteoPage = new MeteoWindow();
            meteoPage.activerControleur(this);
            meteoPage.Show();

            if(null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = meteoPage;

            string rssMeteoQuebec = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles(rssMeteoQuebec);
            foreach (Nouvelle nouvelle in listeNouvelles)
            {
                Console.WriteLine(nouvelle.titre);
            }

        }

        public void notifierSlack()
        {
            SlackWindow slackPage = new SlackWindow();
            slackPage.Show();
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = slackPage;

            string listeSalons = salonDAO.listerSalons();
            Console.WriteLine(listeSalons);
        }

        public void notifierRss()
        {
            RedditWindow redditPage = new RedditWindow();
            redditPage.Show();
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = redditPage;

            string redditRss = "https://www.reddit.com/r/dankmemes/.rss";
            List<RedditRss> listeRedditRss = redditDao.listerRedditRss(redditRss);
            foreach (RedditRss reddit in listeRedditRss)
            {
                Console.WriteLine(reddit.title);
            }
        }

        public void notifierPokemon()
        {
            PokemonWindow pokemonPage = new PokemonWindow();
            pokemonPage.Show();
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = pokemonPage;

            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();
            foreach (Pokemon pokemon in listePokemon)
            {
                Console.WriteLine("Pokemon : " + pokemon.nom);
            }
        }

        public void notifierCryptoM()
        {
            CryptoMonnaieWindow cryptoPage = new CryptoMonnaieWindow();
            cryptoPage.Show();
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = cryptoPage;

            string listeMonnaies = cryptomonnaieDAO.listerMonnaies();
            Console.WriteLine(listeMonnaies);
        }
    }
}
