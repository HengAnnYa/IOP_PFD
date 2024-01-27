using Microsoft.AspNetCore.Mvc;

namespace InsightOpticPro_PFD_Final.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
