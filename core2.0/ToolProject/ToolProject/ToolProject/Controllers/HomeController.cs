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
        const string message = "Indent Json Object Here";
        const string xmlMessage = "Indent xml Here";
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
            ViewData["Message"] = message;

            return View();
        }

        [HttpPost]
        public IActionResult IndentJson(JsonBody json)
        {
            ViewData["Message"] = message;

            json.Output = JsonHelper.formatJson(json.Description);

            if(!string.IsNullOrEmpty(json.Description) && string.IsNullOrEmpty(json.Output))
            {
                json.Output = "Invalid Json Input";
            }

            return View(json);
        }


        public IActionResult IndentXML()
        {
            ViewData["Message"] = xmlMessage;

            return View();
        }

        [HttpPost]
        public IActionResult IndentXML(XMLBody xml)
        {
            ViewData["Message"] = xmlMessage;

            xml.Output = XMLHelper.formatXML(xml.Description);

            if (!string.IsNullOrEmpty(xml.Description) && string.IsNullOrEmpty(xml.Output))
            {
                xml.Output = "Invalid Json Input";
            }

            return View(xml);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
