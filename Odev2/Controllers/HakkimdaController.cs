using Microsoft.AspNetCore.Mvc;

namespace Odev2.Controllers
{
    public class HakkimdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
