﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Valigator.Core
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ValidationDataExtensions
	{
		public static ValidationData<TValue> Not<TValue>(this ValidationData<TValue> data, Func<InvertableValidatorValidationData<TValue>, IInvertableValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableValidatorValidationData<TValue>()));
	}
}
