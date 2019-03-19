using System;
using System.Collections.Generic;

namespace JonasTest.Data.Model
{
    public partial class Admissions
    {
        public int Unitid { get; set; }
        public decimal? AdmRate { get; set; }
        public decimal? AdmRateAll { get; set; }
        public decimal? Satvr25 { get; set; }
        public decimal? Satvr75 { get; set; }
        public decimal? Satmt25 { get; set; }
        public decimal? Satmt75 { get; set; }
        public decimal? Satwr25 { get; set; }
        public decimal? Satwr75 { get; set; }
        public decimal? Satvrmid { get; set; }
        public decimal? Satmtmid { get; set; }
        public decimal? Satwrmid { get; set; }
        public decimal? Actcm25 { get; set; }
        public decimal? Actcm75 { get; set; }
        public decimal? Acten25 { get; set; }
        public decimal? Acten75 { get; set; }
        public decimal? Actmt25 { get; set; }
        public decimal? Actmt75 { get; set; }
        public decimal? Actwr25 { get; set; }
        public decimal? Actwr75 { get; set; }
        public decimal? Actcmmid { get; set; }
        public decimal? Actenmid { get; set; }
        public decimal? Actmtmid { get; set; }
        public decimal? Actwrmid { get; set; }
        public decimal? SatAvg { get; set; }
        public decimal? SatAvgAll { get; set; }

        public virtual Root Unit { get; set; }
    }
}
