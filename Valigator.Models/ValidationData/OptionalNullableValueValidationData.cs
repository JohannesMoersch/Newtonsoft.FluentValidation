﻿using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalNullableValueValidationData<TValue> : ValidationDataBase<Optional<Option<TValue>>>, IPropertyData<TValue, Optional<Option<TValue>>>, IRootValidationData<OptionalNullableValueValidationData<TValue>, TValue>
	{
		private readonly ValidationData<TValue> _validationData;

		public OptionalNullableValueValidationData(ValidationData<TValue> validationData)
			=> _validationData = validationData;

		public OptionalNullableValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new OptionalNullableValueValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalNullableValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new OptionalNullableValueValidationData<TValue>(_validationData.WithValidator(value));

		public override Result<Optional<Option<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Unset<Option<TValue>>());

		public override Result<Optional<Option<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Set(Option.None<TValue>()));

		public Result<Optional<Option<TValue>>, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Set(Option.Some(value)));

		public override Result<Unit, ValidationError[]> Validate(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return _validationData.Process(item);
			}

			return Result.Unit<ValidationError[]>();
		}
	}
}