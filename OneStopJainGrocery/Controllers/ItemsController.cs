using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneStopJainGrocery.Models;
using OneStopJainGrocery.Models_Combined;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopJainGrocery.Controllers
{
    public class ItemsController : Controller
    {

        private bhavya26_jaingroceryContext _context;

        public ItemsController(bhavya26_jaingroceryContext context)
        {
            _context = context;
        }

        [HttpGet]
        // GET: ItemsController
        public List<grocery_main> Index()
        {

            var query = (from grocery in _context.GroceryItems
                         join categories in _context.Categories
                         on grocery.Categories equals categories.Id
                         join country in _context.Countries
                         on grocery.Country equals country.Id
                         join diet in _context.Diets
                         on grocery.DietType equals diet.Id
                         select new grocery_main()
                         {
                            Id= grocery.Id,
                            Country= country.Countryname,
                            DietType= diet.DietType,
                            Productimage = grocery.Productimage,
                            Productname= grocery.Productname,
                            Producturl= grocery.Producturl,
                            Categories= categories.Categories
                         }).ToList();

            return query;
        }

        // GET: ItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
