﻿using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalValueModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Optional<TValue>>, IModelPropertyData<TModel, TValue, Optional<TValue>>, IRootModelValidationData<OptionalValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public OptionalValueModelValidationData(ValidationData<ModelValue<TModel, TValue>> validationData)
			=> _validationData = validationData;

		public OptionalValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new OptionalValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new OptionalValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new OptionalValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new OptionalValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public override Result<Optional<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<TValue>, ValidationError[]>(Optional.Unset<TValue>());

		public override Result<Optional<TValue>, ValidationError[]> CoerceNone()
			=> Result.Failure<Optional<TValue>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<TValue>, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Optional<TValue>, ValidationError[]>(Optional.Set(value));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Optional<TValue> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}