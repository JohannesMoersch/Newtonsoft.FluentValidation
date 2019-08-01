﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class DataValidator<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataValidatorOrErrors<TSource>
		where TStateValidator : IStateValidator<TSource>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors().Concat(new[] { _valueValidatorOne.GetDescriptor(), _valueValidatorTwo.GetDescriptor(), _valueValidatorThree.GetDescriptor() }).ToArray());

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly TValueValidatorThree _valueValidatorThree;

		private readonly Mapping<TSource, TValue> _mapper;

		public DataValidator(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree, Mapping<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
			_mapper = mapper;
		}

		public Result<TSource, ValidationError[]> Validate(object model, bool isSet, TSource value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				var (valueOption, error) = _mapper.Map(success);

				var errors = valueOption.Match(
					mappedValue =>
					{
						var oneValid = _valueValidatorOne.IsValid(mappedValue);
						var twoValid = _valueValidatorTwo.IsValid(mappedValue);
						var threeValid = _valueValidatorThree.IsValid(mappedValue);
						return (!oneValid || !twoValid || !threeValid || error != null) ? new[] { !oneValid ? _valueValidatorOne.GetError(mappedValue, false) : null, !twoValid ? _valueValidatorTwo.GetError(mappedValue, false) : null, !threeValid ? _valueValidatorThree.GetError(mappedValue, false) : null, error }.OfType<ValidationError>() : Enumerable.Empty<ValidationError>();
					},
					() => new[] { error }
				);

				if (Model.Verify(success).TryGetValue(out var _, out var modelErrors))
					return errors == null ? Result.Success<TSource, ValidationError[]>(success) : Result.Failure<TSource, ValidationError[]>(errors.ToArray());

				return Result.Failure<TSource, ValidationError[]>(modelErrors.Concat(errors ?? Enumerable.Empty<ValidationError>()).ToArray());
			}

			return Result.Failure<TSource, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
