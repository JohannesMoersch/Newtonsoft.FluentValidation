﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.DataContainers;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct NullableOptionalCollectionStateValidator<TValue> : ICollectionStateValidator<Optional<Option<TValue[]>>, TValue>
	{
		private static IDataContainer<Optional<Option<TValue[]>>> CreateContainer(NullableOptionalCollectionStateValidator<TValue> stateValidator)
			=> new OptionalNullableCollectionDataContainer<NullableOptionalCollectionStateValidator<TValue>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance);

		public Data<Optional<Option<TValue[]>>> Data => new Data<Optional<Option<TValue[]>>>(CreateContainer(this));

		private readonly Data<TValue> _item;

		public NullableOptionalCollectionStateValidator(Data<TValue> item)
			=> _item = item;

		public DataSourceStandard<OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue[]>>, TValue[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> new DataSourceStandard<OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue[]>>, TValue[], TValueValidator>(new OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue[]>>, TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue[]>>, TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue[]>>, TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue[]>>, TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue[]>>, TValue[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue[]>>, TValue[]>(new OptionalNullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Optional<Option<TValue[]>>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Optional<Option<TValue[]>>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Optional<Option<TValue[]>>, ValidationError[]> IStateValidator<Optional<Option<TValue[]>>, Option<TValue>[]>.Validate(Optional<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
				{
					if (StateValidatorHelpers.ValidateCollectionNotNull(notNull).TryGetValue(out var success, out var failure))
						return Result.Success<Optional<Option<TValue[]>>, ValidationError[]>(Optional.Set(Option.Some(success)));

					return Result.Failure<Optional<Option<TValue[]>>, ValidationError[]>(failure);
				}

				return Result.Success<Optional<Option<TValue[]>>, ValidationError[]>(Optional.Set(Option.None<TValue[]>()));
			}

			return Result.Success<Optional<Option<TValue[]>>, ValidationError[]>(Optional.Unset<Option<TValue[]>>());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Optional<Option<TValue[]>> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Optional<Option<TValue[]>>>(NullableOptionalCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
