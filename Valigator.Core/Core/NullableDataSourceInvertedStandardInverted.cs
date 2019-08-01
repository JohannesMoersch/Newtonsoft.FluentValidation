﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct NullableDataSourceInvertedStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>
		where TStateValidator : IStateValidator<Option<TSource>>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;
		private readonly TValueValidatorThree _valueValidatorThree;

		private readonly Mapping<TSource, TValue> _mapper;

		public Data<Option<TSource>> Data => new Data<Option<TSource>>(new NullableDataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TValueValidatorTwo, InvertValidator<TValueValidatorThree, TValue>, TSource, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne), _valueValidatorTwo, new InvertValidator<TValueValidatorThree, TValue>(_valueValidatorThree), _mapper));

		public NullableDataSourceInvertedStandardInverted(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree, Mapping<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
			_mapper = mapper;
		}

		public static implicit operator Data<Option<TSource>>(NullableDataSourceInvertedStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
