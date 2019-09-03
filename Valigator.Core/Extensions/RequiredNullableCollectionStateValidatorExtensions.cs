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
	public static class RequiredNullableCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], TValueValidator> Not<TValue, TValueValidator>(this RequiredNullableCollectionStateValidator<TValue> source, Func<RequiredNullableCollectionStateValidator<TValue>, DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> source, Func<DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]>, DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], CustomValidator<Option<TValue>[]>> Assert<TValue>(this RequiredNullableCollectionStateValidator<TValue> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], CustomValidator<Option<TValue>[]>> Assert<TValue>(this DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[]> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>> Unique<TValue>(this RequiredNullableCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<Option<TValue>>());

		public static DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>> Unique<TValue>(this DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[]> source)
			=> source.Add(new UniqueValidator<Option<TValue>>());

		public static DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>> ItemCount<TValue>(this RequiredNullableCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<Option<TValue>>(minimumItems, maximumItems));

		public static DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>> ItemCount<TValue>(this DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<Option<TValue>>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> ItemCount<TSource, TValue>(this DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<Option<TValue>>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> ItemCount<TSource, TValue>(this DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<Option<TValue>>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>> source, Func<DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>>, DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>> source, Func<DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>>, DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceInvertedStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceStandardInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceStandardStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> source, Func<DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>>, DataSourceStandardStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> source, Func<DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>>, DataSourceInvertedStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> source, Func<DataSourceStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>>, DataSourceStandardInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>> source, Func<DataSourceInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>>, DataSourceInvertedInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], UniqueValidator<Option<TValue>>, ItemCountValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> Unique<TSource, TValue>(this DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>> source)
			=> source.Add(new UniqueValidator<Option<TValue>>());

		public static DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> Unique<TSource, TValue>(this DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>> source)
			=> source.Add(new UniqueValidator<Option<TValue>>());

		public static DataSourceStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>> source, Func<DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>>, DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>> source, Func<DataSourceInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>>, DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceInvertedStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceStandardInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, CustomValidator<Option<TValue>[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> source, string description, Func<Option<TValue>[], bool> validator)
			=> source.Add(new CustomValidator<Option<TValue>[]>(description, validator));

		public static DataSourceStandardStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> source, Func<DataSourceStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>>, DataSourceStandardStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> source, Func<DataSourceInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>>, DataSourceInvertedStandardStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> source, Func<DataSourceStandardInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>>, DataSourceStandardInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>> source, Func<DataSourceInvertedInverted<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>>, DataSourceInvertedInvertedStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[], ItemCountValidator<Option<TValue>>, UniqueValidator<Option<TValue>>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}