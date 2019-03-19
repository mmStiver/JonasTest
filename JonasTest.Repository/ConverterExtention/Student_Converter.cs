using System;
using System.Collections.Generic;

namespace JonasTest.Repository.ConverterExtention
{
    public static class Student_converter
	{

		public static Core.Student ToTransferObject(this Data.Model.Student data) { 
			var core = new Core.Student();

			core.UNITID= 	data.Unitid          ;
			core.UGDS = data.Ugds				 ;
			core.UG = data.Ug				 ;
			core.UGDS_WHITE= data.UgdsWhite		 ;
			core.UGDS_BLACK= data.UgdsBlack		 ;
			core.UGDS_HISP= data.UgdsHisp			 ;
			core.UGDS_ASIAN= data.UgdsAsian		 ;
			core.UGDS_AIAN= data.UgdsAian			 ;
			core.UGDS_NHPI= data.UgdsNhpi			 ;
			core.UGDS_2MOR= data.Ugds2mor			 ;
			core.UGDS_NRA= data.UgdsNra			 ;
			core.UGDS_UNKN= data.UgdsUnkn			 ;
			core.UGDS_WHITENH= data.UgdsWhitenh		 ;
			core.UGDS_BLACKNH= data.UgdsBlacknh		 ;
			core.UGDS_API= data.UgdsApi			 ;
			core.UGDS_AIANOLD= data.UgdsAianold		 ;
			core.UGDS_HISPOLD= data.UgdsHispold		 ;
			core.UG_NRA= data.UgNra			 ;
			core.UG_UNKN= data.UgUnkn			 ;
			core.UG_WHITENH= data.UgWhitenh		 ;
			core.UG_BLACKNH= data.UgBlacknh		 ;
			core.UG_API= data.UgApi			 ;
			core.UG_AIANOLD= data.UgAianold		 ;
			core.UG_HISPOLD= data.UgHispold		 ;
			core.PPTUG_EF= data.PptugEf			 ;
			core.PPTUG_EF2= data.PptugEf2			 ;
			core.PFTFTUG1_EF= data.Pftftug1Ef		 ;
			core.RET_FT4= data.RetFt4			 ;
			core.RET_FTL4= data.RetFtl4			 ;
			core.RET_PT4= data.RetPt4			 ;
			core.RET_PTL4= data.RetPtl4			 ;
			core.UG25ABV= data.Ug25abv			 ;
			core.INC_PCT_LO= data.IncPctLo			 ;
			core.DEP_STAT_PCT_IND= data.DepStatPctInd	 ;
			core.IND_INC_PCT_LO= data.IndIncPctLo		 ;
			core.DEP_INC_PCT_LO= data.DepIncPctLo		 ;
			core.PAR_ED_PCT_1STGEN= data.ParEdPct1stgen	 ;
			core.INC_PCT_M1= data.IncPctM1			 ;
			core.INC_PCT_M2= data.IncPctM2			 ;
			core.INC_PCT_H1= data.IncPctH1			 ;
			core.INC_PCT_H2= data.IncPctH2			 ;
			core.DEP_INC_PCT_M1= data.DepIncPctM1		 ;
			core.DEP_INC_PCT_M2= data.DepIncPctM2		 ;
			core.DEP_INC_PCT_H1= data.DepIncPctH1		 ;
			core.DEP_INC_PCT_H2= data.DepIncPctH2		 ;
			core.IND_INC_PCT_M1= data.IndIncPctM1		 ;
			core.IND_INC_PCT_M2= data.IndIncPctM2		 ;
			core.IND_INC_PCT_H1= data.IndIncPctH1		 ;
			core.IND_INC_PCT_H2= data.IndIncPctH2		 ;
			core.PAR_ED_PCT_MS= data.ParEdPctMs		 ;
			core.PAR_ED_PCT_HS= data.ParEdPctHs		 ;
			core.PAR_ED_PCT_PS= data.ParEdPctPs		 ;
			core.APPL_SCH_PCT_GE2= data.ApplSchPctGe2	 ;
			core.APPL_SCH_PCT_GE3= data.ApplSchPctGe3	 ;
			core.APPL_SCH_PCT_GE4= data.ApplSchPctGe4	 ;
			core.APPL_SCH_PCT_GE5= data.ApplSchPctGe5	 ;
			core.DEP_INC_AVG= data.DepIncAvg		 ;
			core.IND_INC_AVG= data.IndIncAvg		 ;
			core.INC_N= data.IncN				 ;
			core.DEP_INC_N= data.DepIncN			 ;
			core.IND_INC_N= data.IndIncN			 ;
			core.DEP_STAT_N= data.DepStatN			 ;
			core.PAR_ED_N= data.ParEdN			 ;
			core.APPL_SCH_N= data.ApplSchN			 ;
			core.PELL_EVER= data.PellEver			 ;
			core.AGE_ENTRY= data.AgeEntry			 ;
			core.AGE_ENTRY_SQ= data.AgeEntrySq		 ;
			core.AGEGE24= data.Agege24			 ;
			core.FEMALE= data.Female			 ;
			core.MARRIED= data.Married			 ;
			core.DEPENDENT= data.Dependent		 ;
			core.VETERAN= data.Veteran			 ;
			core.FIRST_GEN= data.FirstGen			 ;
			core.FAMINC= data.Faminc			 ;
			core.MD_FAMINC= data.MdFaminc			 ;
			core.FAMINC_IND= data.FamincInd		 ;
			core.LNFAMINC= data.Lnfaminc			 ;
			core.LNFAMINC_IND= data.LnfamincInd		 ;
			core.PCT_WHITE= data.PctWhite			 ;
			core.PCT_BLACK= data.PctBlack			 ;
			core.PCT_ASIAN= data.PctAsian			 ;
			core.PCT_HISPANIC= data.PctHispanic		 ;
			core.PCT_BA= data.PctBa			 ;
			core.PCT_GRAD_PROF= data.PctGradProf		 ;
			core.PCT_BORN_US= data.PctBornUs		 ;
			core.MEDIAN_HH_INC= data.MedianHhInc		 ;
			core.POVERTY_RATE= data.PovertyRate		 ;
			core.UNEMP_RATE= data.UnempRate		 ;
			core.LN_MEDIAN_HH_INC= data.LnMedianHhInc	 ;
			core.FSEND_COUNT= data.FsendCount		 ;
			core.FSEND_1= data.Fsend1			 ;
			core.FSEND_2= data.Fsend2			 ;
			core.FSEND_3= data.Fsend3			 ;
			core.FSEND_4= data.Fsend4			 ;
			core.FSEND_5= data.Fsend5			 ;
			core.UGDS_MEN= data.UgdsMen			 ;
			core.UGDS_WOMEN= data.UgdsWomen		 ;
			core.D_PCTPELL_PCTFLOAN= data.DPctpellPctfloan	 ;
			core.UGNONDS= data.Ugnonds			 ;
			core.GRADS= data.Grads			 ;
			core.RET_FT4_POOLED= data.RetFt4Pooled		 ;
			core.RET_FTL4_POOLED= data.RetFtl4Pooled	 ;
			core.RET_PT4_POOLED= data.RetPt4Pooled		 ;
			core.RET_PTL4_POOLED= data.RetPtl4Pooled	 ;
			core.RET_FT_DEN4_POOLED= data.RetFtDen4Pooled	 ;
			core.RET_FT_DENL4_POOLED= data.RetFtDenl4Pooled	 ;
			core.RET_PT_DEN4_POOLED= data.RetPtDen4Pooled	 ;
			core.RET_PT_DENL4_POOLED= data.RetPtDenl4Pooled	 ;
			core.POOLYRSRET_FT= data.PoolyrsretFt		 ;
			core.POOLYRSRET_PT= data.PoolyrsretPt		 ;
			core.RET_FT4_POOLED_SUPP= data.RetFt4PooledSupp	 ;
			core.RET_FTL4_POOLED_SUPP= data.RetFtl4PooledSupp ;
			core.RET_PT4_POOLED_SUPP= data.RetPt4PooledSupp	 ;
			core.RET_PTL4_POOLED_SUPP = data.RetPtl4PooledSupp ;

			return core;
		}

