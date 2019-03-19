using System;
using System.Collections.Generic;
using System.Text;

using TinyCsvParser.TypeConverter;

namespace JonasTest.Parser.CSVConverters
{
	public class SafeNullableIntegerConverter : NullableInt32Converter
	{
		public override bool TryConvert(string value, out Int32? result)
		{
			if (String.Compare(value, "privacysuppressed", true) == 0)
				return base.TryConvert("", out result);

			if (String.Compare(value, "null", true) == 0)
				value = value.ToLowerInvariant().Replace("null", "");
			return base.TryConvert(value, out result);
		}
	}
}
