using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webappwithsqldb.Models;
using Webappwithsqldb.Services;

namespace Webappwithsqldb.Pages
{
    public class IndexModel : PageModel
    {
        //public List<Product>? Products;
        //public void OnGet()
        //{
        //    ProductService productService = new ProductService();
        //    Products = productService.GetProducts();

        //}

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products;
        public void OnGet()
        {
            Products = _productService.GetProducts();

        }
    }
}