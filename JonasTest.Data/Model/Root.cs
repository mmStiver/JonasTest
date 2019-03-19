using System;
using System.Collections.Generic;

namespace JonasTest.Data.Model
{
    public partial class Root
    {
        public int Unitid { get; set; }
        public int Opeid { get; set; }
        public int Opeid6 { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public virtual Academics Academics { get; set; }
        public virtual Admissions Admissions { get; set; }
        public virtual Completion Completion { get; set; }
        public virtual Cost Cost { get; set; }
        public virtual Earnings Earnings { get; set; }
        public virtual Repayment Repayment { get; set; }
        public virtual School School { get; set; }
        public virtual Student Student { get; set; }
        public virtual TitleIv TitleIv { get; set; }
    }
}
