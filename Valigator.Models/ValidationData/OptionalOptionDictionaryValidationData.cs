﻿using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalOptionDictionaryValidationData<TKey, TValue> : IPropertyData<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, Optional<IReadOnlyDictionary<TKey, Option<TValue>>>>, IRootValidationData<OptionalOptionDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> _validationData;

		public OptionalOptionDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> validationData)
			=> _validationData = validationData;

		public OptionalOptionDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalOptionDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public OptionalOptionDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalOptionDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Optional.Set(item));

				return Result.Failure<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Optional.Unset<IReadOnlyDictionary<TKey, Option<TValue>>>());
		}

		public Result<Unit, ValidationError[]> Validate(Optional<IReadOnlyDictionary<TKey, Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}