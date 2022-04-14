using Microsoft.AspNetCore.Mvc;
using WebProject.Data.Interfaces;
using WebProject.ViewModels;

namespace WebProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductsCategory _allCategory;

        public ProductsController(IAllProducts iAllProducts,IProductsCategory iProductCat)
        {
            _allProducts = iAllProducts;
            _allCategory = iProductCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с техникой";
            ProductsListViewModel obj = new ProductsListViewModel();
            obj.getAllProducts = _allProducts.Products;
            obj.currCategory = "Техники";
            return View(obj);
        }
    }
}
