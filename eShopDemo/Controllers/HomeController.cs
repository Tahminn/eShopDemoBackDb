using eShopDemo.Data;
using eShopDemo.Models;
using eShopDemo.Services;
using eShopDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eShopDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, ProductService productService, CategoryService categoryService)
        {
            _context = context;
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<ActionResult> Index()
        {
            List<Product> products = await _productService.GetProductsWithImages(10);
            List<Category> categories = await _categoryService.GetCategories();

            HomeVM homeVM = new HomeVM
            {
                Products = products,
                Categories = categories
            };

            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
