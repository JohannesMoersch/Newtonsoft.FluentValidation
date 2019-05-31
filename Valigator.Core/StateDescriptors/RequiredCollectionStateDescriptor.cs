﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.StateDescriptors
{
	public class RequiredCollectionStateDescriptor : IStateDescriptor, IEquatable<RequiredCollectionStateDescriptor>
	{
		public bool Nullable { get; }

		public DataDescriptor ItemDescriptor { get; }

		public RequiredCollectionStateDescriptor(bool nullable, DataDescriptor itemDescriptor)
		{
			Nullable = nullable;
			ItemDescriptor = itemDescriptor;
		}

		public override bool Equals(object obj)
			=> Equals(obj as RequiredCollectionStateDescriptor);

		public bool Equals(RequiredCollectionStateDescriptor other)
			=> other != null && Nullable == other.Nullable && ItemDescriptor.Equals(other.ItemDescriptor);

		public bool Equals(IStateDescriptor other)
			=> other is RequiredCollectionStateDescriptor requiredCollectionStateDescriptor && Equals(requiredCollectionStateDescriptor);

		public override int GetHashCode()
		{
			var hashCode = -482873273;
			hashCode = hashCode * -1521134295 + Nullable.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<DataDescriptor>.Default.GetHashCode(ItemDescriptor);
			return hashCode;
		}
	}
}
