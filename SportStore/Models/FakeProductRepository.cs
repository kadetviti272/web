using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class FakeProductRepository : IProductRepository
    {

        public IQueryable<Product> Products => new List<Product>
        {
            new Product{Name = "Footboll", Price = 25},
            new Product{Name = "Serf Board", Price = 225},
            new Product{Name = "Tenis", Price = 5},
        }.AsQueryable<Product>();
    }
}
