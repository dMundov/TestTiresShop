using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shop.Application.ViewModels;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.Products
{
    public class UpdateProduct
    {
        private readonly ShopDbContext _context;

        public UpdateProduct(ShopDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel productViewModel)
        {

            await _context.SaveChangesAsync();
        }


    }
}
