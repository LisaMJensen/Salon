using Microsoft.AspNetCore.Mvc;

namespace StylistCatalog.Controllers
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