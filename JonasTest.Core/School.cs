using System;

namespace JonasTest.Core
{
	[Serializable]
	public class School
	{
		public int UNITID { get; set; }
		public string		INSTNM       {get; set; }   
	public string		CITY         {get; set;}   
	public string		STABBR		 {get; set;}	
	public string		ZIP			 {get; set;}	
	public string		ACCREDAGENCY {get; set;}   
	public string		INSTURL		  {get; set;}
	public string		NPCURL		  {get; set;}
	public int?			SCH_DEG			  {get; set;}
	public int?			HCM2			  {get; set;}
	public int?			MAIN			  {get; set;}
	public int?			NUMBRANCH		  {get; set;}
	public int?			PREDDEG			  {get; set;}
	public int?			HIGHDEG			  {get; set;}
	public int?			CONTROL			  {get; set;}
	public int?			ST_FIPS			  {get; set;}
	public int?			REGION			  {get; set;}
	public int?			LOCALE			  {get; set;}
	public int?			LOCALE2			  {get; set;}
	public int?			CCBASIC			  {get; set;}
	public int?			CCUGPROF		  {get; set;}
	public int?			CCSIZSET		  {get; set;}
	public int?			HBCU			  {get; set;}
	public int?			PBI				  {get; set;}
	public int?			ANNHI			  {get; set;}
	public int?			TRIBAL			  {get; set;}
	public int?			AANAPII			  {get; set;}
	public int?			HSI				  {get; set;}
	public int?			NANTI			  {get; set;}
	public int?			MENONLY			  {get; set;}
	public int?			WOMENONLY		  {get; set;}
	public int?			RELAFFIL		  {get; set;}
	public int?			DISTANCEONLY      {get; set;}
	public int?			CURROPER		  {get; set;}
	public int?			TUITFTE			  {get; set;}
	public int?			INEXPFTE		  {get; set;}
	public int?			AVGFACSAL		  {get; set;}
	public  decimal?	PFTFAC	  {get; set;}
	public  string		ALIAS		  {get; set;}
	public  int?		ICLEVEL		  {get; set;}
	public int?			OPENADMP		  {get; set;}
	public string		ACCREDCODE	  {get; set;}
	public string		T4APPROVALDATE  {get; set; }

	}
}
