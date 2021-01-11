﻿using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredDictionaryValidationData<TKey, TValue> : IPropertyData<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IReadOnlyDictionary<TKey, TValue>>, IRootValidationData<RequiredDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, TValue>> _validationData;

		public RequiredDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, TValue>> validationData)
			=> _validationData = validationData;

		public RequiredDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public RequiredDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(values);
					
					return Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, TValue> value)
			=> _validationData.Process(value);
	}
}