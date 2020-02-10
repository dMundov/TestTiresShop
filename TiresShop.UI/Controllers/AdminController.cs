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
       
        [HttpPost("createProduct")]
        public async Task<IActionResult> CreateProduct([FromBody]CreateProduct.Request request) => Ok(await new CreateProduct(_context).Create(request));
        
        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id) => Ok((await new DeleteProduct(_context).Delete(id)));
        
        [HttpPut("updateProduct")]
        public async Task<IActionResult> UpdateProduct(UpdateProduct.Request request ) => Ok(await new UpdateProduct(_context).Update(request));

        

    }
}
