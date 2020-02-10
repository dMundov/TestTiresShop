using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Products;
using Shop.Application.ProductsAdmin;
using Shop.Application.ViewModels;
using Shop.Database;
using GetProducts = Shop.Application.ProductsAdmin.GetProducts;

namespace TiresShop.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly ShopDbContext _context;

        public AdminController(ShopDbContext context)
        {
            _context = context;
        }

        [HttpGet("allProducts")]
        public IActionResult GetProducts() => Ok(new GetProducts(_context).GetAllProducts());
        
        [HttpGet("products/{id}")]
        public IActionResult GetProductById(int id) => Ok(new GetProductById(_context).ProductById(id));
       
        [HttpGet("createProduct")]
        public IActionResult CreateProduct(ProductViewModel productModel) => Ok(new CreateProduct(_context).Create(productModel));
        
        [HttpDelete("products/{id}")]
        public IActionResult DeleteProduct(int id) => Ok(new DeleteProduct(_context).Delete(id));
        
        [HttpPut("updateProduct")]
        public IActionResult UpdateProduct(ProductViewModel productModel ) => Ok(new UpdateProduct(_context).Update(productModel));

        

    }
}
