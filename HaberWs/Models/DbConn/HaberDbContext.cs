using System.Data.Entity;

namespace HaberWs.Models.DbConn
{
    public class HaberDbContext: DbContext
    {
        public DbSet<Haber> Habers { get; set; }
        public DbSet<HaberDetay> HaberDetays { get; set; }
        public DbSet<HaberResim> HaberResims { get; set; }
        public DbSet<HaberYorum> HaberYorums { get; set; }
    }
}