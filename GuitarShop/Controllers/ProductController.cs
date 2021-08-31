using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GuitarShop.Models;

namespace GuitarShop.Controllers
{
    public class ProductController : Controller
    {
        //this controller returns detail page about a certain product based on id.
        public IActionResult Detail(string id)
        {
            Product product = DB.GetProduct(id);
            return View(product);
        }
        //this method returns the list page for all products.
        public IActionResult List()
        {
            List<Product> products = DB.GetProducts();
            return View(products);
        }
    }
}