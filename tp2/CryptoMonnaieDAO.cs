using System;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace tp2
{
	class CryptoMonnaieDAO
	{

		public string listerMonnaies()
        {
			Console.WriteLine("CryptoMonnaieDAO.listerMonnaies()");
			string url = "https://www.cryptocompare.com/api/data/coinlist/";
			HttpWebRequest requeteListeMonnaies = (HttpWebRequest)WebRequest.Create(url);
			WebResponse reponse = requeteListeMonnaies.GetResponse();
			StreamReader lecteurListeMonnaies = new StreamReader(reponse.GetResponseStream());
			string json = lecteurListeMonnaies.ReadToEnd();
			//Console.WriteLine(json);

			JavaScriptSerializer parseur = new JavaScriptSerializer();
			dynamic objet = parseur.Deserialize<dynamic>(json);
			var lesMonnaies = objet["Data"];
			foreach (dynamic itemMonnaie in lesMonnaies)
			{
				//Console.WriteLine(itemMonnaie.ToString());
				// Donne : [AXIS, System.Collections.Generic.Dictionary`2[System.String, System.Object]]
				
				var monnaie = itemMonnaie.Value;
				var symbole = monnaie["Symbol"];
				var nom = monnaie["CoinName"];
				var algorithme = monnaie["Algorithm"];
				var nombre = monnaie["TotalCoinSupply"];
				//var illustration = monnaie["ImageUrl"]; KeyNotFoundException
				Console.WriteLine("Monnaie " + symbole + " : " + nom + "("+nombre+")");

				
				CryptoMonnaie cryptomonnaie = new CryptoMonnaie();
				cryptomonnaie.symbole = symbole;
				cryptomonnaie.nom = nom;
				cryptomonnaie.algorithme = algorithme;
				cryptomonnaie.nombre = nombre;
			}

			return json;
		}

	}
}
