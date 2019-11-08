using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShopWebMvc.Infrastructure;
using EShopWebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EShopWebMvc.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        private ShopDbContext db;
        private int PageSize = 5;

        public ProductController(ShopDbContext dbContext)
        {
            this.db = dbContext;
        }

        [HttpGet]
        public IActionResult Index(int currentPage = 1)
        {
            ViewBag.PageCount = Convert.ToInt32(Math.Ceiling(db.Products.Count() /(decimal)PageSize));
            ViewBag.CurrentPage = currentPage;
            var products = GetPagedProducts(currentPage);
            return View(products);
        }

        [NonAction]
        private IEnumerable<Product> GetPagedProducts(int pageNo)
        {
            return db.Products
                .Include(p => p.Category)
                .Skip(PageSize * (pageNo - 1))
                .Take(PageSize);
        }

        [HttpGet("add", Name = "AddProduct")]
        public IActionResult AddProdcut()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }

        [HttpPost("add", Name ="AddProduct")]
        public async Task<IActionResult> AddProdcutAsync(Product product)
        {
            if (ModelState.IsValid) {
                await db.Products.AddAsync(product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = db.Categories.ToList();
                return View();

            }
        }

        [HttpGet("edit/id")]
        public IActionResult Edit(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                ViewBag.Categories = db.Categories.ToList();
                return View(product);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> EditAsync(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry<Product>(product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = db.Categories.ToList();
                return View(product);
            }
        }
    }
}