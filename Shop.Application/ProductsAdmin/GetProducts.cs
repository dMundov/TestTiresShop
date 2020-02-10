﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Application.ViewModels;
using Shop.Database;

namespace Shop.Application.ProductsAdmin
{
    public class GetProducts
    {
        private readonly ShopDbContext _context;

        public GetProducts(ShopDbContext context)
        {
            _context = context;
        }


        public IEnumerable<ProductViewModel> GetAllProducts()
        {

            return  _context.Products
                .Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Desctiption = x.Desctiption,
                    Value = x.Value
                })
                .ToList();

            
        }
    }
}
