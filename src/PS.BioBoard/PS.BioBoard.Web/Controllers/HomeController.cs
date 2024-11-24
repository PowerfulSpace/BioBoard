using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PS.BioBoard.Application.Services.Persons;
using PS.BioBoard.Domain.Entities;
using PS.BioBoard.Web.Models;
using System.Diagnostics;

namespace PS.BioBoard.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonService _personService;

        public HomeController(ILogger<HomeController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public IActionResult Index()
        {
            var persons = _personService.GetAllAsync().GetAwaiter().GetResult();
            return View(persons.First());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
