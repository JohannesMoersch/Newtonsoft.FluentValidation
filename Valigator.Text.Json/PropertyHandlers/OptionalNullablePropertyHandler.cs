﻿using Functional;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Valigator.Text.Json.PropertyHandlers
{
	internal class OptionalNullablePropertyHandler<TObject, TValue> : ValigatorJsonPropertyHandler<TObject>
	{
		private readonly Func<TObject, Data<Optional<Option<TValue>>>> _getValue;
		private readonly Action<TObject, Data<Optional<Option<TValue>>>> _setValue;

		public string PropertyName { get; }

		public override bool CanRead => _getValue != null;
		public override bool CanWrite => _setValue != null;

		public OptionalNullablePropertyHandler(PropertyInfo property)
		{
			PropertyName = property.Name;
			_getValue = property.GetGetter<TObject, Optional<Option<TValue>>>();
			_setValue = property.GetSetter<TObject, Optional<Option<TValue>>>();
		}

		public override void ReadProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, TObject obj)
		{
			if (_getValue == null && _setValue == null)
				throw new NotSupportedException();

			var data = _getValue.Invoke(obj);

			if (reader.TokenType != JsonTokenType.Null && JsonSerializer.Deserialize<TValue>(ref reader, options) is TValue value)
				data = data.WithValue(value);
			else
				data = data.WithNull();

			_setValue.Invoke(obj, data);
		}

		public override void WriteProperty(Utf8JsonWriter writer, JsonSerializerOptions options, TObject obj)
		{
			if (_getValue != null)
			{
				if (_getValue.Invoke(obj).Value.TryGetValue(out var value))
				{
					writer.WritePropertyName(PropertyName);

					if (value.TryGetValue(out var some))
						JsonSerializer.Serialize(writer, some, options);
					else
						writer.WriteNullValue();
				}
			}
			else
				throw new NotSupportedException();
		}
	}
}
