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

        public async Task<Response> Update(Request request)
        {

            await _context.SaveChangesAsync();
            return new Response();
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
