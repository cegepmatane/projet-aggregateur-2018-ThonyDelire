using System.IO;
using System;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;


namespace tp2
{
	class NouvelleDAO
	{
		
		public List<Nouvelle> listerNouvelles(string rss)
		{
			List<Nouvelle> listeNouvelles = new List<Nouvelle>();
			Console.WriteLine("RssDAO.listerNouvelles(" + rss + ")");
			HttpWebRequest requeteNouvelles = (HttpWebRequest)WebRequest.Create(rss);
			requeteNouvelles.Method = "GET";
			requeteNouvelles.UserAgent = "Mozilla Firefox";
			WebResponse reponse = requeteNouvelles.GetResponse();
			StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
			string xml = lecteur.ReadToEnd();
			XElement nouvellesXML = XElement.Parse(xml);
            Console.WriteLine("XElement " + nouvellesXML);
            foreach (XElement nouvelleXML in nouvellesXML.Elements())
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Element XML : " + nouvelleXML.Name.LocalName);
                XmlReader lecteurNouvelle = nouvelleXML.CreateReader();
                string test = nouvelleXML.Name.LocalName;
                
                if (test.CompareTo("entry") == 0)
                { 

                    lecteurNouvelle.ReadToDescendant("title");
                    string titre = lecteurNouvelle.ReadInnerXml();
                    Console.WriteLine(titre);

                    lecteurNouvelle.ReadToFollowing("summary");
                    string resume = lecteurNouvelle.ReadInnerXml();
                    Console.WriteLine(resume);

                    Nouvelle nouvelle = new Nouvelle();
                    nouvelle.titre = titre;
                    nouvelle.resume = resume;

                    listeNouvelles.Add(nouvelle);
                }
            }
			

			return listeNouvelles;
		}
	}
}
