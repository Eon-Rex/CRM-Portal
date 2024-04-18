using Microsoft.AspNetCore.Mvc;

namespace SAMCOCRMRELATION.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            Random rand = new Random();
            int number1 = rand.Next(1, 11);
            int number2 = rand.Next(1, 11);

            ViewData["Number1"] = number1;
            ViewData["Number2"] = number2;

            return View();
        }

        [HttpPost]
        public JsonResult Validate(string username,string password) {

            bool isValid = YourLoginValidationLogic(username,  password); 

            if (isValid)
            {
                return Json(new { success = true, message = "Login successful" });
            }
            else
            {
                return Json(new { success = false, message = "Invalid username or password" });
            }
        }

        private bool YourLoginValidationLogic(string username, string password)
        {
            return true;
        }
    }
}
