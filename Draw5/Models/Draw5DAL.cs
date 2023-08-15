using System;
using Microsoft.AspNetCore.DataProtection;
using System.Net;
using Newtonsoft.Json;

namespace Draw5.Models
{
    public class Draw5DAL
    {
        public static Draw5Model Draw5()//Adjust here
        {
            //adjust
            //setup
    
            string url = "https://deckofcardsapi.com/api/deck/xs9uhva7cuwa/draw/?count=5";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //Adjust
            //Convert to C#
            //install Newtonsoft.json
            Draw5Model result = JsonConvert.DeserializeObject<Draw5Model>(json);
            return result;

        }

        public static void ShuffleDeck()//adjust here return type and name
        {
            //adjust url
            //setup section
            string url = "https://deckofcardsapi.com/api/deck/xs9uhva7cuwa/shuffle/?remaining=true";

            //request for data
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
