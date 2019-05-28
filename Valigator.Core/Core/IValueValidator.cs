﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;

namespace Valigator.Core
{
	public interface IValueValidator<TValue>
	{
		IEnumerable<IValueDescriptor> GetDescriptors();

		Result<Unit, ValidationError> Validate(TValue value);
	}
}
