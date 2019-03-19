using System;
using System.Collections.Generic;
using System.Text;

using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

using JonasTest.Core;
using JonasTest.Parser.CSVConverters;

namespace JonasTest.Parser.CSVMapper
{
	public class CSVStudentMapper : CsvMapping<Student>
	{
		public CSVStudentMapper(List<string> headers)
			: base()
		{

			var h = headers[1615];
			MapProperty(headers.IndexOf("UNITID"), x => x.UNITID);
			MapProperty(headers.IndexOf("UGDS"), x => x.UGDS , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("UG"), x => x.UG , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("UGDS_WHITE"), x => x.UGDS_WHITE, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_BLACK"), x => x.UGDS_BLACK, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_HISP"), x => x.UGDS_HISP, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_ASIAN"), x => x.UGDS_ASIAN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_AIAN"), x => x.UGDS_AIAN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_NHPI"), x => x.UGDS_NHPI, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_2MOR"), x => x.UGDS_2MOR, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_NRA"), x => x.UGDS_NRA, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_UNKN"), x => x.UGDS_UNKN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_WHITENH"), x => x.UGDS_WHITENH, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_BLACKNH"), x => x.UGDS_BLACKNH, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_API"), x => x.UGDS_API, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_AIANOLD"), x => x.UGDS_AIANOLD, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_HISPOLD"), x => x.UGDS_HISPOLD, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UG_NRA"), x => x.UG_NRA, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UG_UNKN"), x => x.UG_UNKN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UG_WHITENH"), x => x.UG_WHITENH, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UG_BLACKNH"), x => x.UG_BLACKNH, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UG_API"), x => x.UG_API, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UG_AIANOLD"), x => x.UG_AIANOLD, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UG_HISPOLD"), x => x.UG_HISPOLD, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PPTUG_EF"), x => x.PPTUG_EF, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PPTUG_EF2"), x => x.PPTUG_EF2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PFTFTUG1_EF"), x => x.PFTFTUG1_EF, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_FT4"), x => x.RET_FT4, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_FTL4"), x => x.RET_FTL4, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_PT4"), x => x.RET_PT4, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_PTL4"), x => x.RET_PTL4, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UG25ABV"), x => x.UG25ABV, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("INC_PCT_LO"), x => x.INC_PCT_LO, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("DEP_STAT_PCT_IND"), x => x.DEP_STAT_PCT_IND, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("IND_INC_PCT_LO"), x => x.IND_INC_PCT_LO, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("DEP_INC_PCT_LO"), x => x.DEP_INC_PCT_LO, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PAR_ED_PCT_1STGEN"), x => x.PAR_ED_PCT_1STGEN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("INC_PCT_M1"), x => x.INC_PCT_M1, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("INC_PCT_M2"), x => x.INC_PCT_M2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("INC_PCT_H1"), x => x.INC_PCT_H1, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("INC_PCT_H2"), x => x.INC_PCT_H2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("DEP_INC_PCT_M1"), x => x.DEP_INC_PCT_M1, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("DEP_INC_PCT_M2"), x => x.DEP_INC_PCT_M2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("DEP_INC_PCT_H1"), x => x.DEP_INC_PCT_H1, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("DEP_INC_PCT_H2"), x => x.DEP_INC_PCT_H2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("IND_INC_PCT_M1"), x => x.IND_INC_PCT_M1, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("IND_INC_PCT_M2"), x => x.IND_INC_PCT_M2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("IND_INC_PCT_H1"), x => x.IND_INC_PCT_H1, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("IND_INC_PCT_H2"), x => x.IND_INC_PCT_H2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PAR_ED_PCT_MS"), x => x.PAR_ED_PCT_MS, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PAR_ED_PCT_HS"), x => x.PAR_ED_PCT_HS, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PAR_ED_PCT_PS"), x => x.PAR_ED_PCT_PS, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("APPL_SCH_PCT_GE2"), x => x.APPL_SCH_PCT_GE2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("APPL_SCH_PCT_GE3"), x => x.APPL_SCH_PCT_GE3, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("APPL_SCH_PCT_GE4"), x => x.APPL_SCH_PCT_GE4, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("APPL_SCH_PCT_GE5"), x => x.APPL_SCH_PCT_GE5, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("DEP_INC_AVG"), x => x.DEP_INC_AVG , new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("IND_INC_AVG"), x => x.IND_INC_AVG , new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("INC_N"), x => x.INC_N , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("DEP_INC_N"), x => x.DEP_INC_N , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("IND_INC_N"), x => x.IND_INC_N , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("DEP_STAT_N"), x => x.DEP_STAT_N , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("PAR_ED_N"), x => x.PAR_ED_N , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("APPL_SCH_N"), x => x.APPL_SCH_N , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("PELL_EVER"), x => x.PELL_EVER, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("AGE_ENTRY"), x => x.AGE_ENTRY , new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("AGE_ENTRY_SQ"), x => x.AGE_ENTRY_SQ , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("AGEGE24"), x => x.AGEGE24, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("FEMALE"), x => x.FEMALE, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("MARRIED"), x => x.MARRIED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("DEPENDENT"), x => x.DEPENDENT, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("VETERAN"), x => x.VETERAN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("FIRST_GEN"), x => x.FIRST_GEN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("FAMINC"), x => x.FAMINC , new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("MD_FAMINC"), x => x.MD_FAMINC , new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("FAMINC_IND"), x => x.FAMINC_IND , new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("LNFAMINC"), x => x.LNFAMINC , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("LNFAMINC_IND"), x => x.LNFAMINC_IND , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("PCT_WHITE"), x => x.PCT_WHITE, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PCT_BLACK"), x => x.PCT_BLACK, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PCT_ASIAN"), x => x.PCT_ASIAN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PCT_HISPANIC"), x => x.PCT_HISPANIC, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PCT_BA"), x => x.PCT_BA, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PCT_GRAD_PROF"), x => x.PCT_GRAD_PROF, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("PCT_BORN_US"), x => x.PCT_BORN_US, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("MEDIAN_HH_INC"), x => x.MEDIAN_HH_INC , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("POVERTY_RATE"), x => x.POVERTY_RATE, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UNEMP_RATE"), x => x.UNEMP_RATE, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("LN_MEDIAN_HH_INC"), x => x.LN_MEDIAN_HH_INC , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("FSEND_COUNT"), x => x.FSEND_COUNT , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("FSEND_1"), x => x.FSEND_1, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("FSEND_2"), x => x.FSEND_2, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("FSEND_3"), x => x.FSEND_3, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("FSEND_4"), x => x.FSEND_4, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("FSEND_5"), x => x.FSEND_5, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_MEN"), x => x.UGDS_MEN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("UGDS_WOMEN"), x => x.UGDS_WOMEN, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("D_PCTPELL_PCTFLOAN"), x => x.D_PCTPELL_PCTFLOAN , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("UGNONDS"), x => x.UGNONDS , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("GRADS"), x => x.GRADS , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("RET_FT4_POOLED"), x => x.RET_FT4_POOLED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_FTL4_POOLED"), x => x.RET_FTL4_POOLED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_PT4_POOLED"), x => x.RET_PT4_POOLED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_PTL4_POOLED"), x => x.RET_PTL4_POOLED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_FT_DEN4_POOLED"), x => x.RET_FT_DEN4_POOLED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_FT_DENL4_POOLED"), x => x.RET_FT_DENL4_POOLED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_PT_DEN4_POOLED"), x => x.RET_PT_DEN4_POOLED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_PT_DENL4_POOLED"), x => x.RET_PT_DENL4_POOLED, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("POOLYRSRET_FT"), x => x.POOLYRSRET_FT , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("POOLYRSRET_PT"), x => x.POOLYRSRET_PT , new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("RET_FT4_POOLED_SUPP"), x => x.RET_FT4_POOLED_SUPP, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_FTL4_POOLED_SUPP"), x => x.RET_FTL4_POOLED_SUPP, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_PT4_POOLED_SUPP"), x => x.RET_PT4_POOLED_SUPP, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("RET_PTL4_POOLED_SUPP"), x => x.RET_PTL4_POOLED_SUPP, new SafeNullableDecimalConverter());


		}
	}
}