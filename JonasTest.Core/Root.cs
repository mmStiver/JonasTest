using System;

namespace JonasTest.Core
{
	[Serializable]
	public class Root
	{
		public Root(){
			Academics  = new Academics();
			Admissions = new Admissions();
			Completion = new Completion();
			Cost	   = new Cost();
			Earnings   = new Earnings();
			Repayment  = new Repayment();
			School = new School();
			}

		public int UNITID		{ get; set; }
		public int OPEID		{ get; set; }
		public int OPEID6		{ get; set; }
		public decimal? LATITUDE { get; set; }   
		public decimal? LONGITUDE { get; set; }   

		public Academics   Academics   { get; set; }
		public Admissions  Admissions  { get; set; } 
		public Completion  Completion  { get; set; } 
		public Cost        Cost        { get; set; } 
		public Earnings	   Earnings	   { get; set; } 
		public Repayment   Repayment   { get; set; } 
		public School	   School	   { get; set; } 
		public Student Student { get; set; } 


	}
}
