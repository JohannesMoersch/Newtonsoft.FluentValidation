// NOTE: GENERATED FILE //
using Functional;
using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class NullableDefaultedStateValidatorExtensions
	{
		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator> Not<TValue, TValueValidator>(this NullableDefaultedStateValidator<TValue> source, Func<NullableDefaultedStateValidator<TValue>, DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> source, Func<DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue>, DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, CustomValidator<TValue>> Assert<TValue>(this NullableDefaultedStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this NullableDefaultedStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> EqualTo<TSource, TValue>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, string, string>, Option<string>, string, EqualsValidator<string>> NotEmpty(this NullableDefaultedStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, EqualsValidator<string>> NotEmpty<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<Guid>, Guid, Guid>, Option<Guid>, Guid, EqualsValidator<Guid>> NotEmpty(this NullableDefaultedStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<Guid>, TSource, Guid>, Option<Guid>, Guid, EqualsValidator<Guid>> NotEmpty<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<Guid>, TSource, Guid>, Option<Guid>, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, byte, byte>, Option<byte>, byte, EqualsValidator<byte>> NotZero(this NullableDefaultedStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, EqualsValidator<byte>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, EqualsValidator<sbyte>> NotZero(this NullableDefaultedStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, EqualsValidator<sbyte>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, short, short>, Option<short>, short, EqualsValidator<short>> NotZero(this NullableDefaultedStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, EqualsValidator<short>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, EqualsValidator<ushort>> NotZero(this NullableDefaultedStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, EqualsValidator<ushort>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, int, int>, Option<int>, int, EqualsValidator<int>> NotZero(this NullableDefaultedStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, EqualsValidator<int>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, uint, uint>, Option<uint>, uint, EqualsValidator<uint>> NotZero(this NullableDefaultedStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, EqualsValidator<uint>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, long, long>, Option<long>, long, EqualsValidator<long>> NotZero(this NullableDefaultedStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, EqualsValidator<long>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, EqualsValidator<ulong>> NotZero(this NullableDefaultedStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, EqualsValidator<ulong>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, float, float>, Option<float>, float, EqualsValidator<float>> NotZero(this NullableDefaultedStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, EqualsValidator<float>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, double, double>, Option<double>, double, EqualsValidator<double>> NotZero(this NullableDefaultedStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, EqualsValidator<double>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, EqualsValidator<decimal>> NotZero(this NullableDefaultedStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, EqualsValidator<decimal>> NotZero<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this NullableDefaultedStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TSource, TValue>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this NullableDefaultedStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TSource, TValue>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, byte, byte>, Option<byte>, byte, MultipleOfValidator_Byte> MultipleOf(this NullableDefaultedStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> MultipleOf(this NullableDefaultedStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, short, short>, Option<short>, short, MultipleOfValidator_Int16> MultipleOf(this NullableDefaultedStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> MultipleOf(this NullableDefaultedStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, int, int>, Option<int>, int, MultipleOfValidator_Int32> MultipleOf(this NullableDefaultedStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, uint, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> MultipleOf(this NullableDefaultedStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, long, long>, Option<long>, long, MultipleOfValidator_Int64> MultipleOf(this NullableDefaultedStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> MultipleOf(this NullableDefaultedStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, PrecisionValidator> Precision(this NullableDefaultedStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> Precision<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThan(this NullableDefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThan(this NullableDefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThanOrEqualTo(this NullableDefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> InRange(this NullableDefaultedStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThan(this NullableDefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThan(this NullableDefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this NullableDefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> InRange(this NullableDefaultedStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThan(this NullableDefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThan(this NullableDefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThanOrEqualTo(this NullableDefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> InRange(this NullableDefaultedStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThan(this NullableDefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThan(this NullableDefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this NullableDefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> InRange(this NullableDefaultedStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThan(this NullableDefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThan(this NullableDefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThanOrEqualTo(this NullableDefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> InRange(this NullableDefaultedStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThan(this NullableDefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThan(this NullableDefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThanOrEqualTo(this NullableDefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> InRange(this NullableDefaultedStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThan(this NullableDefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThan(this NullableDefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThanOrEqualTo(this NullableDefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> InRange(this NullableDefaultedStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThan(this NullableDefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThan(this NullableDefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this NullableDefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> InRange(this NullableDefaultedStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThan(this NullableDefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThan(this NullableDefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThanOrEqualTo(this NullableDefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> InRange(this NullableDefaultedStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThan(this NullableDefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThan(this NullableDefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThanOrEqualTo(this NullableDefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> InRange(this NullableDefaultedStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThan(this NullableDefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThan(this NullableDefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this NullableDefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> InRange(this NullableDefaultedStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThan(this NullableDefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this NullableDefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThan(this NullableDefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThan<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this NullableDefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> InRange(this NullableDefaultedStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> InRange<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, string, string>, Option<string>, string, StringLengthValidator> Length(this NullableDefaultedStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> Length<TSource>(this DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator>, DataSourceStandardStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}