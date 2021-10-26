using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET helloworld
        public IActionResult Index()
        {
            return View();
        }

        //GET helloworld/welcome
        public IActionResult Welcome(string nome, int ID = 2)
        {
            ViewData["Message"] = "hello " + nome;
            ViewData["NumTimes"] = ID;
            return View();
        }
    }
}
