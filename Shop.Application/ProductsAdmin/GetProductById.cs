using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Application.ViewModels;
using Shop.Database;

namespace Shop.Application.ProductsAdmin
{
    public class GetProductById
    {
        private readonly ShopDbContext _context;

        public GetProductById(ShopDbContext context)
        {
            _context = context;
        }


        public ProductViewModel ProductById(int id)
        {
            ProductViewModel productById = _context
                .Products
                .Where(x => x.Id == id)
                .Select(x => new ProductViewModel
                {
                    Id=x.Id,
                    Name = x.Name,
                    Desctiption = x.Desctiption,
                    Value = x.Value

                })
                .FirstOrDefault();
            
            return productById;
        }
    }
}
