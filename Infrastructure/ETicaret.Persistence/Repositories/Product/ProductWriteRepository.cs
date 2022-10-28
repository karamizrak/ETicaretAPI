using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Repositories.Product;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Product
{
    internal class ProductWriteRepository : WriteRepository<Domain.Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretApiDbContext context) : base(context)
        {
        }
    }
}
