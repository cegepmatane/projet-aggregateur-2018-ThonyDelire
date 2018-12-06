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
    /// Logique d'interaction pour PokemonWindow.xaml
    /// </summary>
    public partial class PokemonWindow : Window
    {
        Controleur controleurAccueil = null;
        

        public PokemonWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            
        }

        public void afficherPokemon(List<Pokemon> listePokemon)
        {
            Console.WriteLine("PokemonWindow.afficherPokemon");
            int pokemonPosition = 0;

            
            foreach (Pokemon poke in listePokemon)
            {
                switch (pokemonPosition)
                {
                    case 0:
                        this.poke1.Text = poke.nom;
                        pokemonPosition++;
                        break;
                    case 1:
                        this.poke2.Text = poke.nom;
                        pokemonPosition++;
                        break;
                    case 2:
                        this.poke3.Text = poke.nom;
                        pokemonPosition++;
                        break;
                    case 3:
                        this.poke4.Text = poke.nom;
                        pokemonPosition++;
                        break;
                    case 4:
                        this.poke5.Text = poke.nom;
                        pokemonPosition++;
                        break;
                    case 5:
                        this.poke6.Text = poke.nom;
                        pokemonPosition++;
                        break;
                    default:
                        break;
                }
            }
            
        }

        

        public void activerControleur(Controleur controleur)
        {
            Console.WriteLine("PokemonWindow.activerControleur()");
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
