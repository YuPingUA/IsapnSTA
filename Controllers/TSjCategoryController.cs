using ISpanSTA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISpanSTA.Controllers
{
    public class TSjCategoryController : Controller
    {
        private readonly IspanStudentSystemContext _context;

        public TSjCategoryController(IspanStudentSystemContext context)
        {
            _context = context;
        }
        // GET: TSjCategoryController
        public ActionResult Index()/* int? courseId*/
        {
            var data = from c in _context.TCategories
                       //where c.FCourseId == (int)courseId
                       select c;
            List<TCategory> list = new List<TCategory>();
            foreach (var t in data)
                list.Add(t);
            return View(list);
        }

        // GET: TSjCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TSjCategoryController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TSjCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
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

        // GET: TSjCategoryController/Edit/5
        public IActionResult AddOrEdit(int? id=0)
        {
            if(id==0)
            return View(new TCategory());
            else
            {
                var TCategory = _context.TCategories.Find(id);
                if(TCategory == null)
                {
                    return NotFound();
                }
                return View(TCategory);
            }
        }

        // POST: TSjCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int? id, TCategory c)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.TCategories.Add(c);
                    _context.SaveChanges();
                }
                else
                {
                    try
                    {
                        _context.TCategories.Update(c);
                        _context.SaveChanges();
                        //return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return NotFound();
                        //return View();
                    }
                }
                return Json(new {isValid=true, html = Helper.RenderRazorViewToString(this, "Index", _context.TCategories.ToList()) });
            }

            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", c) });

        }

        // GET: TSjCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TSjCategoryController/Delete/5
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
