﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MPSC.PlenoSoft.Core.Utils.Statics
{
	public static class Collections
	{
		public static Boolean In<T>(this T self, params T[] values)
		{
			return values.Contains(self);
		}

		public static Boolean In<T>(this T? self, params T?[] values) where T : struct
		{
			return values.Contains(self);
		}

		public static void ForEach<T>(this IEnumerable<T> values, Action<T> action)
		{
			foreach (var item in values)
				action?.Invoke(item);
		}
	}
}