using System.Collections.Generic;

namespace HaberWs.Models
{
    public class HaberDetay
    {
        public int id { get; set; }
        public string haber { get; set; }
      
        public virtual List<HaberResim> HaberResims { get; set; }
        public virtual List<HaberYorum> HaberYorums { get; set; }
    }
}