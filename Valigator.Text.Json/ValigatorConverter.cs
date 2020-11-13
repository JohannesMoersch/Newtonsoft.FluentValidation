﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Valigator.Core;

namespace Valigator.Text.Json
{
	public class ValigatorConverter<TObject> : JsonConverter<TObject>
		where TObject : class
	{
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> CreatePropertyHandlers(TObject obj)
		{
			var result = new Dictionary<string, ValigatorJsonPropertyHandler<TObject>>();

			var properties = ValigatorModelBaseHelpers.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Concat(obj is ValigatorModelBase ? TypeDescriptor.GetProperties(obj).OfType<System.ComponentModel.PropertyDescriptor>().Select(property => ValigatorModelBaseHelpers.GetProperty(obj, property.Name)) : ValigatorModelBaseHelpers.GetProperties(obj, BindingFlags.Public | BindingFlags.Instance)).ToArray();

			foreach (var property in properties)
				result.Add(property.Name, ValigatorJsonPropertyHandler<TObject>.Create(property, obj));

			return result;
		}

		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> _propertyHandlers;
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> GetPropertyHandlers(TObject obj) => _propertyHandlers ??= CreatePropertyHandlers(obj);

		private readonly bool _useNewInstances;

		public ValigatorConverter(ValigatorModelConstructionBehaviour instanceConstructionBehaviour)
		{
			switch (instanceConstructionBehaviour)
			{
				case ValigatorModelConstructionBehaviour.NewInstance:
					_useNewInstances = true;
					break;
				case ValigatorModelConstructionBehaviour.CloneCached:
					_useNewInstances = false;
					break;
				default:
					throw new Exception();
			}
		}

		public override TObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var obj = GetObjectInstance();

			while (true)
			{
				if (!reader.Read())
					throw new Exception();

				if (reader.TokenType == JsonTokenType.EndObject)
					break;

				if (reader.TokenType != JsonTokenType.PropertyName)
					throw new Exception();

				var propertyName = reader.GetString();

				if (GetPropertyHandlers(obj).TryGetValue(propertyName, out var propertyHandler))
				{
					if (!reader.Read())
						throw new Exception();

					propertyHandler.ReadProperty(ref reader, options, obj);
				}
				else
					JsonSerializer.Deserialize(ref reader, typeof(object), options);
			}

			return obj;
		}

		private TObject GetObjectInstance()
			=> _useNewInstances
				? Model.CreateNew<TObject>()
				: Model.CreateClone<TObject>();

		public override void Write(Utf8JsonWriter writer, TObject value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			foreach (var handler in GetPropertyHandlers(value))
			{
				writer.WritePropertyName(handler.Key);

				handler.Value.WriteProperty(writer, options, value);
			}

			writer.WriteEndObject();
		}
	}
}
