using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shop.Application.ViewModels;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.ProductsAdmin
{
    public class CreateProduct
    {
        private readonly ShopDbContext _context;

        public CreateProduct(ShopDbContext context)
        {
            _context = context;
        }

        public async Task Create(ProductCreateModel productViewModel)
        {
            _context.Products.Add(new Product
            {
                Name = productViewModel.Name,
                Desctiption = productViewModel.Description,
                Value = productViewModel.Value
            });

            await _context.SaveChangesAsync();
        }
        
        public class ProductCreateModel
        {

            public string Name { get; set; }

            public string Description { get; set; }

            public decimal Value { get; set; }
        }
    }
}
