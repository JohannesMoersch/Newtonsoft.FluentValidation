﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core.Descriptors;

namespace Valigator.Core
{
	public struct DataDescriptor
	{
		public Type PropertyType { get; }

		public IStateDescriptor StateDescriptor { get; }

		public IReadOnlyList<IValueDescriptor> ValueDescriptors { get; }

		public DataDescriptor(Type propertyType, IStateDescriptor stateDescriptor, IEnumerable<IValueDescriptor> valueDescriptors)
		{
			PropertyType = propertyType ?? throw new ArgumentNullException(nameof(propertyType));
			StateDescriptor = stateDescriptor ?? throw new ArgumentNullException(nameof(stateDescriptor));
			ValueDescriptors = (valueDescriptors ?? throw new ArgumentNullException(nameof(valueDescriptors))).ToArray();
		}
	}
}
