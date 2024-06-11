using Microsoft.AspNetCore.Mvc;

namespace CuaHangCaPhe.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
