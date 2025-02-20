using Microsoft.AspNetCore.Mvc;
using Task___11__Views_to_Controller_.Models;

namespace Task___11__Views_to_Controller_.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Product>
            {
                new Product(), new Product(), new Product(), new Product(), new Product()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Submit(List<Product> products)
        {
            if (ModelState.IsValid)
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Unit: {product.Unit}, Quantity: {product.Quantity}, Description: {product.Description}");
                }
                ViewBag.Message = "Products submitted successfully!";
            }
            return View("Index", products);
        }
    }
}
