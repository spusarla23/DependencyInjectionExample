using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Services;


namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {

       private readonly CitiesService _citiesService;
        public HomeController()
        {
            _citiesService = new CitiesService();
        }

        [Route("/")]
        public IActionResult Index()
        {
              List<string> cities =  _citiesService.GetCities().ToList();
            //  return View(cities);
           // citiesService = null;
          return View(cities);
        }
    }
}
