using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext DbContext;
        public EFProductRepository(ApplicationDbContext context)
        {
            DbContext = context;
        }
        public IQueryable<Product> Products => DbContext.Products;
    }
}
