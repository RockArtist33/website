using Microsoft.AspNetCore.Mvc;

namespace OccupationalSpecialism_Pet_Care_Platform.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
