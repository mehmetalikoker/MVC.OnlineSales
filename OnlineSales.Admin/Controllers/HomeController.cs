using OnlineSales.Admin.ViewModel;
using OnlineSales.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineSales.Admin.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IProductImageRepository _productImageRepository;
        private IProductFeatureRepository _productFeatureRepository;

        public HomeController(ICategoryRepository categoryRepository, IProductRepository productRepository, IProductImageRepository productImageRepository, IProductFeatureRepository productFeatureRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _productImageRepository = productImageRepository;
            _productFeatureRepository = productFeatureRepository;
        }

        public ActionResult Index()
        {
            var pagelModel = new HomePageModel
            {
                CategoryCount = _categoryRepository.Count(),
                ProductCount = _productRepository.Count(),
                ProductImageCount = _productImageRepository.Count(),
                ProductFeatureCount = _productFeatureRepository.Count()
            };

            return View(pagelModel);
        }

    }
}