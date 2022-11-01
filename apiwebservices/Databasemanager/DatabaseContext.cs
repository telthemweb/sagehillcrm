using apiwebservices.Model;
using Microsoft.EntityFrameworkCore;

namespace apiwebservices.Databasemanager
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public DbSet<Role> roles { get; set; }
        public DbSet<Administrator> administrator { get; set; }

        public DbSet<AuditTrailt> auditTrailt { get; set; }
        public DbSet<Permision> permision { get; set; }

        public DbSet<SystemModule> systemModule { get; set; }

        public DbSet<Submodule> submodule { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SystemModule>().HasMany(s => s.role).WithMany(r => r.systemModule).UsingEntity(rs => rs.ToTable("systemmodules_roles"));
            builder.Entity<Submodule>().HasMany(sub => sub.roles).WithMany(sr => sr.submodules).UsingEntity(rs => rs.ToTable("submodules_roles"));
            builder.Entity<Permision>().HasMany(p => p.roles).WithMany(pr => pr.permisions).UsingEntity(rp => rp.ToTable("permission_roles"));



        }
    }
}
