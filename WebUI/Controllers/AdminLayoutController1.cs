using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
