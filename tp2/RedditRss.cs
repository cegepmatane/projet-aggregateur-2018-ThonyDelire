using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    class RedditRss
    {
        //NECESSAIRE
        public string updated { get; set; }// publier le...
        public string id { get; set; }
        public string title { get; set; }
        public string name { get; set; } // Nom de l'auteur
        public string content { get; set; }// Contenu de la publication

        //OPTIONNEL
        public string icon { get; set; }//icone d'utilisateur

    }
}
