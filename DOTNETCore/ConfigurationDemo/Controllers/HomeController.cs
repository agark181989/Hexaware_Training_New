using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfigurationDemo.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ConfigurationDemo.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration configuration;
        private AppConfiguration appConfig;
        private ProjectDetails projConfig;
        public HomeController(IConfiguration config, IOptions<AppConfiguration> options, IOptions<ProjectDetails> projectOption)
        {
            configuration = config;
            appConfig = options.Value;
            projConfig = projectOption.Value;
        }
        public IActionResult Index()
        {
            // ViewBag.company = configuration.GetValue<string>("CompanyName");
            // ViewBag.location = configuration.GetValue<string>("Location");
            // ViewBag.count = configuration.GetValue<int>("ParticipantCount");
            // ViewBag.arch = configuration.GetValue<string>("PROCESSOR_ARCHITECTURE");
            // ViewBag.noOfProcessor = configuration.GetValue<int>("NUMBER_OF_PROCESSORS");
            // ViewBag.title = configuration.GetValue<string>("ProjectDetails:Title");
            // ViewBag.duration = configuration.GetValue<string>("ProjectDetails:Duration");
            // ViewBag.status = configuration.GetValue<string>("ProjectDetails:Status");
            // var project = configuration.GetSection("ProjectDetails");
            // ViewBag.t = project["Title"];
            // ViewBag.d = project["Duration"];
            // ViewBag.s = project["Status"];

            ViewBag.company = appConfig.CompanyName;
            ViewBag.location = appConfig.Location;
            ViewBag.count = appConfig.ParticipantCount;
            ViewBag.arch = appConfig.PROCESSOR_ARCHITECTURE;
            ViewBag.noOfProcessor = appConfig.NUMBER_OF_PROCESSORS;
            ViewBag.title = appConfig.ProjectDetails.Title;
            ViewBag.duration = appConfig.ProjectDetails.Duration;
            ViewBag.status = appConfig.ProjectDetails.Status;

            ViewBag.t = projConfig.Title;
            ViewBag.d = projConfig.Duration;
            ViewBag.s = projConfig.Status;

            
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
