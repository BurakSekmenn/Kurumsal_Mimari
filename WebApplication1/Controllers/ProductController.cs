using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var model = new ProdcutListViewModel
            {
                Product = _productService.GetAll()
            };
            return View(model);
        }
    }

}
