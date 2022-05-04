using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            //string html = "<form method='post' action='/helloworld/'>" +
            //    "<input type='text' name='name' />" +
            //    "<input type='select' name='language'/>" +
            //    "<input type='submit' value='Greet Me!' />" +
            //    "</form>";

            string html = "<form method='post' action='/helloworld/'>" +
                          "<input type='text' name='name'/>" +
                          "<select name='language'>" +
                                    "<option value = 'french' selected> French </option>" +
                                    "<option value = 'english' selected> English </option>" +
                                    "<option value = 'hindi' selected> Hindi </option>" +
                                    "<option value = 'mandrin' selected> Mandrin </option>" +
                                    "<option value = 'spanish' selected> Spanish </option>" +
                          "</select>" +
                          "<input type='submit' value='Greet Me' />" +
                          "</form>";

            return Content(html, "text/html");
        }

        //Post /helloworld
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string language, string name = "World")
        { 
            return Content("<h1 style='color : green'>" + CreateMessage(name, language) + "!</h1>", "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string greeting = "";
            if (language == "english")
            {
                greeting = "Hello";
            }
            if (language == "spanish")
            {
                greeting = "Hola";
            }
            if (language == "french")
            {
                greeting = "Bonjour";
            }
            if (language == "hindi")
            {
                greeting = "Namaste";
            }
            if (language == "mandrin")
            {
                greeting = "Ni hao";
            }

            greeting += ' ' + "<span style='color: blue'>" + name + "</span>";
            return greeting;
        }
    }
}
