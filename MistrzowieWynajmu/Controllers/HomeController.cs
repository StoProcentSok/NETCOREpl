using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MistrzowieWynajmu.Controllers
{
    public class HomeController : Controller
    {
        //[Route("Home/Metoda")]
        public IActionResult Index(string name)
        {
            string html = "<form method = 'post' action = 'home/goodbye?name=ziomek'>" +
                "<input type = \"text\" name = \"name\" />" +
                "<input type = 'submit' value = 'Greet me mate!' />" +
                "</form>";

            
            return Content(html, "text/html");
            //return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }

        public IActionResult Goodbye()
        {
            return Content("<h1>Goodbye!<h1>", "text/html");
        }
    }
}
