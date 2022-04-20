using ISpanSTA.Models;
using ISpanSTA.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISpanSTA.Controllers
{
    public class QuestionBankController : Controller
    {
        private readonly IspanStudentSystemContext _context;

        public QuestionBankController(IspanStudentSystemContext context)
        {
            _context = context;
        }
        // GET: QuestionBankController
        public IActionResult Index()
        {
            var data = from s in _context.TSujects
                         join c in _context.TCategories on s.FCategoryId equals c.FCategoryId
                         join co in _context.TClassCourseFullInfos on s.FCourseId equals co.FCourseId
                         join t in _context.TTypes on s.FTypeId equals t.FTypeId
                         select new CExamViewModel { FSujectId = s.FSujectId, FCourseId = s.FCourseId, FCategoryId = s.FCategoryId, FTypeId = s.FTypeId,
                             FQuestion = s.FQuestion, FCourseName = co.FCourse, FCategoryName = c.FName, FTypeName = t.FType };

            List<CExamViewModel> list = new List<CExamViewModel>();
            foreach (var t in data)                
                list.Add(t);
            return View(list);
        }

        // GET: QuestionBankController/Details/5
        public ActionResult Details(int? id)
        {
            //if (id != null)
            //{
            //    TSuject sj = _context.TSujects.FirstOrDefault(sj => sj.FSujectId == (int)id);
            //    if (sj != null)
            //    {
            //        return View(new CExamViewModel() { subject = sj });
            //    }
            //}
            //return RedirectToAction("Index");


            if (id != null)
            {
                var data = (from s in _context.TSujects
                           join c in _context.TCategories on s.FCategoryId equals c.FCategoryId
                           join co in _context.TClassCourseFullInfos on s.FCourseId equals co.FCourseId
                           join t in _context.TTypes on s.FTypeId equals t.FTypeId
                           where s.FSujectId == (int)id
                           select new CExamViewModel
                           {
                               FSujectId = s.FSujectId,
                               FCourseId = s.FCourseId,
                               FCategoryId = s.FCategoryId,
                               FTypeId = s.FTypeId,
                               FQuestion = s.FQuestion,
                               FCourseName = co.FCourse,
                               FCategoryName = c.FName,
                               FTypeName = t.FType,
                               FOption1 = s.FOption1,
                               FOption2 = s.FOption2,
                               FOption3 = s.FOption3,
                               FOption4 = s.FOption4,
                               FAns = s.FAns,
                               FAnsAnalyze = s.FAnsAnalyze
                           }).FirstOrDefault();

                //return View(data);
                //return View(data.ToList());
                //return View(data.ToList()[0]);
                return View(data);

            }
            return RedirectToAction("Index");

        }

        // GET: QuestionBankController/Create
        public IActionResult Create()
        {
            ViewData["FCourseName"] = new SelectList(_context.TClassCourseFullInfos, "FCourseId", "FCourse");
            ViewData["FCategoryName"] = new SelectList(_context.TCategories, "FCategoryId", "FName");
            ViewData["FTypeName"] = new SelectList(_context.TTypes, "FTypeId", "FType");
            return View();
        }

        // POST: QuestionBankController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CExamViewModel sj)
        {
            try
            {
                _context.TSujects.Add(sj.subject);
                _context.SaveChanges();                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["FCourseName"] = new SelectList(_context.TCategories, "FCourseId", "FCourse", sj.FCourseId);
                ViewData["FCategoryName"] = new SelectList(_context.TCategories, "FCategoryId", "FName", sj.FCategoryId);
                ViewData["FTypeName"] = new SelectList(_context.TTypes, "FTypeId", "FType", sj.FTypeId);
                return View(sj);
            }
        }

        // GET: QuestionBankController/Edit/5
        public IActionResult Edit(int? id)
        {
            ViewData["FCourseName"] = new SelectList(_context.TClassCourseFullInfos, "FCourseId", "FCourse");
            ViewData["FCategoryName"] = new SelectList(_context.TCategories, "FCategoryId", "FName");
            ViewData["FTypeName"] = new SelectList(_context.TTypes, "FTypeId", "FType");
            if (id != null)
            {
                TSuject sj = _context.TSujects.FirstOrDefault(sj => sj.FSujectId == (int)id);
                if (sj != null)
                {
                    return View(new CExamViewModel() { subject = sj });
                }
            }
            return RedirectToAction("Index");           
        }

        // POST: QuestionBankController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CExamViewModel sj)
        {
            //try
            //{
                TSuject s = _context.TSujects.FirstOrDefault(s => s.FSujectId == sj.FSujectId);
                if (s != null)
                {
                    s.FCourseId = sj.FCourseId;
                    s.FCategoryId = sj.FCategoryId;
                    s.FTypeId = sj.FTypeId;
                    s.FQuestion = sj.FQuestion;
                    s.FOption1 = sj.FOption1;
                    s.FOption2 = sj.FOption2;
                    s.FOption3 = sj.FOption3;
                    s.FOption4 = sj.FOption4;
                    s.FAns = sj.FAns;
                    s.FAnsAnalyze = sj.FAnsAnalyze;

                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    //ViewData["FCourseName"] = new SelectList(_context.TCategories, "FCourseId", "FCourse", sj.FCourseId);
            //    //ViewData["FCategoryName"] = new SelectList(_context.TCategories, "FCategoryId", "FName", sj.FCategoryId);
            //    //ViewData["FTypeName"] = new SelectList(_context.TTypes, "FTypeId", "FType", sj.FTypeId);
            //    return RedirectToAction("Index");
            //}
        }

        // GET: QuestionBankController/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {               
                TSuject sj = _context.TSujects.FirstOrDefault(sj => sj.FSujectId == (int)id);
                if (sj != null)
                {
                    _context.TSujects.Remove(sj);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");            
        }

        //// POST: QuestionBankController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        ////讀出不重複的課程名稱
        public IActionResult courseFilter()
        {
            var courses = _context.TClassCourseFullInfos.Select(co => new
            {
                co.FCourse,
                co.FCourseId
            }).Distinct().OrderBy(co => co.FCourseId);

            return Json(courses);

        }

        ////根據課程名稱讀出對應類別
        public IActionResult categoryFilter(int courseId)
        {
            var categorys = _context.TCategories.
                            Where(ca=>ca.FCourseId == courseId).Select(ca => new
                            {                                
                                ca.FName
                            }).Distinct();
            return Json(categorys);
        //
    }
}
}
