using Microsoft.AspNetCore.Mvc;

namespace SalonCatalog.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}