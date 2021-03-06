﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.AspNetCore
{
	public class ModelError
	{
		public string Name { get; }

		public ModelSource Source { get; }

		public ValidationError ValidationError { get; }

		public ModelError(string name, ModelSource source, ValidationError validationError)
		{
			Name = name;
			Source = source;
			ValidationError = validationError ?? throw new ArgumentNullException(nameof(validationError));
		}
	}
}
