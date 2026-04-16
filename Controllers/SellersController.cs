using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc12.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
