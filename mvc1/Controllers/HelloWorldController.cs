using Microsoft.AspNetCore.Mvc;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs= new List<DogViewModel>();
        public IActionResult Index()
        {
            //DogViewModel doggo = new DogViewModel() { Name="Sif", Age=2};
            return View(dogs);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //  return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
        public string Hello()
        {
            return "Who is there?";
        }
    }
}
