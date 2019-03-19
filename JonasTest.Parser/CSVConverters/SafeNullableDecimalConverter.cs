using System;
using System.Collections.Generic;
using System.Text;

using TinyCsvParser.TypeConverter;

namespace JonasTest.Parser.CSVConverters
{
	public class SafeNullableDecimalConverter : NullableDecimalConverter
	{
		public override bool TryConvert(string value, out decimal? result)
		{
			if (String.Compare(value, "privacysuppressed", true) == 0)
				return base.TryConvert("", out result);
			if (String.Compare(value, "null", true) == 0)
				value = value.ToLowerInvariant().Replace("null", "");
			return base.TryConvert(String.Format("{0:.##}", value), out result);
		}
	}
}
