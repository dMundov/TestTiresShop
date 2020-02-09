using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shop.Application.Products;
using Shop.Application.ViewModels;
using Shop.Database;
using Shop.Domain.Models;

namespace TiresShop.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ShopDbContext _dbContext;

        public IndexModel(ILogger<IndexModel> logger, ShopDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }


        [BindProperty]
        public ProductViewModel Product { get; set; }

        public IEnumerable<ProductViewModel> AllProducts { get; set; }


        public void OnGet()
        {
            AllProducts = new GetProducts(_dbContext).GetAllProducts();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_dbContext).Do(Product);
            return RedirectToPage("Index");
        }
    }
}
