using System;
using System.Web.Mvc;
using TechnicalInterview.Exercice3.Models;
using TechnicalInterview.Exercice3.Services;
using TechnicalInterview.Exercice3.ViewModels;

namespace TechnicalInterview.Exercice3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var viewModel = new ProductListViewModel
            {
                Products = _productService.GetAllProducts()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(AddProductViewModel viewModel)
        {
            try
            {
                var productToAdd = new Product
                {
                    Name = viewModel.ProductName,
                    Description = viewModel.ProductDescription
                };

                _productService.AddProduct(productToAdd);

                ViewBag.Message = "Product was correctly added !";
            }
            catch(Exception exception)
            {
                ViewBag.ErrorMessage = exception.Message;
            }

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}