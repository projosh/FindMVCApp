using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;


namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() 
            { Name ="Sif" , Age = 2};
            return View(doggo);
        }

        public IActionResult Create()
        {
            return View(); 
        }



        public string Hello()
        {
            return "who's there?";
        }
    }
}
