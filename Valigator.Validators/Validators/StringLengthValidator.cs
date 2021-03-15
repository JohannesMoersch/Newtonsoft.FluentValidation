﻿using Functional;
using System;
using Valigator.Core;

namespace Valigator.Validators
{
	public class StringLengthValidator : IInvertableValidator<string>
	{
		private readonly int _minimumLength;

		private readonly int _maximumLength;

		public StringLengthValidator(int minimumLength, int maximumLength)
		{
			_minimumLength = minimumLength;
			_maximumLength = maximumLength;
		}

		public Result<Unit, ValidationError[]> Validate(string value)
			=> MeetsCondition(value)
				? Result.Unit<ValidationError[]>()
				: Result.Failure<Unit, ValidationError[]>(new[] { new ValidationError($"Length must be between {_minimumLength} and {_maximumLength}.") });

		public Result<Unit, ValidationError[]> InverseValidate(string value)
			=> MeetsCondition(value)
				? Result.Failure<Unit, ValidationError[]>(new[] { new ValidationError($"Length must not be between {_minimumLength} and {_maximumLength}.") })
				: Result.Unit<ValidationError[]>();

		private bool MeetsCondition(string value)
			=> value.Length >= _minimumLength && value.Length <= _maximumLength;
	}
}