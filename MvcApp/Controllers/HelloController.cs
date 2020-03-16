using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HelloController : Controller
    {
  
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["message"] = "※テーブルの表示";
            ViewData["header"] = new string[] { "id","name","mail"};
            ViewData["data"] = new string[][]
            {
                new string[]{"1","Taro","taro@yamada"},
                new string[]{"2","",""},
                new string[]{"3","",""}
            };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
