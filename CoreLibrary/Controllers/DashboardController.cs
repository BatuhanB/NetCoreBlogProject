using Microsoft.AspNetCore.Mvc;

namespace CoreLibrary.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
