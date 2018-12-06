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
    /// Logique d'interaction pour RedditWindow.xaml
    /// </summary>
    public partial class RedditWindow : Window
    {
        Controleur controleurAccueil = null;
        TextBox[] grilleVuesTextes = new TextBox[6];

        public RedditWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            
            grilleVuesTextes[0] = this.rssBlocVue;
            grilleVuesTextes[1] = this.rssBlocVue2;
            grilleVuesTextes[2] = this.rssBlocVue3;
            grilleVuesTextes[3] = this.rssBlocVue4;
            grilleVuesTextes[4] = this.rssBlocVue5;
            grilleVuesTextes[5] = this.rssBlocVue6;

        }
        public void activerControleur(Controleur controleur)
        {
            Console.WriteLine("RedditWindow.activerControleur()");
            this.controleurAccueil = controleur;
        }
        public void afficherRssVue(List<RedditRss> listeRedditRss)
        {
            Console.WriteLine("RedditWindow.afficherRssVue");
            int memePosition = 0;
            foreach (RedditRss reddit in listeRedditRss)
            {
                Console.WriteLine("Reddit :" + reddit.title);
                if (memePosition == 6) break;
                this.grilleVuesTextes[memePosition].Text = reddit.title;

                memePosition++;
            }

            
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
