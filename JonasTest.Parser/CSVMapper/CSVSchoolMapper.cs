using System;
using System.Collections.Generic;
using System.Text;

using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

using JonasTest.Core;
using JonasTest.Parser.CSVConverters;

namespace JonasTest.Parser.CSVMapper
{
	public class CSVSchoolMapper : CsvMapping<School>
	{
		public CSVSchoolMapper(List<string> headers)
			: base()
		{
			MapProperty(headers.IndexOf("UNITID"), x => x.UNITID);
			MapProperty(headers.IndexOf("INSTNM"), x => x.INSTNM		);
				MapProperty(headers.IndexOf("CITY"), x => x.CITY		);
				MapProperty(headers.IndexOf("STABBR"), x => x.STABBR		);
				MapProperty(headers.IndexOf("ZIP"), x => x.ZIP			);
				MapProperty(headers.IndexOf("ACCREDAGENCY"), x => x.ACCREDAGENCY);
				MapProperty(headers.IndexOf("INSTURL"), x => x.INSTURL		);
				MapProperty(headers.IndexOf("NPCURL"), x => x.NPCURL      );

				MapProperty(headers.IndexOf("SCH_DEG"), x => x.SCH_DEG, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("HCM2"), x => x.HCM2, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("MAIN"), x => x.MAIN, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NUMBRANCH"), x => x.NUMBRANCH, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("PREDDEG"), x => x.PREDDEG, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("HIGHDEG"), x => x.HIGHDEG, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("CONTROL"), x => x.CONTROL, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("ST_FIPS"), x => x.ST_FIPS, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("REGION"), x => x.REGION, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("LOCALE"), x => x.LOCALE, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("LOCALE2"), x => x.LOCALE2, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("CCBASIC"), x => x.CCBASIC, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("CCUGPROF"), x => x.CCUGPROF, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("CCSIZSET"), x => x.CCSIZSET, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("HBCU"), x => x.HBCU, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("PBI"), x => x.PBI, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("ANNHI"), x => x.ANNHI, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("TRIBAL"), x => x.TRIBAL, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("AANAPII"), x => x.AANAPII, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("HSI"), x => x.HSI, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("NANTI"), x => x.NANTI, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("MENONLY"), x => x.MENONLY, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("WOMENONLY"), x => x.WOMENONLY, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("RELAFFIL"), x => x.RELAFFIL, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("DISTANCEONLY"), x => x.DISTANCEONLY, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("CURROPER"), x => x.CURROPER, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("TUITFTE"), x => x.TUITFTE, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("INEXPFTE"), x => x.INEXPFTE, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("AVGFACSAL"), x => x.AVGFACSAL, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("PFTFAC"), x => x.PFTFAC, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("ALIAS"), x => x.ALIAS);
				MapProperty(headers.IndexOf("ICLEVEL"), x => x.ICLEVEL, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("OPENADMP"), x => x.OPENADMP, new SafeNullableIntegerConverter());
			MapProperty(headers.IndexOf("ACCREDCODE"), x => x.ACCREDCODE);
			MapProperty(headers.IndexOf("T4APPROVALDATE"), x => x.T4APPROVALDATE);
		}
	}
}