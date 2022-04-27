using ISpanSTA.Models;
using ISpanSTA.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISpanSTA.Controllers
{
    public class SExamIndexController : Controller
    {
        private readonly IspanStudentSystemContext _context;

        public SExamIndexController(IspanStudentSystemContext context)
        {
            _context = context;
        }
        // GET: SExamIndexController
        public IActionResult Index() //TStudentFullInfo s
        {            
            var data = from ep in _context.TExaminationPapers
                       join cl in _context.TClassFullInfos on ep.FClassPeriod equals cl.FClassPeriod
                       join co in _context.TClassCourseFullInfos on ep.FCourseId equals co.FCourseId
                       where cl.FClassPeriod == "MSIT40"    //s.FClassPeriod
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
                           FReveal = ep.FReveal,
                           FDescription = ep.FDescription
                           
                       };

            List<CExamPaperViewModel> list = new List<CExamPaperViewModel>();
            foreach (var t in data)
                list.Add(t);

            return View(list);
           
        }

        // GET: SExamIndexController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SExamIndexController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SExamIndexController/Create
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

        // GET: SExamIndexController/Edit/5
        public IActionResult StartExam(int? id)
        {
            //var data = from epd in _context.TExamPaperDetails
            //           join ep in _context.TExaminationPapers on epd.FExamPaperId equals ep.FExamPaperId
            //           join s in _context.TSujects on epd.FSujectId equals s.FSujectId
            //           where ep.FExamPaperId == (int)id
            //           select new CExampDetailsViewModel
            //           {
            //               FExamPaperId = ep.FExamPaperId,
            //               FEpDetailId = epd.FEpDetailId,
            //               FSujectId = s.FSujectId,
            //               FExamPaperName = ep.FName,
            //               FTimeLimit = ep.FTimeLimit,
                           
            //           };

            //var data = from s in _context.TSujects
            //           join epd in _context.TExaminationPapers on epd. equals s.


            //List<CExampDetailsViewModel> da = new List<CExampDetailsViewModel>();
            //int a = Session["exid"];

            List < TSuject > EpQuestion = new List<TSuject>();

            return View();
        }

        // POST: SExamIndexController/Edit/5
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

        // GET: SExamIndexController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SExamIndexController/Delete/5
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


        public IActionResult test()
        {
            TempData["a"] = 1;
            int qNo = (int)TempData["a"];
            ViewBag.questionNo = qNo;
            TSuject a = (TSuject)TempData["qData"];

            return View(a);
        }

       
        [HttpPost]
        public IActionResult test(TSuject aaa)
        {
            //if (aaa.correct_ans == aaa.selectedvalue && aaa.qus_id != 1)
            //{
            //    Session["correctAns"] = Convert.ToInt32(Session["correctAns"]) + 1;
            //}
            //else if (aaa.correct_ans == aaa.selectedvalue && aaa.qus_id == 1)
            //{
            //    Session["correctAns"] = 1;
            //}

            //if (aaa.qus_id == 10)
            //{
            //    return RedirectToAction("Create", "Result");

            //}
            //int qId = (int)aaa.qus_id + 1;
            //Questions_tbl SingleQuestion = db.Questions_tbl.SingleOrDefault(m => m.qus_id == qId && m.exam_id == aaa.exam_id);


            //ViewBag.questionNo = qId;
            //TempData["a"] = SingleQuestion.qus_id;
            //TempData["qData"] = SingleQuestion;
            //return RedirectToAction("NextQuestion");
            return View();

        }




    }
}