		public static Data.Model.Student ToDataObject(this Core.Student core) { 
			var data = new Data.Model.Student();
			
			data.Unitid			 =core.UNITID;
			data.Ugds				 =core.UGDS;
			data.Ug					 =core.UG;
			data.UgdsWhite			 =core.UGDS_WHITE;
			data.UgdsBlack			 =core.UGDS_BLACK;
			data.UgdsHisp			 =core.UGDS_HISP;
			data.UgdsAsian			 =core.UGDS_ASIAN;
			data.UgdsAian			 =core.UGDS_AIAN;
			data.UgdsNhpi			 =core.UGDS_NHPI;
			data.Ugds2mor			 =core.UGDS_2MOR;
			data.UgdsNra			 =core.UGDS_NRA;
			data.UgdsUnkn			 =core.UGDS_UNKN;
			data.UgdsWhitenh		 =core.UGDS_WHITENH;
			data.UgdsBlacknh		 =core.UGDS_BLACKNH;
			data.UgdsApi			 =core.UGDS_API;
			data.UgdsAianold		 =core.UGDS_AIANOLD;
			data.UgdsHispold		 =core.UGDS_HISPOLD;
			data.UgNra				 =core.UG_NRA;
			data.UgUnkn				 =core.UG_UNKN;
			data.UgWhitenh			 =core.UG_WHITENH;
			data.UgBlacknh			 =core.UG_BLACKNH;
			data.UgApi				 =core.UG_API;
			data.UgAianold			 =core.UG_AIANOLD;
			data.UgHispold			 =core.UG_HISPOLD;
			data.PptugEf			 =core.PPTUG_EF;
			data.PptugEf2			 =core.PPTUG_EF2;
			data.Pftftug1Ef			 =core.PFTFTUG1_EF;
			data.RetFt4				 =core.RET_FT4;
			data.RetFtl4			 =core.RET_FTL4;
			data.RetPt4				 =core.RET_PT4;
			data.RetPtl4			 =core.RET_PTL4;
			data.Ug25abv			 =core.UG25ABV;
			data.IncPctLo			 =core.INC_PCT_LO;
			data.DepStatPctInd		 =core.DEP_STAT_PCT_IND;
			data.IndIncPctLo		 =core.IND_INC_PCT_LO;
			data.DepIncPctLo		 =core.DEP_INC_PCT_LO;
			data.ParEdPct1stgen		 =core.PAR_ED_PCT_1STGEN;
			data.IncPctM1			 =core.INC_PCT_M1;
			data.IncPctM2			 =core.INC_PCT_M2;
			data.IncPctH1			 =core.INC_PCT_H1;
			data.IncPctH2			 =core.INC_PCT_H2;
			data.DepIncPctM1		 =core.DEP_INC_PCT_M1;
			data.DepIncPctM2		 =core.DEP_INC_PCT_M2;
			data.DepIncPctH1		 =core.DEP_INC_PCT_H1;
			data.DepIncPctH2		 =core.DEP_INC_PCT_H2;
			data.IndIncPctM1		 =core.IND_INC_PCT_M1;
			data.IndIncPctM2		 =core.IND_INC_PCT_M2;
			data.IndIncPctH1		 =core.IND_INC_PCT_H1;
			data.IndIncPctH2		 =core.IND_INC_PCT_H2;
			data.ParEdPctMs			 =core.PAR_ED_PCT_MS;
			data.ParEdPctHs			 =core.PAR_ED_PCT_HS;
			data.ParEdPctPs			 =core.PAR_ED_PCT_PS;
			data.ApplSchPctGe2		 =core.APPL_SCH_PCT_GE2;
			data.ApplSchPctGe3		 =core.APPL_SCH_PCT_GE3;
			data.ApplSchPctGe4		 =core.APPL_SCH_PCT_GE4;
			data.ApplSchPctGe5		 =core.APPL_SCH_PCT_GE5;
			data.DepIncAvg			 =core.DEP_INC_AVG;
			data.IndIncAvg			 =core.IND_INC_AVG;
			data.IncN				 =core.INC_N;
			data.DepIncN			 =core.DEP_INC_N;
			data.IndIncN			 =core.IND_INC_N;
			data.DepStatN			 =core.DEP_STAT_N;
			data.ParEdN				 =core.PAR_ED_N;
			data.ApplSchN			 =core.APPL_SCH_N;
			data.PellEver			 =core.PELL_EVER;
			data.AgeEntry			 =core.AGE_ENTRY;
			data.AgeEntrySq			 =core.AGE_ENTRY_SQ;
			data.Agege24			 =core.AGEGE24;
			data.Female				 =core.FEMALE;
			data.Married			 =core.MARRIED;
			data.Dependent			 =core.DEPENDENT;
			data.Veteran			 =core.VETERAN;
			data.FirstGen			 =core.FIRST_GEN;
			data.Faminc				 =core.FAMINC;
			data.MdFaminc			 =core.MD_FAMINC;
			data.FamincInd			 =core.FAMINC_IND;
			data.Lnfaminc			 =core.LNFAMINC;
			data.LnfamincInd		 =core.LNFAMINC_IND;
			data.PctWhite			 =core.PCT_WHITE;
			data.PctBlack			 =core.PCT_BLACK;
			data.PctAsian			 =core.PCT_ASIAN;
			data.PctHispanic		 =core.PCT_HISPANIC;
			data.PctBa				 =core.PCT_BA;
			data.PctGradProf		 =core.PCT_GRAD_PROF;
			data.PctBornUs			 =core.PCT_BORN_US;
			data.MedianHhInc		 =core.MEDIAN_HH_INC;
			data.PovertyRate		 =core.POVERTY_RATE;
			data.UnempRate			 =core.UNEMP_RATE;
			data.LnMedianHhInc		 =core.LN_MEDIAN_HH_INC;
			data.FsendCount			 =core.FSEND_COUNT;
			data.Fsend1				 =core.FSEND_1;
			data.Fsend2				 =core.FSEND_2;
			data.Fsend3				 =core.FSEND_3;
			data.Fsend4				 =core.FSEND_4;
			data.Fsend5				 =core.FSEND_5;
			data.UgdsMen			 =core.UGDS_MEN;
			data.UgdsWomen			 =core.UGDS_WOMEN;
			data.DPctpellPctfloan	 =core.D_PCTPELL_PCTFLOAN;
			data.Ugnonds			 =core.UGNONDS;
			data.Grads				 =core.GRADS;
			data.RetFt4Pooled		 =core.RET_FT4_POOLED;
			data.RetFtl4Pooled		 =core.RET_FTL4_POOLED;
			data.RetPt4Pooled		 =core.RET_PT4_POOLED;
			data.RetPtl4Pooled		 =core.RET_PTL4_POOLED;
			data.RetFtDen4Pooled	 =core.RET_FT_DEN4_POOLED;
			data.RetFtDenl4Pooled	 =core.RET_FT_DENL4_POOLED;
			data.RetPtDen4Pooled	 =core.RET_PT_DEN4_POOLED;
			data.RetPtDenl4Pooled	 =core.RET_PT_DENL4_POOLED;
			data.PoolyrsretFt		 =core.POOLYRSRET_FT;
			data.PoolyrsretPt		 =core.POOLYRSRET_PT;
			data.RetFt4PooledSupp	 =core.RET_FT4_POOLED_SUPP;
			data.RetFtl4PooledSupp	 =core.RET_FTL4_POOLED_SUPP;
			data.RetPt4PooledSupp	 =core.RET_PT4_POOLED_SUPP;
			data.RetPtl4PooledSupp   =core.RET_PTL4_POOLED_SUPP;

			return data;
		}
    }
}


		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
