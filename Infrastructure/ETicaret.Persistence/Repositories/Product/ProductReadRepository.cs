using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Repositories;
using ETicaret.Application.Repositories.Product;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Product
{
    internal class ProductReadRepository : ReadRepository<Domain.Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretApiDbContext context) : base(context)
        {
        }
    }
}
