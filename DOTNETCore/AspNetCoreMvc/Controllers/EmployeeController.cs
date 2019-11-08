using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using AspNetCoreMvc.Services;

namespace AspNetCoreMvc.Controllers
{
    [Route("employee")]
    public class EmployeeController : Controller
    {
        DataService ds;
        public EmployeeController(DataService ds)
        {
            this.ds = ds;
        }

        [HttpGet("list", Name="EmpList")]
        public IActionResult Index()
        {
            ViewBag.DIDATA = ds.Message;
            string message = "Hello I am your session data";
            var data = Encoding.UTF8.GetBytes(message);
            HttpContext.Session.Set("message", data);
            return View();
        }

        public IActionResult Details()
        {            
            ViewBag.Message = HttpContext.Session.GetString("message");
            return View();
        }

        [HttpGet("mypage")]
        public IActionResult MyPage()
        {
            TempData["SomeInfo"]="Here is my tempdata value";
            return RedirectToAction("MyPage2");
        }
        
        [HttpGet("mypage2")]
        public IActionResult MyPage2()
        {
            return View();
        }
    }
}
