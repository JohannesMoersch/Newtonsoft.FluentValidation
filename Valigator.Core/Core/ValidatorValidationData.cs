﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class ValidatorValidationData<TValue> : IValidationData<IValidator<TValue>, TValue>, IInvertableValidationData<IValidator<TValue>, TValue>
	{
		public IValidator<TValue> WithValidator(IValidator<TValue> value)
			=> value;

		public IValidator<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> value;
	}
}