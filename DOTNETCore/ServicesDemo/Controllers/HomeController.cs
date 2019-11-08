using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesDemo.Models;
using ServicesDemo.Services;
using Microsoft.Extensions.Configuration;

namespace ServicesDemo.Controllers
{
    public class HomeController : Controller
    {
        private IDataManager dm;
        //private IConfiguration configruation;
        public HomeController(IDataManager dataManger/*,IConfiguration config*/)
        {
            this.dm=dataManger;
            //this.configruation=config;
        }

        // public HomeController(NoSqlDataManager dataManger)
        // {
        //     this.dm= dataManger;
        // }

        public IActionResult Index([FromServices]IConfiguration configruation)
        {
            ViewBag.Message = dm.GetData();
            ViewBag.Username = configruation.GetValue<string>("UserDetails:Name");
            ViewBag.Age = configruation.GetValue<int>("UserDetails:Age");
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
