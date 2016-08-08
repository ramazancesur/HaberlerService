using System;

namespace HaberWs.Models
{
    public class Haber
    {
        public int id { get; set; }
        public string url { get; set; }
        public string haberBaslik { get; set; }
        public DateTime haberYayımlanmaTarihi { get; set; }
        public HaberTuru haberTuru { get; set; }
        public HaberResim haberResim { get; set; }


        public virtual HaberResim HaberResim { get; set; }
    
        // Sosyal Medyada paylaşma, zoom in zoom out özelliklerini mutlaka ekte 

        // Kullanıcıya haberin yüklendiğine dair bir şey göster 

        // Android de servis yaz
    }
    public enum HaberTuru
    {
        SONDAKIKA,SPOR,EKONOMI,GUNCEL,MAGAZİN
    }
}