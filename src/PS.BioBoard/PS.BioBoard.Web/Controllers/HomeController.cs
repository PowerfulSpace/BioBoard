using Microsoft.AspNetCore.Mvc;
using PS.BioBoard.Domain.Entities;
using PS.BioBoard.Web.Models;
using System.Diagnostics;

namespace PS.BioBoard.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Пример объекта Person
            var person = new Person
            {
                Id = Guid.NewGuid(),
                Name = "Иван Иванов",
                Bio = "Программист с 10-летним стажем. Люблю писать код, путешествовать и пробовать новые технологии.",
                Email = "ivanov@example.com",
                PhoneNumber = "+7 (999) 123-45-67",
                ImageUrl = "/images/person.jpg" // Путь к изображению
            };

            return View(person);
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
