using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JonasTest.Core.Common.Extention
{
	public static class IEnumerable_Batch
	{
		public static IEnumerable<IEnumerable<T>> Batch<T>(
		this IEnumerable<T> source, int size)
		{
			T[] bucket = null;
			var count = 0;

			foreach (var item in source)
			{
				if (bucket == null)
					bucket = new T[size];

				bucket[count++] = item;

				if (count != size)
					continue;

				yield return bucket.Select(x => x);

				bucket = null;
				count = 0;
			}

			// Return the last bucket with all remaining elements
			if (bucket != null && count > 0)
				yield return bucket.Take(count);
		}
	}
}
