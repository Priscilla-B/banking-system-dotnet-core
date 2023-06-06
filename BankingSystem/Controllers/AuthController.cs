using Microsoft.AspNetCore.Mvc;
using BankingSystem.ViewModels.Auth;

namespace BankingSystem.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel obj)
        {
            return View();
        }
    }
}
