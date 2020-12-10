﻿using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public interface IInvertableModelValidator<TModel, TValue>
	{
		ValidatorResult InverseValidate(TModel model, TValue value);
	}
}