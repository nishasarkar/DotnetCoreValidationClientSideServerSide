using Lab_FormValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_FormValidation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserViewModel model)
        {
            if (ModelState.IsValid)
            {                              
                return RedirectToAction("Index", "Home");          
            }      
            return View();  
        } 
            }
}
