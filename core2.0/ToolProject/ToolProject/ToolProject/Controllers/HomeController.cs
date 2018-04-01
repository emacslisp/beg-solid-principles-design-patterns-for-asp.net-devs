using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToolProject.Models;
using ToolProject.Utilities;

namespace ToolProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult IndentJson()
        {
            ViewData["Message"] = "Ident Json Object Here";

            return View();
        }

        [HttpPost]
        public IActionResult IndentJson(JsonBody json)
        {
            ViewData["Message"] = "Ident Json Object Here";

            json.Output = JsonHelper.formatJson(json.Description);

            return View(json);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
