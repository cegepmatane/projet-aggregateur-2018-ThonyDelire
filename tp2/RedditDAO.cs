using System.IO;
using System;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;

namespace tp2
{
    class RedditDAO
    {
        public List<RedditRss> listerRedditRss(string rss)
        {
            List<RedditRss> listeRedditRss = new List<RedditRss>();
            Console.WriteLine("RssDAO.listerRedditRss(" + rss + ")");
            HttpWebRequest requeteRedditRss = (HttpWebRequest)WebRequest.Create(rss);
            requeteRedditRss.Method = "GET";
            requeteRedditRss.UserAgent = "Mozilla Firefox";
            
            WebResponse reponse = requeteRedditRss.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
            string xml = lecteur.ReadToEnd();
            XElement RedditXML = XElement.Parse(xml);
            foreach (XElement RedditRssXML in RedditXML.Elements())
            {
             
                
                XmlReader lecteurReddit = RedditRssXML.CreateReader();

                string test = RedditRssXML.Name.LocalName;
                //if (test.CompareTo("entry") != 0) continue;
                if (test.CompareTo("entry") == 0)
                {
                    lecteurReddit.ReadToDescendant("title");
                    string titre = lecteurReddit.ReadInnerXml();
                    Console.WriteLine(titre);



                    lecteurReddit.ReadToFollowing("content");
                    string publication = lecteurReddit.ReadInnerXml();
                    Console.WriteLine(publication);



                    lecteurReddit.ReadToFollowing("name");
                    string nom = lecteurReddit.ReadInnerXml();
                    Console.WriteLine(nom);

                    RedditRss redditRss = new RedditRss();
                    redditRss.title = titre;
                    //nouvelle.lien = lien;
                    redditRss.content = publication;
                    //nouvelle.categorie = categorie;
                    redditRss.name = nom;

                    listeRedditRss.Add(redditRss);
                }
            }
            //string titre = (string)lecteurNouvelle.ReadContentAs(typeof(string), null); // bug

            return listeRedditRss;
        }
    }
}
