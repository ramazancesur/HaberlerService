using HaberWs.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberWs.Dao.HaberResimDao
{
    public class haberResimDao
    {

        public List<HaberResim> InsertNewProduct()
        {

            HtmlAgilityPack.HtmlWeb htmlweb = new HtmlAgilityPack.HtmlWeb();
            string htmlContext = HaberDao.getContent("http://www.haber7.com/sondakika");
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(htmlContext);
            List<Haber> lstHaber = new List<Haber>();
            Haber haber;

            HtmlNodeCollection element = document.DocumentNode.SelectNodes("//div[@class='picture']//img");
            foreach (HtmlNode item in element)
            {
                haber = new Haber();
                haber.haberTuru = HaberTuru.SONDAKIKA;
                haber.haberBaslik = item.InnerText;
                haber.HaberResim
                lstHaber.Add(haber);
            }



            return lstHaber;
        }
    }
}