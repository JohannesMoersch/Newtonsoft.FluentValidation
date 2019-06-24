﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public struct DataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue>
		where TStateValidator : IStateValidator<TSource>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;

		internal TValueValidatorOne ValueValidator => _valueValidatorOne;

		public Data<TSource> Data => new Data<TSource>(new DataValidator<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, _valueValidatorOne));

		public DataSourceStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		internal DataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue> InvertOne()
			=> new DataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, _valueValidatorOne);

		internal DataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> Add<TValueValidatorTwo>(TValueValidatorTwo valueValidator)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new DataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, valueValidator);

		public static implicit operator Data<TSource>(DataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
