using System;
using System.Collections.Generic;
using System.Text;

using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

using JonasTest.Core;
using JonasTest.Parser.CSVConverters;

namespace JonasTest.Parser.CSVMapper
{
	public class CSVAdmissionsMapper : CsvMapping<Admissions>
	{
		public CSVAdmissionsMapper(List<string> headers)
			: base()
		{
			MapProperty(headers.IndexOf("UNITID"), x => x.UNITID);
			MapProperty(headers.IndexOf("ADM_RATE"), x => x.ADM_RATE, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ADM_RATE_ALL"), x => x.ADM_RATE_ALL, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATVR25"), x => x.SATVR25, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATVR75"), x => x.SATVR75, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATMT25"), x => x.SATMT25, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATMT75"), x => x.SATMT75, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATWR25"), x => x.SATWR25, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATWR75"), x => x.SATWR75, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATVRMID"), x => x.SATVRMID, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATMTMID"), x => x.SATMTMID, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SATWRMID"), x => x.SATWRMID, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTCM25"), x => x.ACTCM25, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTCM75"), x => x.ACTCM75, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTEN25"), x => x.ACTEN25, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTEN75"), x => x.ACTEN75, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTMT25"), x => x.ACTMT25, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTMT75"), x => x.ACTMT75, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTWR25"), x => x.ACTWR25, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTWR75"), x => x.ACTWR75, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTCMMID"), x => x.ACTCMMID, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTENMID"), x => x.ACTENMID, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTMTMID"), x => x.ACTMTMID, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ACTWRMID"), x => x.ACTWRMID, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SAT_AVG"), x => x.SAT_AVG, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("SAT_AVG_ALL"), x => x.SAT_AVG_ALL, new SafeNullableDecimalConverter());
		}
	}
}
