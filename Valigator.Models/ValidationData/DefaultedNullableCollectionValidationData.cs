﻿using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedNullableCollectionValidationData<TValue> : ValidationDataBase<Option<IReadOnlyList<TValue>>>, IPropertyData<IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<TValue>>>, IRootValidationData<DefaultedNullableCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly Func<Option<IReadOnlyList<TValue>>> _defaultValue;

		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public DefaultedNullableCollectionValidationData(Func<Option<IReadOnlyList<TValue>>> defaultValue, ValidationData<IReadOnlyList<TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(_defaultValue.Invoke());

		public override Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.None<IReadOnlyList<TValue>>());

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
		 => value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
			? Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.Some(values))
					
			: Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(Option<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
