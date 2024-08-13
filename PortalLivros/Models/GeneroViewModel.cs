using Microsoft.AspNetCore.Mvc;

namespace PortalLivros.Models
{
    public class GeneroViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
