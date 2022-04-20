using ISpanSTA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISpanSTA.ViewModel
{
    public class TExamPaperController : Controller
    {
        private readonly IspanStudentSystemContext _context;

        public TExamPaperController(IspanStudentSystemContext context)
        {
            _context = context;
        }

        // GET: CExamPaperController
        public IActionResult Index()
        {
            var data = from ep in _context.TExaminationPapers
                       join cl in _context.TClassFullInfos on ep.FClassPeriod equals cl.FClassPeriod
                       join co in _context.TClassCourseFullInfos on ep.FCourseId equals co.FCourseId
                       select new CExamPaperViewModel
                       {
                           FExamPaperId = ep.FExamPaperId,
                           FClassPeriod = ep.FClassPeriod,
                           FCourseId = ep.FCourseId,
                           FCourseName = co.FCourse,
                           FName = ep.FName,
                           FBegin = ep.FBegin,
                           FEnd = ep.FEnd,
                           FTimeLimit = ep.FTimeLimit,
                           FReveal = ep.FReveal
                       };

            List<CExamPaperViewModel> list = new List<CExamPaperViewModel>();
            foreach (var t in data)
                list.Add(t);
            return View(list);
            
        }

        // GET: CExamPaperController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CExamPaperController/Create
        public ActionResult Create()
        {
            //ViewData["FCourseName"] = new SelectList(_context.TClassCourseFullInfos, "FCourseId", "FCourse");
            
            return View();
        }

        // POST: CExamPaperController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CExamPaperViewModel ep)
        {
            try
            {
                _context.TExaminationPapers.Add(ep.examp);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //ViewData["FCourseName"] = new SelectList(_context.TCategories, "FCourseId", "FCourse", sj.FCourseId);
                
                return View(ep);               
            }
        }

        // GET: CExamPaperController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CExamPaperController/Edit/5
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

        // GET: CExamPaperController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CExamPaperController/Delete/5
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
