using Microsoft.EntityFrameworkCore;
using GestionDesArchivesWebApp.Models;

namespace GestionDesArchivesWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Conteneur> Conteneurs { get; set; }
        public DbSet<Contenu> Contenus { get; set; }
        public DbSet<Emplacement> Emplacements { get; set; }
        public DbSet<EnteteInventaire> EnteteInventaires { get; set; }
        public DbSet<Inventaire> Inventaires { get; set; }
        public DbSet<InventaireRealisee> InventaireRealisees { get; set; }
        public DbSet<Lieux> Lieux { get; set; }
        public DbSet<LogArch> LogArchs { get; set; }
        public DbSet<LogExploitation> LogExploitations { get; set; }
        public DbSet<LogInfo> LogInfos { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Societe> Societes { get; set; }
        public DbSet<StadeClassement> StadeClassements { get; set; }
        public DbSet<StatutDoc> StatutDocs { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<TypDoc> TypDocs { get; set; }
        public DbSet<TypeClassement> TypeClassements { get; set; }
        public DbSet<TypeCon> TypeCons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Conteneur>()
                .HasKey(c => c.CdeCon);

            modelBuilder.Entity<Contenu>()
                .HasKey(c => c.CdePiece);

            modelBuilder.Entity<Emplacement>()
                .HasKey(e => e.CdeEmpl);

            modelBuilder.Entity<EnteteInventaire>()
                .HasKey(e => e.IdEntete);

            modelBuilder.Entity<Inventaire>()
                .HasKey(i => i.IdInventaire);

            modelBuilder.Entity<InventaireRealisee>()
                .HasKey(ir => ir.IdInventaireRealisee);

            modelBuilder.Entity<Lieux>()
                .HasKey(l => l.CdeLieu);

            modelBuilder.Entity<LogArch>()
                .HasKey(la => la.CdeLogA);

            modelBuilder.Entity<LogExploitation>()
                .HasKey(le => le.CdeLogEx);

            modelBuilder.Entity<LogInfo>()
                .HasKey(li => li.CdeUtl);

            modelBuilder.Entity<Personnel>()
                .HasKey(p => p.CdePer);

            modelBuilder.Entity<Service>()
                .HasKey(s => s.CdeSer);

            modelBuilder.Entity<Societe>()
                .HasKey(s => s.CdeSoc);

            modelBuilder.Entity<StadeClassement>()
                .HasKey(sc => sc.CdeStd);

            modelBuilder.Entity<StatutDoc>()
                .HasKey(sd => sd.CdeStat);

            modelBuilder.Entity<Support>()
                .HasKey(s => s.CdeSup);

            modelBuilder.Entity<TypDoc>()
                .HasKey(td => td.CdeTypDoc);

            modelBuilder.Entity<TypeClassement>()
                .HasKey(tc => tc.CdeTypClass);

            modelBuilder.Entity<TypeCon>()
                .HasKey(tc => tc.CdeTypCon);
       
            // Configurations des relations


            // Configurations supplémentaires des relations à ajouter ici

        }
    }
}