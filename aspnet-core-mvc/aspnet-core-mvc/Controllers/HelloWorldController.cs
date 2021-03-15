using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace aspnet_core_mvc.Controllers
{
    public class HelloWorldController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }

        public IActionResult Wellcome(string name, int numTimes = 1)
        {
            //Usa HtmlEncoder.Default.Encode o para proteger o aplicativo contra entradas mal-intencionadas,
            // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is:{numTimes}");

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
