using System;
using System.Collections.Generic;
using System.Text;

using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

using JonasTest.Core;
using JonasTest.Parser.CSVConverters;

namespace JonasTest.Parser.CSVMapper
{
	public class CSVRootMapper : CsvMapping<Root>
	{
		public CSVRootMapper(List<string> headers)
			: base()
		{
			
			MapProperty(headers.IndexOf("UNITID"), x=> x.UNITID);
			MapProperty(headers.IndexOf("OPEID"), x=> x.OPEID);
			MapProperty(headers.IndexOf("OPEID6"), x=> x.OPEID6);
			MapProperty(headers.IndexOf("LATITUDE"),  x=> x.LATITUDE, new SafeNullableDecimalConverter());
			MapProperty(headers.IndexOf("LONGITUDE"),  x=> x.LONGITUDE, new SafeNullableDecimalConverter());
		}
	}
}