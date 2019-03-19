using System;
using System.Collections.Generic;

namespace JonasTest.Repository.ConverterExtention
{
    public static class School_Converter
	{

		public static Core.School ToTransferObject(this Data.Model.School data) { 
			var core = new Core.School();
			core.UNITID = data.Unitid		;
			core.INSTNM         	= data.Instnm		;
			core.CITY         		= data.City			;
			core.STABBR		 		= data.Stabbr		;
			core.ZIP			 	= data.Zip			;
			core.ACCREDAGENCY 		= data.Accredagency ;
			core.INSTURL		  	= data.Insturl		;
			core.NPCURL		  		= data.Npcurl		;
			core.SCH_DEG			= data.SchDeg		;
			core.HCM2				= data.Hcm2			;
			core.MAIN				= data.Main			;
			core.NUMBRANCH			= data.Numbranch	;
			core.PREDDEG			= data.Preddeg;
			core.HIGHDEG			= data.Highdeg;
			core.CONTROL			= data.Control;
			core.ST_FIPS			= data.StFips ;
			core.REGION				= data.Region ;
			core.LOCALE				= data.Locale ;
			core.LOCALE2			= data.Locale2 	;
			core.CCBASIC			= data.Ccbasic 	;
			core.CCUGPROF			= data.Ccugprof		;
			core.CCSIZSET			= data.Ccsizset		;
			core.HBCU				= data.Hbcu			;
			core.PBI				= data.Pbi			;
			core.ANNHI				= data.Annhi		;
			core.TRIBAL				= data.Tribal		;
			core.AANAPII			= data.Aanapii		;
			core.HSI				= data.Hsi			;
			core.NANTI				= data.Nanti		;
			core.MENONLY			= data.Menonly		;
			core.WOMENONLY			= data.Womenonly	;
			core.RELAFFIL			= data.Relaffil		;
			core.DISTANCEONLY  		= data.Distanceonly ;
			core.CURROPER			= data.Curroper		;
			core.TUITFTE			= data.Tuitfte		;
			core.INEXPFTE			= data.Inexpfte		;
			core.AVGFACSAL			= data.Avgfacsal;
			core.PFTFAC	  			= data.Pftfac ;
			core.ALIAS		  		= data.Alias;
			core.ICLEVEL		  	= data.Iclevel;
			core.OPENADMP			= data.Openadmp;
			core.ACCREDCODE	  		= data.Accredcode ;
			core.T4APPROVALDATE		= data.T4approvaldate ;

			return core;
		}

		public static Data.Model.School ToDataObject(this Core.School core) {
			var data = new Data.Model.School();

				data.Unitid          = core.UNITID;
				data.Instnm			 = core.INSTNM       ;
				data.City			 = core.CITY         ;
				data.Stabbr			 = core.STABBR		;
				data.Zip			 = core.ZIP			;
				data.Accredagency	 = core.ACCREDAGENCY ;
				data.Insturl		 = core.INSTURL		 ; 
				data.Npcurl			 = core.NPCURL		 ; 
				data.SchDeg			 = core.SCH_DEG		 ;
				data.Hcm2				 = core.HCM2			 ;
				data.Main				 = core.MAIN			 ;
				data.Numbranch		 = core.NUMBRANCH	 ;
				data.Preddeg	 = core.PREDDEG		 ;
				data.Highdeg	 = core.HIGHDEG		 ;
				data.Control	 = core.CONTROL		 ;
				data.StFips 	 = core.ST_FIPS		 ;
				data.Region 	 = core.REGION		 ;
				data.Locale 	 = core.LOCALE		 ;
				data.Locale2	 = core.LOCALE2		 ;
				data.Ccbasic 	 = core.CCBASIC		 ;
				data.Ccugprof			 = core.CCUGPROF		 ;
				data.Ccsizset			 = core.CCSIZSET		 ;
				data.Hbcu				 = core.HBCU			 ;
				data.Pbi				 = core.PBI			 ;
				data.Annhi			 = core.ANNHI		 ;
				data.Tribal			 = core.TRIBAL		 ;
				data.Aanapii			 = core.AANAPII		 ;
				data.Hsi				 = core.HSI			 ;
				data.Nanti			 = core.NANTI		 ;
				data.Menonly			 = core.MENONLY		 ;
				data.Womenonly		 = core.WOMENONLY	 ;
				data.Relaffil			 = core.RELAFFIL		 ;
				data.Distanceonly	 = core.DISTANCEONLY  ;
				data.Curroper		 = core.CURROPER		 ;
				data.Tuitfte			 = core.TUITFTE		 ;
				data.Inexpfte		 = core.INEXPFTE		 ;
				data.Avgfacsal		 = core.AVGFACSAL	 ;
				data.Pftfac		 = core.PFTFAC	  	 ;
				data.Alias			 = core.ALIAS		 ; 
				data.Iclevel		 = core.ICLEVEL		 ; 
				data.Openadmp		 = core.OPENADMP		 ;
				data.Accredcode		 = core.ACCREDCODE	 ; 
				data.T4approvaldate	 = core.T4APPROVALDATE;


			return data;
		}
				

    }
}
