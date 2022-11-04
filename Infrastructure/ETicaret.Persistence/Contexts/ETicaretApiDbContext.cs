using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities;
using ETicaret.Domain.Entities.Common;

namespace ETicaret.Persistence.Contexts
{
    public class ETicaretApiDbContext : DbContext
    {
        public ETicaretApiDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                //_ = data.State switch
                //{
                //    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                //    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                //};

                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        data.Entity.UpdatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Detached: break;
                    case EntityState.Unchanged: break;
                    case EntityState.Deleted:
                        data.Entity.IsDeleted = true;
                        break;
                    default: break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}