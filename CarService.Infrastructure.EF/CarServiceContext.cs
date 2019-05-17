using ModelDesignFirst_L1;
using System.Data.Entity;

namespace CarService.Infrastructure.EF
{
    public class CarServiceContext : DbContext
    {
        public CarServiceContext() : base(@"Server=DESKTOP-SV5EGCB\MSSQLSERVER01; Database=Master; Trusted_Connection=True")
        {

        }
        public DbSet<Auto> Autoes { get; set; }

        public DbSet<Client> Clienti { get; set; }

        public DbSet<Comanda> Comenzi { get; set; }

        public DbSet<DetaliuComanda> DetaliuComenzi { get; set; }

        public DbSet<Imagine> Imagini { get; set; }

        public DbSet<Material> Materiale { get; set; }

        public DbSet<Mecanic> Mecanici { get; set; }

        public DbSet<Operatie> Operatii { get; set; }

        public DbSet<Sasiu> Sasius { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
                .HasOptional(a => a.Comanda)
                .WithRequired(c => c.Auto);

            modelBuilder.Entity<Sasiu>()
              .HasOptional(s => s.Auto)
              .WithRequired(a => a.Sasiu);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Auto)
                .WithOptional(a => a.Client)
                .HasForeignKey(a => a.Client_Id);
            modelBuilder.Entity<Auto>()
                .Property(p => p.Client_Id).IsOptional();

            modelBuilder.Entity<DetaliuComanda>()
                .HasOptional(dc => dc.Comanda)
                .WithRequired(c => c.DetaliuComanda);
            modelBuilder.Entity<Comanda>()
                .Property(p => p.DetaliuComanda_Id).IsOptional();

            modelBuilder.Entity<DetaliuComanda>()
                .HasMany(dc => dc.Materials)
                .WithOptional(m => m.DetaliuComanda)
                .HasForeignKey(m => m.DetaliuComanda_Id);
            modelBuilder.Entity<Material>()
                .Property(p => p.DetaliuComanda_Id).IsOptional();

            modelBuilder.Entity<DetaliuComanda>()
                .HasMany(dc => dc.Mecanici)
                .WithOptional(mc => mc.DetaliuComanda)
                .HasForeignKey(mc => mc.DetaliuComanda_Id);
            modelBuilder.Entity<Mecanic>()
                .Property(p => p.DetaliuComanda_Id).IsOptional();

            modelBuilder.Entity<DetaliuComanda>()
                .HasMany(dc => dc.Operaties)
                .WithOptional(o => o.DetaliuComanda)
                .HasForeignKey(o => o.DetaliuComanda_Id);
            modelBuilder.Entity<Operatie>()
                .Property(p => p.DetaliuComanda_Id).IsOptional();

            modelBuilder.Entity<DetaliuComanda>()
                .HasMany(dc => dc.Imagines)
                .WithOptional(i => i.DetaliuComanda)
                .HasForeignKey(i => i.DetaliuComanda_Id);
            modelBuilder.Entity<Imagine>()
                .Property(p => p.DetaliuComanda_Id).IsOptional();
        }
    }
}
