using System;
using System.Collections.Generic;
using System.Text;

using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

using JonasTest.Core;
using JonasTest.Parser.CSVConverters;

namespace JonasTest.Parser.CSVMapper
{
	public class CSVEarningsMapper : CsvMapping<Earnings>
	{
		public CSVEarningsMapper(List<string> headers)
			: base()
		{
			MapProperty(headers.IndexOf("UNITID"), x => x.UNITID);
			MapProperty(headers.IndexOf("COUNT_NWNE_P10"), x=> x.COUNT_NWNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_P10"), x=> x.COUNT_WNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_P10"), x=> x.MN_EARN_WNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MD_EARN_WNE_P10"), x=> x.MD_EARN_WNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT10_EARN_WNE_P10"), x=> x.PCT10_EARN_WNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT25_EARN_WNE_P10"), x=> x.PCT25_EARN_WNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT75_EARN_WNE_P10"), x=> x.PCT75_EARN_WNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT90_EARN_WNE_P10"), x=> x.PCT90_EARN_WNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("SD_EARN_WNE_P10"), x=> x.SD_EARN_WNE_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INC1_P10"), x=> x.COUNT_WNE_INC1_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INC2_P10"), x=> x.COUNT_WNE_INC2_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INC3_P10"), x=> x.COUNT_WNE_INC3_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INDEP0_INC1_P10"), x=> x.COUNT_WNE_INDEP0_INC1_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INDEP0_P10"), x=> x.COUNT_WNE_INDEP0_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INDEP1_P10"), x=> x.COUNT_WNE_INDEP1_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_MALE0_P10"), x=> x.COUNT_WNE_MALE0_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_MALE1_P10"), x=> x.COUNT_WNE_MALE1_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("GT_25K_P10"), x=> x.GT_25K_P10						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("GT_28K_P10"), x=> x.GT_28K_P10						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INC1_P10"), x=> x.MN_EARN_WNE_INC1_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INC2_P10"), x=> x.MN_EARN_WNE_INC2_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INC3_P10"), x=> x.MN_EARN_WNE_INC3_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INDEP0_INC1_P10"), x=> x.MN_EARN_WNE_INDEP0_INC1_P10					,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INDEP0_P10"), x=> x.MN_EARN_WNE_INDEP0_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INDEP1_P10"), x=> x.MN_EARN_WNE_INDEP1_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_MALE0_P10"), x=> x.MN_EARN_WNE_MALE0_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_MALE1_P10"), x=> x.MN_EARN_WNE_MALE1_P10						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_NWNE_P6"), x=> x.COUNT_NWNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_P6"), x=> x.COUNT_WNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_P6"), x=> x.MN_EARN_WNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MD_EARN_WNE_P6"), x=> x.MD_EARN_WNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT10_EARN_WNE_P6"), x=> x.PCT10_EARN_WNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT25_EARN_WNE_P6"), x=> x.PCT25_EARN_WNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT75_EARN_WNE_P6"), x=> x.PCT75_EARN_WNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT90_EARN_WNE_P6"), x=> x.PCT90_EARN_WNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("SD_EARN_WNE_P6"), x=> x.SD_EARN_WNE_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INC1_P6"), x=> x.COUNT_WNE_INC1_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INC2_P6"), x=> x.COUNT_WNE_INC2_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INC3_P6"), x=> x.COUNT_WNE_INC3_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INDEP0_INC1_P6"), x=> x.COUNT_WNE_INDEP0_INC1_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INDEP0_P6"), x=> x.COUNT_WNE_INDEP0_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_INDEP1_P6"), x=> x.COUNT_WNE_INDEP1_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_MALE0_P6"), x=> x.COUNT_WNE_MALE0_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_MALE1_P6"), x=> x.COUNT_WNE_MALE1_P6						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("GT_25K_P6"), x=> x.GT_25K_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("GT_28K_P6"), x=> x.GT_28K_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INC1_P6"), x=> x.MN_EARN_WNE_INC1_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INC2_P6"), x=> x.MN_EARN_WNE_INC2_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INC3_P6"), x=> x.MN_EARN_WNE_INC3_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INDEP0_INC1_P6"), x=> x.MN_EARN_WNE_INDEP0_INC1_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INDEP0_P6"), x=> x.MN_EARN_WNE_INDEP0_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_INDEP1_P6"), x=> x.MN_EARN_WNE_INDEP1_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_MALE0_P6"), x=> x.MN_EARN_WNE_MALE0_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_MALE1_P6"), x=> x.MN_EARN_WNE_MALE1_P6						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("COUNT_NWNE_P7"), x=> x.COUNT_NWNE_P7						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_P7"), x=> x.COUNT_WNE_P7						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_P7"), x=> x.MN_EARN_WNE_P7						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("SD_EARN_WNE_P7"), x=> x.SD_EARN_WNE_P7						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("GT_25K_P7"), x=> x.GT_25K_P7						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("COUNT_NWNE_P8"), x=> x.COUNT_NWNE_P8						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_P8"), x=> x.COUNT_WNE_P8						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_P8"), x=> x.MN_EARN_WNE_P8						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("MD_EARN_WNE_P8"), x=> x.MD_EARN_WNE_P8						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("PCT10_EARN_WNE_P8"), x=> x.PCT10_EARN_WNE_P8						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT25_EARN_WNE_P8"), x=> x.PCT25_EARN_WNE_P8						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT75_EARN_WNE_P8"), x=> x.PCT75_EARN_WNE_P8						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("PCT90_EARN_WNE_P8"), x=> x.PCT90_EARN_WNE_P8						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("SD_EARN_WNE_P8"), x=> x.SD_EARN_WNE_P8						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("GT_25K_P8"), x=> x.GT_25K_P8						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("GT_28K_P8"), x=> x.GT_28K_P8						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("COUNT_NWNE_P9"), x=> x.COUNT_NWNE_P9						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("COUNT_WNE_P9"), x=> x.COUNT_WNE_P9						,new SafeNullableIntegerConverter());
				MapProperty(headers.IndexOf("MN_EARN_WNE_P9"), x=> x.MN_EARN_WNE_P9						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("SD_EARN_WNE_P9"), x=> x.SD_EARN_WNE_P9						,new SafeNullableDecimalConverter());
				MapProperty(headers.IndexOf("GT_25K_P9"), x=> x.GT_25K_P9, new SafeNullableDecimalConverter());
		
		}
	}
}