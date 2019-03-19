using System;
using System.Collections.Generic;

namespace JonasTest.Data.Model
{
    public partial class School
    {
        public int Unitid { get; set; }
        public string Instnm { get; set; }
        public string City { get; set; }
        public string Stabbr { get; set; }
        public string Zip { get; set; }
        public string Accredagency { get; set; }
        public string Insturl { get; set; }
        public string Npcurl { get; set; }
        public int? SchDeg { get; set; }
        public int? Hcm2 { get; set; }
        public int? Main { get; set; }
        public int? Numbranch { get; set; }
        public int? Preddeg { get; set; }
        public int? Highdeg { get; set; }
        public int? Control { get; set; }
        public int? StFips { get; set; }
        public int? Region { get; set; }
        public int? Locale { get; set; }
        public int? Locale2 { get; set; }
        public int? Ccbasic { get; set; }
        public int? Ccugprof { get; set; }
        public int? Ccsizset { get; set; }
        public int? Hbcu { get; set; }
        public int? Pbi { get; set; }
        public int? Annhi { get; set; }
        public int? Tribal { get; set; }
        public int? Aanapii { get; set; }
        public int? Hsi { get; set; }
        public int? Nanti { get; set; }
        public int? Menonly { get; set; }
        public int? Womenonly { get; set; }
        public int? Relaffil { get; set; }
        public int? Distanceonly { get; set; }
        public int? Curroper { get; set; }
        public int? Tuitfte { get; set; }
        public int? Inexpfte { get; set; }
        public int? Avgfacsal { get; set; }
        public decimal? Pftfac { get; set; }
        public string Alias { get; set; }
        public int? Iclevel { get; set; }
        public int? Openadmp { get; set; }
        public string Accredcode { get; set; }
        public string T4approvaldate { get; set; }

        public virtual Root Unit { get; set; }
    }
}
