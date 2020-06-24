﻿using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Text.Json
{
	internal static class FunctionalExtensions
	{
		private static readonly Func<bool> False = () => false;

		private static class DelegateCache<T>
		{
			public static readonly Func<T, bool> True = _ => true;
			public static readonly Func<T, bool> False = _ => false;
			public static readonly Func<T> Default = () => default;
			public static readonly Func<T, T> Passthrough = _ => _;
		}

		public static bool TryGetValue<TValue>(this Option<TValue> option, out TValue some)
		{
			some = option.Match(DelegateCache<TValue>.Passthrough, DelegateCache<TValue>.Default);

			return option.Match(DelegateCache<TValue>.True, False);
		}

		public static bool TryGetValue<TValue>(this Optional<TValue> optional, out TValue value)
		{
			value = optional.Match(DelegateCache<TValue>.Passthrough, DelegateCache<TValue>.Default);

			return optional.Match(DelegateCache<TValue>.True, False);
		}
	}
}
