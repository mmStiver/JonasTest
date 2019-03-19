using System;
using System.Collections.Generic;

namespace JonasTest.Repository.ConverterExtention
{
	public static class Admissions_converter
	{
		public static Core.Admissions ToTransferObject(this Data.Model.Admissions data)
		{
			var core = new Core.Admissions();
			core.UNITID	     = data.Unitid ;    
			core.ADM_RATE	 =  data.AdmRate	;
			core.ADM_RATE_ALL = data.AdmRateAll ;
			core.SATVR25	 =  data.Satvr25	;
			core.SATVR75	 =  data.Satvr75	;
			core.SATMT25	 =  data.Satmt25	;
			core.SATMT75	 =  data.Satmt75	;
			core.SATWR25	 =  data.Satwr25	;
			core.SATWR75	 =  data.Satwr75	;
			core.SATVRMID	 =  data.Satvrmid	;
			core.SATMTMID	 =  data.Satmtmid	;
			core.SATWRMID	 =  data.Satwrmid	;
			core.ACTCM25	 =  data.Actcm25	;
			core.ACTCM75	 =  data.Actcm75	;
			core.ACTEN25	 =  data.Acten25	;
			core.ACTEN75	 =  data.Acten75	;
			core.ACTMT25	 =  data.Actmt25	;
			core.ACTMT75	 =  data.Actmt75	;
			core.ACTWR25	 =  data.Actwr25	;
			core.ACTWR75	 =  data.Actwr75	;
			core.ACTCMMID	 =  data.Actcmmid	;
			core.ACTENMID	 =  data.Actenmid	;
			core.ACTMTMID	 =  data.Actmtmid	;
			core.ACTWRMID	 =  data.Actwrmid	;
			core.SAT_AVG	 =  data.SatAvg		;
			core.SAT_AVG_ALL =  data.SatAvgAll	;
			return core;
		}

		public static Data.Model.Admissions ToDataObject(this Core.Admissions core) 
		{
			var data = new Data.Model.Admissions();

			data.Unitid     = core.UNITID	  ;
			data.AdmRate	= core.ADM_RATE	  ;
			data.AdmRateAll = core.ADM_RATE_ALL;
			data.Satvr25	= core.SATVR25	  ;
			data.Satvr75	= core.SATVR75	  ;
			data.Satmt25	= core.SATMT25	  ;
			data.Satmt75	= core.SATMT75	  ;
			data.Satwr25	= core.SATWR25	  ;
			data.Satwr75	= core.SATWR75	  ;
			data.Satvrmid	= core.SATVRMID	  ;
			data.Satmtmid	= core.SATMTMID	  ;
			data.Satwrmid	= core.SATWRMID	  ;
			data.Actcm25	= core.ACTCM25	  ;
			data.Actcm75	= core.ACTCM75	  ;
			data.Acten25	= core.ACTEN25	  ;
			data.Acten75	= core.ACTEN75	  ;
			data.Actmt25	= core.ACTMT25	  ;
			data.Actmt75	= core.ACTMT75	  ;
			data.Actwr25	= core.ACTWR25	  ;
			data.Actwr75	= core.ACTWR75	  ;
			data.Actcmmid	= core.ACTCMMID	  ;
			data.Actenmid	= core.ACTENMID	  ;
			data.Actmtmid	= core.ACTMTMID	  ;
			data.Actwrmid	= core.ACTWRMID	  ;
			data.SatAvg		= core.SAT_AVG	  ;
			data.SatAvgAll	= core.SAT_AVG_ALL;
			return data;
		}
	}
}