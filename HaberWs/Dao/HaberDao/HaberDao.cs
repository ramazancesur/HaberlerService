using HaberWs.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;

namespace HaberWs.Dao
{
    public class HaberDao
    {
        public static string getContent(string AdressUrl)
        {
            Uri url = new Uri(AdressUrl);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            string html = client.DownloadString(url);
            return html;
        }
   


        public List<Haber> InsertNewProduct()
        {
           
            HtmlAgilityPack.HtmlWeb htmlweb = new HtmlAgilityPack.HtmlWeb();
            string htmlContext = getContent("http://www.haber7.com/sondakika");
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(htmlContext);
            List<Haber> lstHaber = new List<Haber>();
            Haber haber;

            HtmlNodeCollection element = document.DocumentNode.SelectNodes("//div[@class='title']");
            foreach (HtmlNode item in element)
            {
                haber = new Haber();
                haber.haberTuru = HaberTuru.SONDAKIKA;
                haber.haberBaslik = item.InnerText;
                lstHaber.Add(haber);
            }
            //  "//div[@class='picture']//img/@src"

            return lstHaber;
        }
    }
}