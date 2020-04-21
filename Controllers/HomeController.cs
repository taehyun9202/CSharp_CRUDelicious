using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context {get;set;}
        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Menu> Item = _context.Items.ToList();
            return View(Item);
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost("create")]
        public IActionResult Create(Menu newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Items.Add(newDish);
                _context.SaveChanges();
                return Redirect("/");
            }
            else
            {
                return View();
            }
        }
        [HttpGet("{Id}")]
        public IActionResult Show(int Id)
        {
            Menu show = _context.Items.FirstOrDefault (i =>i.FoodId == Id);
            return View(show);
        }

        [HttpGet("edit/{Id}")]
        public IActionResult Edit(int Id)
        {
            Menu edit = _context.Items.FirstOrDefault (i =>i.FoodId == Id);
            return View(edit);
        }

        [HttpPost("update/{Id}")]
        public IActionResult Update(int Id, Menu update)
        {
            Menu get = _context.Items.FirstOrDefault (i =>i.FoodId == Id);
            if (ModelState.IsValid)
            {
                get.ChefName = update.ChefName;
                get.ItemName = update.ItemName;
                get.Calories = update.Calories;
                get.Tastiness = update.Tastiness;
                get.Description = update.Description;
                get.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return Redirect($"/{Id}");
            }
            else
            {   
                return Redirect("/edit/{Id}");
            }

        }
        [HttpGet("delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            Menu get = _context.Items.FirstOrDefault (i =>i.FoodId == Id);
            _context.Items.Remove(get);
            _context.SaveChanges();
            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
