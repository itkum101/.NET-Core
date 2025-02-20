
using Microsoft.AspNetCore.Mvc;
using Task_12___Model_Validation.Models;
namespace Task_12___Model_Validation.Controllers
{


    public class UserController : Controller
    {
        public IActionResult Register()
        {
            Console.WriteLine("Displaying Register form");
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Model validation failed.");
                return View(model);
            }
            Console.WriteLine("Model validation succeeded.");
            TempData["SuccessMessage"] = "Registration successful!";
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View("Success");
        }
    }

}
