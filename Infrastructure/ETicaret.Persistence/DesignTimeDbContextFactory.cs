using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ETicaret.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretApiDbContext>
    {
        //Command line ef migration için bu sınıf gerekli
        public ETicaretApiDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ETicaretApiDbContext> dbContextoptionsBuilder = new();
            dbContextoptionsBuilder.UseNpgsql(
                Configuration.ConnectionString);
            return new(dbContextoptionsBuilder.Options);
        }
    }
}