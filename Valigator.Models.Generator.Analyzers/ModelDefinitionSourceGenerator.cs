﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Valigator
{
	[Generator]
	public sealed class ModelDefinitionSourceGenerator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context)
			=> context.RegisterForSyntaxNotifications(() => new ModelDefinitionSyntaxReceiver());

		public void Execute(GeneratorExecutionContext context)
		{
			if (context.SyntaxReceiver is ModelDefinitionSyntaxReceiver receiver)
			{
				var generatedModelAttributeType = context
					.Compilation
					.GetTypeByMetadataName(TypeNames.GenerateModelAttribute);

				foreach (var candidate in receiver.Candidates)
				{
					var typeSymbol = context
						.Compilation
						.GetSemanticModel(candidate.SyntaxTree)
						.GetDeclaredSymbol(candidate);

					if (typeSymbol != null && typeSymbol.HasAttribute(generatedModelAttributeType) && candidate.IsPartial())
					{
						var modelNamespace = typeSymbol.GetFullContainingNamespace();
						var modelName = typeSymbol.Name.Replace("Definition", String.Empty);

						System.IO.File.WriteAllText($"C:\\Users\\johan\\Desktop\\{typeSymbol.Name}.cs", GenerateDefinition(typeSymbol, modelNamespace, modelName));
						System.IO.File.WriteAllText($"C:\\Users\\johan\\Desktop\\{modelName}.cs", GenerateModel(typeSymbol, modelNamespace, modelName));

						context.AddSource($"a{typeSymbol.Name}.cs", GenerateDefinition(typeSymbol, modelNamespace, modelName));
						context.AddSource($"a{modelName}.cs", GenerateModel(typeSymbol, modelNamespace, modelName));
					}
				}
			}
		}

		private string GenerateDefinition(ITypeSymbol definitionType, string modelNamespace, string modelName)
		{
			var definitionNamespace = definitionType.GetFullContainingNamespace();
			var modelNamespaceToUse = definitionNamespace == modelNamespace
				? String.Empty
				: $"{modelNamespace}.";

			StringBuilder builder = new StringBuilder();

			builder.AppendLine($"using Valigator;");
			builder.AppendLine($"");
			builder.AppendLine($"namespace {definitionNamespace}");
			builder.AppendLine($"{{");
			builder.AppendLine($"	public partial class {definitionType.Name} : ModelDefinition<{modelNamespaceToUse}{modelName}.ModelView>");
			builder.AppendLine($"	{{");
			builder.AppendLine($"	}}");
			builder.AppendLine($"}}");

			return builder.ToString();
		}

		private string GenerateModel(ITypeSymbol definitionType, string modelNamespace, string modelName)
		{
			StringBuilder builder = new StringBuilder();

			builder.AppendLine($"namespace {modelNamespace}");
			builder.AppendLine($"{{");
			builder.AppendLine($"	public partial class {modelName}");
			builder.AppendLine($"	{{");
			builder.AppendLine($"		public sealed class ModelView");
			builder.AppendLine($"		{{");
			builder.AppendLine($"		}}");
			builder.AppendLine($"	}}");
			builder.AppendLine($"}}");

			return builder.ToString();
		}
	}
}
