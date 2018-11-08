using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace tp2
{
    class SalonDAO
    {
        public string listerSalons()
        {
            Console.WriteLine("Salon.listerSalons()");
            string json = "";

            string url = "https://slack.com/api/channels.history?token=xoxp-473953774023-474302126438-473582498485-a703b39ced648cdb7246978761c4117d&channel=CDXU1P58X&pretty=1";
            WebRequest requetesSalons = WebRequest.Create(url);
            WebResponse reponse = requetesSalons.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
            json = lecteur.ReadToEnd();
            return json;



        }
    }
}
