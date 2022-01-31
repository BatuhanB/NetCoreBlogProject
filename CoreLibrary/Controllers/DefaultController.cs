using Microsoft.AspNetCore.Mvc;

namespace CoreLibrary.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Partial1()
        {
            return PartialView();
        }
    }
}
