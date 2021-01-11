﻿using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ModelValidationData;

namespace Valigator.ModelPropertyFactories
{
	public class ModelCollectionPropertyFactory<TModel, TValue>
	{
		public static ModelCollectionPropertyFactory<TModel, TValue> Instance { get; } = new ModelCollectionPropertyFactory<TModel, TValue>();

		private ModelCollectionPropertyFactory() { }

		public RequiredCollectionModelValidationData<TModel, TValue> Required()
			=> new RequiredCollectionModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>>());

		public OptionalCollectionModelValidationData<TModel, TValue> Optional()
			=> new OptionalCollectionModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>>());

		public DefaultedCollectionModelValidationData<TModel, TValue> Defaulted(IReadOnlyList<TValue> defaultValue)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(defaultValue, new ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>>());
	}

	public class ModelNullableCollectionPropertyFactory<TModel, TValue>
	{
		public static ModelNullableCollectionPropertyFactory<TModel, TValue> Instance { get; } = new ModelNullableCollectionPropertyFactory<TModel, TValue>();

		private ModelNullableCollectionPropertyFactory() { }

		public RequiredNullableCollectionModelValidationData<TModel, TValue> Required()
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>>());

		public OptionalNullableCollectionModelValidationData<TModel, TValue> Optional()
			=> new OptionalNullableCollectionModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>>());

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> Defaulted(Option<IReadOnlyList<TValue>> defaultValue)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(defaultValue, new ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>>());
	}

	public class ModelOptionCollectionPropertyFactory<TModel, TValue>
	{
		public static ModelOptionCollectionPropertyFactory<TModel, TValue> Instance { get; } = new ModelOptionCollectionPropertyFactory<TModel, TValue>();

		private ModelOptionCollectionPropertyFactory() { }

		public RequiredOptionCollectionModelValidationData<TModel, TValue> Required()
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>>());

		public OptionalOptionCollectionModelValidationData<TModel, TValue> Optional()
			=> new OptionalOptionCollectionModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>>());

		public DefaultedOptionCollectionModelValidationData<TModel, TValue> Defaulted(IReadOnlyList<Option<TValue>> defaultValue)
			=> new DefaultedOptionCollectionModelValidationData<TModel, TValue>(defaultValue, new ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>>());
	}

	public class ModelNullableOptionCollectionPropertyFactory<TModel, TValue>
	{
		public static ModelNullableOptionCollectionPropertyFactory<TModel, TValue> Instance { get; } = new ModelNullableOptionCollectionPropertyFactory<TModel, TValue>();

		private ModelNullableOptionCollectionPropertyFactory() { }

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> Required()
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>>());

		public OptionalNullableOptionCollectionModelValidationData<TModel, TValue> NullableOptional()
			=> new OptionalNullableOptionCollectionModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>>());

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> Defaulted(Option<IReadOnlyList<Option<TValue>>> defaultValue)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(defaultValue, new ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>>());
	}
}