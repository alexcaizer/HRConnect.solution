using HRConnect.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HRConnect.Server.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<Candidato> Candidati { get; set; }
        public DbSet<Citta> Citta { get; set; }
        public DbSet<Colloquio> Colloqui { get; set; }
        public DbSet<Contratto> Contratti { get; set; }
        public DbSet<LivelloContrattuale> LivelliContrattuali { get; set; }
        public DbSet<Dipendente> Dipendenti { get; set; }
        public DbSet<Documento> Documenti{ get; set; }
        public DbSet<EsperienzaLavorativa> EsperienzeLavorative { get; set; }
        public DbSet<Mansione> Mansioni { get; set; }
        public DbSet<HardSkill> HardSkills { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }
        public DbSet<HR> HRs{get; set;}
        public DbSet<Sede> Sedi{get; set;}
        public DbSet<TitoloDiStudio> TitoliDiStudio {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sede>()
                .HasOne(c => c.HR)
                .WithOne(c => c.Sede);

            modelBuilder.Entity<HR>()
                .HasOne(c => c.Sede)
                .WithOne(c => c.HR);

            //modelBuilder.Entity<Candidato>()
            //    .HasOne(c => c.Colloquio)
            //    .WithOne(c => c.Candidato)
            //    .HasForeignKey<Candidato>(c => c.ColloquioId);

            modelBuilder.Entity<Colloquio>()
                .HasOne(c => c.HR)
                .WithMany(c => c.Colloqui)
                .HasForeignKey(c => c.HRId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Colloquio>()
                .HasOne(c => c.Sede)
                .WithMany(c => c.Colloqui)
                .HasForeignKey(c => c.SedeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Dipendente>()
                .HasOne(c => c.LivelliContrattuali)
                .WithOne(c => c.Dipendente)
                .HasForeignKey<Dipendente>(c => c.LivelloContrattualeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<HardSkill>()
                .HasOne(c => c.LivelliContrattuali)
                .WithOne(c => c.HardSkill)
                .HasForeignKey<HardSkill>(c => c.LivelloContrattualeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SoftSkill>()
                .HasOne(c => c.LivelloContrattuale)
                .WithOne(c => c.SoftSkill)
                .HasForeignKey<SoftSkill>(c => c.LivelloContrattualeId)
                .OnDelete(DeleteBehavior.NoAction);

            /* modelBuilder.Entity<PosizioneAperte>()
                 .HasOne(c => c.Contrattos)
                 .WithOne(c => c.PosizioneApertes)
                 .HasForeignKey<Contratto>(c => c.PosizioneAperteId);

             modelBuilder.Entity<Colloquio>()
                 .HasOne(c => c.HRNavigation)
                 .WithMany(c => c.Colloquios)
                 .HasForeignKey(c => c.HRId)
                 .OnDelete(DeleteBehavior.NoAction);

             modelBuilder.Entity<Colloquio>()
                 .HasOne(c => c.SedeNavigation)
                 .WithMany(c => c.Colloquios)
                 .HasForeignKey(c => c.SedeId)
                 .OnDelete(DeleteBehavior.NoAction);*/
        }

    }
}
