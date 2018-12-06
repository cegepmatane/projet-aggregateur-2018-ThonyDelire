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
        Controleur controleurAccueil = null;

        public CryptoMonnaieWindow()
        {
            MainWindow mainWindow = new MainWindow();

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        public void activerControleur(Controleur controleur)
        {
            Console.WriteLine("CryptoMonnaie.activerControleur()");
            this.controleurAccueil = controleur;
        }

        public void afficherMonnaie(List<CryptoMonnaie> listeMonnaies)
        {
            Console.WriteLine("CryptoWindow.afficherMonnaie");
            int monnaiePosition = 0;

            

           foreach (CryptoMonnaie crypto in listeMonnaies)
            {

                //this.Monnaie1.Text += crypto.nom + " ";
                    switch (monnaiePosition)
                {
                    case 0:
                        this.Monnaie1.Text = crypto.nom;
                        monnaiePosition++;
                        break;
                    case 1:
                        this.Monnaie2.Text = crypto.nom;
                        monnaiePosition++;
                        break;
                    case 2:
                        this.Monnaie3.Text = crypto.nom;
                        monnaiePosition++;
                        break;
                    case 3:
                        this.Monnaie4.Text = crypto.nom;
                        monnaiePosition++;
                        break;
                    case 4:
                        this.Monnaie5.Text = crypto.nom;
                        monnaiePosition++;
                        break;
                    case 5:
                        this.Monnaie5.Text = crypto.nom;
                        monnaiePosition++;
                        break;
                    case 6:
                        this.Monnaie6.Text = crypto.nom;
                        monnaiePosition++;
                        break;

                    default:
                        break;
                }
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
