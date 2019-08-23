﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class DataContainer<TValue> : IDataContainer<TValue>, IAcceptValue<TValue, TValue>
	{
		public DataDescriptor DataDescriptor { get; }

		public Data<TValue> Verify(Data<TValue> data, object model, bool isSet, TValue value) 
			=> throw new NotImplementedException();

		public Data<TValue> WithValue(Data<TValue> data, Option<TValue> value) 
			=> throw new NotImplementedException();

		Option<ValidationError[]> IDataContainer<TValue>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
