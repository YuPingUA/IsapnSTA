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
        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                var data = from epd in _context.TExamPaperDetails
                           join ep in _context.TExaminationPapers on epd.FExamPaperId equals ep.FExamPaperId
                           join co in _context.TClassCourseFullInfos on ep.FCourseId equals co.FCourseId
                           where epd.FExamPaperId == (int)id
                           orderby epd.FSujectId ascending //將對應的試卷題目照題目ID由小到大排序
                           select new CExampDetailsViewModel
                           {
                               FExamPaperId = epd.FExamPaperId,
                               FSujectId = epd.FSujectId,
                               FEpDetailId = epd.FEpDetailId,
                               FExamPaperName = ep.FName,

                               FClassPeriod = ep.FClassPeriod,
                               FCourseId = ep.FCourseId,
                               FCourseName = co.FCourse,
                               FDescription = ep.FDescription

                              
                               //epd.FSujectId
                           };

                List<CExampDetailsViewModel> list = new List<CExampDetailsViewModel>();
                foreach (var t in data)
                    list.Add(t);
                return View(list);
            }
            return RedirectToAction("Index");
        }

        // GET: CExamPaperController/Create
        public ActionResult Create()
        {
           // TClassCourseFullInfo courseId = _context.TClassCourseFullInfo.FirstOrDefault(n => n.fName == courseName);
            int CourseId = 1; // courseId.fCourseId;

            var subjects = (from s in _context.TSujects
                              where s.FCourseId == CourseId
                              select s).ToList();
           
            //List<CExamViewModel> EpSjList = new List<CExamViewModel>() ;
            //var data = from s in _context.TSujects
            //           join c in _context.TCategories on s.FCategoryId equals c.FCategoryId
            //           join co in _context.TClassCourseFullInfos on s.FCourseId equals co.FCourseId
            //           join t in _context.TTypes on s.FTypeId equals t.FTypeId
            //           select new CExamViewModel
            //           {
            //               FSujectId = s.FSujectId,
            //               FCourseId = s.FCourseId,
            //               FCategoryId = s.FCategoryId,
            //               FTypeId = s.FTypeId,
            //               FQuestion = s.FQuestion,
            //               FCourseName = co.FCourse,
            //               FCategoryName = c.FName,
            //               FTypeName = t.FType
            //           };
            
            //foreach (var t in data)
            //    EpSjList.Add(t);
            //return View(list);

            return View();
        }

        // POST: CExamPaperController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CExampDetailsViewModel ep)
        {
            try
            {
                var tempEpId = ep.FExamPaperId;
                TExaminationPaper ts = new TExaminationPaper();
                ts.FExamPaperId = ep.FExamPaperId;
                ts.FClassPeriod = ep.FClassPeriod;
                ts.FCourseId = ep.FCourseId;
                ts.FName = ep.FExamPaperName;
                ts.FBegin = ep.FBegin;
                ts.FEnd = ep.FEnd;
                ts.FReveal = ep.FReveal;
                ts.FTimeLimit = ep.FTimeLimit;
                ts.FOrder = ep.FOrder;
                ts.FDescription = ep.FDescription;

                _context.TExaminationPapers.Add(ts);
                _context.SaveChanges();

                tempEpId++;

                List<int> EpSjList = new List<int>();
                TExamPaperDetail EpSjDetail = new TExamPaperDetail();

                foreach (int s in EpSjList)
                {
                    EpSjDetail.FSujectId = s;
                    EpSjDetail.FExamPaperId = tempEpId;
                    _context.TExamPaperDetails.Add(EpSjDetail);
                    _context.SaveChanges();
                }



                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //ViewData["FClassPeriod"] = new SelectList(_context.TClassFullInfos, "FClassPeriod", "FClassPeriod", ep.FClassPeriod);
                //ViewData["FCourseName"] = new SelectList(_context.TClassCourseFullInfos, "FCourseId", "FCourse", ep.FCourseId);
                
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
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                TExaminationPaper ep = _context.TExaminationPapers.FirstOrDefault(ep => ep.FExamPaperId == (int)id);

                var details = from d in _context.TExamPaperDetails
                              where d.FExamPaperId == (int)id
                              select d;

                List<TExamPaperDetail> detailsList = details.ToList();

                foreach (TExamPaperDetail epd in detailsList)
                {
                    _context.TExamPaperDetails.Remove(epd);  //將明細移除
                    _context.SaveChanges();
                }
                _context.TExaminationPapers.Remove(ep);  //將試卷移除
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        // POST: CExamPaperController/Delete/5
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


        ////讀出不重複的班級名稱
        public IActionResult classFilter()
        {
            var classes = _context.TClassFullInfos.Select(cl => new
            {
                cl.FClassPeriod,
                cl.FClass
            });
            /*.Distinct().OrderBy(cl => cl.FClassPeriod);*/

            return Json(classes);

        }

        ////根據班種讀出對應課程
        public IActionResult courseFilter(string classPeriod)
        {
            var classfi = _context.TClassFullInfos.FirstOrDefault(cl => cl.FClassPeriod == classPeriod);
            string classType = classfi.FClass;
            var courses = _context.TClassCourseFullInfos.
                            Where(co => co.FClass == classType).Select(co => new
                            {
                                co.FCourse,
                                co.FCourseId
                            }).Distinct();

            //var course = from s in _context.TClassCourseFullInfos
            //             join ss in _context.TClassFullInfos on s.FClass equals ss.FClass
            //             where s.FClass == classfi
            //             select new { s.FCourse, s.FCourseId };
            return Json(courses);
            //
        }


        public IActionResult ExamPshowSj(int courseId)
        {
            var questions = (from q in _context.TSujects
                            join ca in _context.TCategories on q.FCategoryId equals ca.FCategoryId
                            where q.FCourseId == courseId
                             select new
                            {
                                q.FSujectId,
                                ca.FName,
                                q.FQuestion,
                                q.FOption1,
                                q.FOption2,
                                q.FOption3,
                                q.FOption4,
                                q.FAns,
                                q.FAnsAnalyze
                            }).OrderBy(q => q.FSujectId);

            return Json(questions);

        }


    }
}
