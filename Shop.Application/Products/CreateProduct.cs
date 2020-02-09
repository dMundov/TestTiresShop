using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shop.Application.ViewModels;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.Products
{
    public class CreateProduct
    {
        private readonly ShopDbContext _context;

        public CreateProduct(ShopDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel productViewModel)
        {
            _context.Products.Add(new Product
            {
                Name = productViewModel.Name,
                Desctiption = productViewModel.Desctiption,
                Value = productViewModel.Value
            });

           await _context.SaveChangesAsync();
        }
    }
}
