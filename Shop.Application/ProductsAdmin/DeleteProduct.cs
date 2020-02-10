using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Application.ViewModels;
using Shop.Database;

namespace Shop.Application.Products
{
    public class DeleteProduct
    {

        private readonly ShopDbContext _context;

        public DeleteProduct(ShopDbContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var productToRemove = _context.Products
                .FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(productToRemove);
            await _context.SaveChangesAsync();
        }
    }
}
