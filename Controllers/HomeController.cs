using System.Diagnostics;
using CRUD_DOTNET6.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEPersonRepository _ePersonRepository;

        public HomeController(IEPersonRepository ePersonRepository)
        {
            _ePersonRepository = ePersonRepository;

        }
        public ViewResult Index()
        {
            var model = _ePersonRepository.GetAllExaminePeople();
            return View(model);
        }

  

        public IActionResult About()
        {
            ViewData["Message"] = "Application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Pragyanshu Aryan";

            return View();
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
