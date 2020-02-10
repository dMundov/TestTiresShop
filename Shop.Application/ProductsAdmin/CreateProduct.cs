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

        public async Task<Response> Create(Request request)
        {
            Product product = new Product
            {
                Name = request.Name,
                Desctiption = request.Description,
                Value = request.Value
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            
            return new Response
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Desctiption,
                Value = product.Value
            };
        }
        
        public class Request
        {

            public string Name { get; set; }

            public string Description { get; set; }

            public decimal Value { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public decimal Value { get; set; }
        }
    }
}
