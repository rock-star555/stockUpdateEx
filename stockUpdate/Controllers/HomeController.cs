using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stockUpdate.Models;

using System.Net;
using Newtonsoft.Json;

namespace stockUpdate.Controllers
{
    //comment
    public class HomeController : Controller
    {
        public const string Url = "http://phisix-api3.appspot.com/stocks.json";
        public IActionResult Index()
        {
            try
            {
                var wc = new WebClient();
                var jsonData = wc.DownloadString(Url);
                var Stocks = JsonConvert.DeserializeObject<RootObject>(jsonData);
                return View(Stocks);
            }
            catch
            {
                return View(null);
            }
        }

        public IActionResult GetItems()
        {
            var wc = new WebClient();
            var jsonData = wc.DownloadString(Url);
            var Stocks = JsonConvert.DeserializeObject<RootObject>(jsonData);
            return PartialView(Stocks);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
