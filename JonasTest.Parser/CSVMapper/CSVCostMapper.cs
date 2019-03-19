using System;
using System.Collections.Generic;
using System.Text;

using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

using JonasTest.Core;
using JonasTest.Parser.CSVConverters;

namespace JonasTest.Parser.CSVMapper
{
	public class CSVCostMapper : CsvMapping<Cost>
	{
		public CSVCostMapper(List<string> headers)
			: base()
		{
			MapProperty(headers.IndexOf("UNITID"), x => x.UNITID);
			MapProperty(headers.IndexOf("NPT4_PUB"), 		x => x.NPT4_PUB ,					new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_PRIV"), 	x => x.NPT4_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_PROG"), 	x => x.NPT4_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_OTHER"), 	x => x.NPT4_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT41_PUB"), 	x => x.NPT41_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT42_PUB"), 	x => x.NPT42_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT43_PUB"), 	x => x.NPT43_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT44_PUB"), 	x => x.NPT44_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT45_PUB"), 	x => x.NPT45_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT41_PRIV"), 	x => x.NPT41_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT42_PRIV"), 	x => x.NPT42_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT43_PRIV"), 	x => x.NPT43_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT44_PRIV"), 	x => x.NPT44_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT45_PRIV"), 	x => x.NPT45_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT41_PROG"), 	x => x.NPT41_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT42_PROG"), 	x => x.NPT42_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT43_PROG"), 	x => x.NPT43_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT44_PROG"), 	x => x.NPT44_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT45_PROG"), 	x => x.NPT45_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT41_OTHER"), 	x => x.NPT41_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT42_OTHER"), 	x => x.NPT42_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT43_OTHER"), 	x => x.NPT43_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT44_OTHER"), 	x => x.NPT44_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT45_OTHER"), 	x => x.NPT45_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_048_PUB"), x => x.NPT4_048_PUB	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_048_PRIV"), x => x.NPT4_048_PRIV	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_048_PROG"), x => x.NPT4_048_PROG	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_048_OTHER"), x => x.NPT4_048_OTHER	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_3075_PUB"), x => x.NPT4_3075_PUB	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_3075_PRIV"), x => x.NPT4_3075_PRIV	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_75UP_PUB"), x => x.NPT4_75UP_PUB	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_75UP_PRIV"), x => x.NPT4_75UP_PRIV	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_3075_PROG"), x => x.NPT4_3075_PROG	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_3075_OTHER"), x => x.NPT4_3075_OTHER	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_75UP_PROG"), x => x.NPT4_75UP_PROG	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NPT4_75UP_OTHER"), x => x.NPT4_75UP_OTHER	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM4_PUB"), 		x => x.NUM4_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM4_PRIV"), 	x => x.NUM4_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM4_PROG"), 	x => x.NUM4_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM4_OTHER"), 	x => x.NUM4_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM41_PUB"), 	x => x.NUM41_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM42_PUB"), 	x => x.NUM42_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM43_PUB"), 	x => x.NUM43_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM44_PUB"), 	x => x.NUM44_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM45_PUB"), 	x => x.NUM45_PUB	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM41_PRIV"), 	x => x.NUM41_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM42_PRIV"), 	x => x.NUM42_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM43_PRIV"), 	x => x.NUM43_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM44_PRIV"), 	x => x.NUM44_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM45_PRIV"), 	x => x.NUM45_PRIV	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM41_PROG"), 	x => x.NUM41_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM42_PROG"), 	x => x.NUM42_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM43_PROG"), 	x => x.NUM43_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM44_PROG"), 	x => x.NUM44_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM45_PROG"), 	x => x.NUM45_PROG	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM41_OTHER"), 	x => x.NUM41_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM42_OTHER"), 	x => x.NUM42_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM43_OTHER"), 	x => x.NUM43_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM44_OTHER"), 	x => x.NUM44_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUM45_OTHER"), 	x => x.NUM45_OTHER	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("COSTT4_A"), 	x => x.COSTT4_A	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("COSTT4_P"), 	x => x.COSTT4_P	,				new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("TUITIONFEE_IN"), x => x.TUITIONFEE_IN	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("TUITIONFEE_OUT"), x => x.TUITIONFEE_OUT	,			new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("TUITIONFEE_PROG"), x => x.TUITIONFEE_PROG, new SafeNullableIntegerConverter());
		}
	}
}