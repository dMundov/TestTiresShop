using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Products;
using Shop.Database;
using GetProducts = Shop.Application.ProductsAdmin.GetProducts;

namespace TiresShop.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly ShopDbContext _context;

        public AdminController(ShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts() => Ok(new GetProducts(_context).GetAllProducts());
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id) => Ok(new DeleteProduct(_context).Delete(id));
        [HttpPost("{id}")]
        public IActionResult UpdateProduct(int Id ) => Ok(new GetProducts(_context).GetAllProducts());
        [HttpGet]
        public IActionResult DeleteProduct() => Ok(new GetProducts(_context).GetAllProducts());
        [HttpGet]
        public IActionResult CreateProduct() => Ok(new GetProducts(_context).GetAllProducts());

    }
}
