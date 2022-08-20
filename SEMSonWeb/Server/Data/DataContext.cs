using Microsoft.EntityFrameworkCore;
using SEMSonWeb.Shared.Entities;

namespace SEMSonWeb.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<SPClientDep> SPClientDepdb { get; set; }
        public DbSet<SPClientClass> SPClientClassdb { get; set; }
        public DbSet<SPClientPos> SPClientPosdb { get; set; }
        public DbSet<SPClientPre> SPClientPredb { get; set; }
        public DbSet<SPClientProfile> SPClientProfiledb { get; set; }
        public DbSet<SPClientUser> SPClientUserdb { get; set; }
        public DbSet<SPHisAction> SPHisActiondb { get; set; }
        public DbSet<SPModelEquip> SPModelEquipdb { get; set; }
        public DbSet<SPModelSport> SPModelSportdb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<SPClientProfile>()
               .HasKey(t => new {t.PHProfileCode });

            modelBuilder.Entity<SPClientProfile>()
               .HasOne(pt => pt.LSPClientClass)
               .WithMany(p => p.SPClientProfileCla)
               .HasForeignKey(pt => pt.PHClassCode);

            modelBuilder.Entity<SPClientProfile>()
               .HasOne(pt => pt.LSPClientDep)
               .WithMany(p => p.SPClientProfileDep)
               .HasForeignKey(pt => pt.PHDepCode);

            modelBuilder.Entity<SPClientProfile>()
               .HasOne(pt => pt.LSPClientPos)
               .WithMany(p => p.SPClientProfilePos)
               .HasForeignKey(pt => pt.PHPosCode);

            modelBuilder.Entity<SPClientProfile>()
               .HasOne(pt => pt.LSPClientPre)
               .WithMany(p => p.SPClientProfilePre)
               .HasForeignKey(pt => pt.PHPreCode);*/

            /*modelBuilder.Entity<SPClientUser>()
                .HasKey(u => new { u.PHUserCode, u.PHProfileCode });*/

            modelBuilder.Entity<SPClientUser>()
              .HasOne(pt => pt.LSPClientProfile)
              .WithOne(p => p.LSPClientUser)
              .HasForeignKey<SPClientUser>(pt => pt.PHProfileCode);
        }
    }
}
