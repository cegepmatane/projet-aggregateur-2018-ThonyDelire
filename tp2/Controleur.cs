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
        public List<Nouvelle> listeNouvelles;
        public List<RedditRss> listeRedditRss;
        public List<Pokemon> listePokemon;
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
        MeteoWindow meteoPage = null;

        public void notifierMeteo()
         {
            Console.WriteLine("Controleur.notifierMeteo()");
            meteoPage = new MeteoWindow();
            meteoPage.activerControleur(this);
            meteoPage.Show();
            listeMeteo();

            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = meteoPage;

        }

        public void listeMeteo()
        {
            string rssMeteoQuebec = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
            listeNouvelles = nouvelleDAO.listerNouvelles(rssMeteoQuebec);
            meteoPage.afficherMeteoVue(listeNouvelles);
            
        }

        public void notifierSlack()
        {
            SlackWindow slackPage = new SlackWindow();
            slackPage.activerControleur(this);

            slackPage.Show();
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = slackPage;

            string listeSalons = salonDAO.listerSalons();
            Console.WriteLine(listeSalons);
        }

        public void notifierRss()
        {
            Console.WriteLine("Controleur.notifierRss()");
            redditPage = new RedditWindow();
            redditPage.activerControleur(this);
            redditPage.Show();
            afficherRssMeme();
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = redditPage;

            

        }

        RedditWindow redditPage = null;

        public void afficherRssMeme()
        {
            RedditDAO redditDao = new RedditDAO();
            string redditRss = "https://www.reddit.com/r/dankmemes/.rss";
            listeRedditRss = redditDao.listerRedditRss(redditRss);
            redditPage.afficherRssVue(listeRedditRss);
        }

        PokemonWindow pokemonPage = null;

        public void notifierPokemon()
        {
            Console.WriteLine("Controleur.notifierPokemon()");
            pokemonPage = new PokemonWindow();
            pokemonPage.activerControleur(this);
            pokemonPage.Show();
            afficherPokemon();
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = pokemonPage;

           
        }

        public void afficherPokemon()
        {
            listePokemon = pokemonDAO.listerPokemon();
            pokemonPage.afficherPokemon(listePokemon);
        }

        public void notifierCryptoM()
        {
            CryptoMonnaieWindow cryptoPage = new CryptoMonnaieWindow();
            cryptoPage.activerControleur(this);
            cryptoPage.Show();
            if (null != this.dernierePage) this.dernierePage.Close();
            this.dernierePage = cryptoPage;

            string listeMonnaies = cryptomonnaieDAO.listerMonnaies();
            Console.WriteLine(listeMonnaies);
        }
    }
}
