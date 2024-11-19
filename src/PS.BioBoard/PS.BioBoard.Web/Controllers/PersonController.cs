using Microsoft.AspNetCore.Mvc;

namespace PS.BioBoard.Web.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
