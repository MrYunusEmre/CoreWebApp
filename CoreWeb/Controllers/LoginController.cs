using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
