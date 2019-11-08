using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvc.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using AspNetCoreMvc.Services;


namespace AspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        IMemoryCache cache;
        IDistributedCache dCache;
        DataService ds;
        public HomeController(IMemoryCache cache, IDistributedCache distCache, DataService ds){
            this.cache = cache;
            this.dCache = distCache;
            this.ds = ds;
        }
        public IActionResult Index()
        {
            ds.Message = "This is DI Demo";
            var data = cache.Get<DateTime?>("now");
            if(data == null)
            {
                data = DateTime.Now;
                cache.Set<DateTime?>("now", data, DateTimeOffset.Now.AddMinutes(3));
            }
            ViewBag.LodingTime = data;

            //Distributed cache test            
            var cacheData= dCache.GetString("users");
            if(string.IsNullOrEmpty(cacheData))
            {
                Dictionary<int, string> myData = new Dictionary<int, string>(){
                    {101, "Roht"},
                    {102, "Ashish"},
                    {103, "Gaurav"}                
                };
                dCache.SetString("users", JsonConvert.SerializeObject(myData));
                // , new DistributedCacheEntryOptions{
                //     AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(1);
                // });
                //cacheData = JsonConvert.SerializeObject(myData);
                ViewBag.Users = myData;
                ViewBag.Source = "Loaded Initially";
            }else{
                //cacheData = JsonConvert.DeserializeObject(myData);
                ViewBag.Users = JsonConvert.DeserializeObject<Dictionary<int, string>>(cacheData);
                ViewBag.Source = "Loaded from cache";
            }

            return View();
        }

        public IActionResult Privacy()
        {
            if(((bool)HttpContext.Items["IsVerified"]))
            {
                ViewBag.Message = "Request data is valid";
            }
            else{
                ViewBag.Message = "Request data is invalid";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
