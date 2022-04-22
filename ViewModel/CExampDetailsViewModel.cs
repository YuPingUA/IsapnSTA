using ISpanSTA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ISpanSTA.ViewModel
{
    public class CExampDetailsViewModel
    {
        private TExamPaperDetail _exampd = null;
        private TExaminationPaper _examp = null;
        private TSuject _subject = null;
        private TClassFullInfo _classfi = null;
        private TClassCourseFullInfo _course = null;


        public CExampDetailsViewModel()
        {
            _exampd = new TExamPaperDetail();
            _examp = new TExaminationPaper();
            _subject = new TSuject();
            _classfi = new TClassFullInfo();
            _course = new TClassCourseFullInfo();

        }

        public TExamPaperDetail exampd
        {
            get { return _exampd; }
            set { _exampd = value; }
        }

        public TExaminationPaper examp
        {
            get { return _examp; }
            set { _examp = value; }
        }

        public TSuject subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public TClassFullInfo classfi
        {
            get { return _classfi; }
            set { _classfi = value; }
        }

        public TClassCourseFullInfo course
        {
            get { return _course; }
            set { _course = value; }
        }






        public int FEpDetailId
        {
            get { return this.exampd.FEpDetailId; }
            set { this.exampd.FEpDetailId = value; }
        }

        public int FExamPaperId
        {
            get { return this.exampd.FExamPaperId; }
            set { this.exampd.FExamPaperId = value; }
        }

        [DisplayName("班級")]
        public string FClassPeriod
        {
            get { return this.examp.FClassPeriod; }
            set { this.examp.FClassPeriod = value; }
        }

        public int FCourseId
        {
            get { return this.examp.FCourseId; }
            set { this.examp.FCourseId = value; }
        }

        [DisplayName("課程")]
        public string FCourseName
        {
            get { return this.course.FCourse; }
            set { this.course.FCourse = value; }
        }

        [DisplayName("試卷標題")]
        public string FExamPaperName
        {
            get { return this.examp.FName; }
            set { this.examp.FName = value; }
        }

        [DisplayName("試卷描述")]
        public string FDescription
        {
            get { return this.examp.FDescription; }
            set { this.examp.FDescription = value; }
        }

        [DisplayName("開始時間")]
        public DateTime? FBegin
        {
            get { return this.examp.FBegin; }
            set { this.examp.FBegin = value; }
        }

        [DisplayName("結束時間")]
        public DateTime? FEnd
        {
            get { return this.examp.FEnd; }
            set { this.examp.FEnd = value; }
        }

        [DisplayName("時間限制")]
        public int? FTimeLimit
        {
            get { return this.examp.FTimeLimit; }
            set { this.examp.FTimeLimit = value; }
        }

        [DisplayName("公布解答")]
        public DateTime? FReveal
        {
            get { return this.examp.FReveal; }
            set { this.examp.FReveal = value; }
        }

        [DisplayName("排序")]
        public int? FOrder
        {
            get { return this.examp.FOrder; }
            set { this.examp.FOrder = value; }
        }

        public int FSujectId
        {
            get { return this.exampd.FSujectId; }
            set { this.exampd.FSujectId = value; }
        }

    }
}
