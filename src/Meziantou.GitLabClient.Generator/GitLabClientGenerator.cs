﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Meziantou.Framework;
using Meziantou.Framework.CodeDom;

namespace Meziantou.GitLabClient.Generator
{
    internal sealed partial class GitLabClientGenerator
    {
        private const string RootNamespace = "Meziantou.GitLab";
        private const string SerializationNamespace = "Meziantou.GitLab.Serialization";

        internal static class WellKnownTypes
        {
            public static TypeReference GitLabExceptionTypeReference { get; } = new TypeReference(RootNamespace + ".GitLabException");
            public static TypeReference UrlBuilderTypeReference { get; } = new TypeReference(RootNamespace + ".UrlBuilder");
            public static TypeReference PageOptionsTypeReference { get; } = new TypeReference(RootNamespace + ".PageOptions");
            public static TypeReference SkipUtcDateValidationAttributeTypeReference { get; } = new TypeReference(RootNamespace + ".SkipUtcDateValidationAttribute");
            public static TypeReference SkipAbsoluteUriValidationAttribute { get; } = new TypeReference(RootNamespace + ".SkipAbsoluteUriValidationAttribute");
            public static TypeReference MappedPropertyAttributeTypeReference { get; } = new TypeReference(RootNamespace + ".MappedPropertyAttribute");
            public static TypeReference IGitLabObjectReferenceTypeReference { get; } = new TypeReference(RootNamespace + ".IGitLabObjectReference");
            public static TypeReference GitLabObjectInt64ReferenceJsonConverterTypeReference { get; } = new TypeReference(SerializationNamespace + ".GitLabObjectInt64ReferenceJsonConverter");
            public static TypeReference GitLabObjectStringReferenceJsonConverterTypeReference { get; } = new TypeReference(SerializationNamespace + ".GitLabObjectStringReferenceJsonConverter");
            public static TypeReference GitLabObjectObjectReferenceJsonConverterTypeReference { get; } = new TypeReference(SerializationNamespace + ".GitLabObjectObjectReferenceJsonConverter");

            public static TypeReference ArgumentCollectionTypeReference { get; } = new TypeReference(typeof(IEnumerable<>));
            public static TypeReference PropertyCollectionTypeReference { get; } = new TypeReference(typeof(IReadOnlyList<>));
        }

        private readonly List<CompilationUnit> _units = new List<CompilationUnit>();

        public void Generate(FullPath rootDirectory)
        {
            var project = GitLabModels.GitLabModelBuilder.Create();
            GenerateCode(project);
            WriteFiles(rootDirectory);
        }

        private void WriteFiles(FullPath rootDirectory)
        {
            var existingFiles = Directory.GetFiles(rootDirectory, "*.g.cs", SearchOption.AllDirectories).Select(FullPath.FromPath).ToList();

            foreach (var unit in _units)
            {
                var relativePath = (string)unit.Data["FileName"];
                new DefaultFormatterVisitor().Visit(unit);
                var destinationFile = rootDirectory / relativePath;
                using var tw = new StreamWriter(destinationFile);
                new CSharpCodeGenerator().Write(tw, unit);

                existingFiles.Remove(destinationFile);
            }

            foreach (var file in existingFiles)
            {
                File.Delete(file);
            }
        }

        private CompilationUnit CreateUnit(string relativePath)
        {
            var extension = Path.GetExtension(relativePath);
            relativePath = Path.ChangeExtension(relativePath, ".g" + extension);

            var unit = new CompilationUnit
            {
                NullableContext = NullableContext.Enable,
            };
            unit.SetData("FileName", relativePath);

            unit.CommentsBefore.Add("------------------------------------------------------------------------------");
            unit.CommentsBefore.Add("<auto-generated>");
            unit.CommentsBefore.Add("    This code was generated by a tool.");
            unit.CommentsBefore.Add("");
            unit.CommentsBefore.Add("    Changes to this file may cause incorrect behavior and will be lost if");
            unit.CommentsBefore.Add("    the code is regenerated");
            unit.CommentsBefore.Add("</auto-generated>");
            unit.CommentsBefore.Add("------------------------------------------------------------------------------");

            _units.Add(unit);
            return unit;
        }

        private void GenerateCode(Project project)
        {
            GenerateEnumerations(project);
            GenerateEntities(project);
            GenerateParameterEntities(project);
            GenerateClients(project);
        }

        private static void AddDocumentationComments(CodeObject commentable, Documentation documentation)
        {
            if (documentation != null)
            {
                if (commentable is MethodArgumentDeclaration arg)
                {
                    var method = arg.GetSelfOrParentOfType<MethodDeclaration>();
                    if (documentation.Summary != null)
                    {
                        method.XmlComments.AddParam(arg.Name, documentation.Summary);
                    }
                }
                else if (commentable is IXmlCommentable xmlCommentable)
                {
                    if (documentation.Summary != null)
                    {
                        xmlCommentable.XmlComments.AddSummary(documentation.Summary);
                    }

                    if (documentation.Remark != null)
                    {
                        xmlCommentable.XmlComments.Add(new XElement("remark", documentation.Remark));
                    }

                    if (documentation.Returns != null)
                    {
                        xmlCommentable.XmlComments.AddReturn(documentation.Returns);
                    }

                    if (documentation.HelpLink != null)
                    {
                        xmlCommentable.XmlComments.Add(new XmlComment(new XElement("seealso", new XAttribute("href", documentation.HelpLink))));
                    }
                }
            }
        }

        //private static void GenerateExtensionMethod(ClassDeclaration extensionClass, Method method, MethodParameter methodParameter)
        //{
        //    foreach (var parameterEntityRef in methodParameter.Type.ParameterEntity.Refs.Where(r => r.ModelRef.IsModel))
        //    {
        //        var m = GenerateMethod(extensionClass, method);
        //        m.Modifiers |= Modifiers.Static;
        //        var extensionArgument = new MethodArgumentDeclaration(parameterEntityRef.ModelRef, ToArgumentName(parameterEntityRef.ModelRef.Model.Name)) { IsExtension = true };

        //        m.Statements.Clear();

        //        var invoke = new MethodInvokeExpression(new CastExpression(extensionArgument, new TypeReference("IGitLabObject")).CreateMemberReferenceExpression("GitLabClient", m.Name));

        //        foreach (var arg in m.Arguments.ToList())
        //        {
        //            if (arg.Data.TryGetValue("Parameter", out var parameter) && methodParameter == parameter)
        //            {
        //                m.Arguments.Remove(arg);
        //                invoke.Arguments.Add(extensionArgument);
        //            }
        //            else
        //            {
        //                invoke.Arguments.Add(arg);
        //            }
        //        }

        //        m.Statements.Add(new ReturnStatement(invoke));

        //        m.Name = m.Name.Replace(extensionClass.Name, "", StringComparison.OrdinalIgnoreCase);
        //        m.Arguments.Insert(0, extensionArgument);
        //    }
        //}

        //private static void GenerateFileExtensionMethod(ClassDeclaration classDeclaration, ClassDeclaration extensionClass)
        //{
        //    var methods = classDeclaration.Members
        //        .OfType<MethodDeclaration>()
        //        .Where(ContainsFileArgument)
        //        .ToList();

        //    foreach (var methodDeclaration in methods)
        //    {
        //        if (methodDeclaration.Data["Method"] is not Method method)
        //            continue;

        //        var m = GenerateMethod(extensionClass, method);
        //        m.Modifiers |= Modifiers.Static;

        //        Debug.Assert(m.Statements != null);
        //        m.Statements.Clear();

        //        var extensionArgument = new MethodArgumentDeclaration(new TypeReference("IGitLabClient"), "client") { IsExtension = true };

        //        var invoke = new MethodInvokeExpression(extensionArgument.CreateMemberReferenceExpression(methodDeclaration.Name!));

        //        foreach (var arg in m.Arguments.ToList())
        //        {
        //            if (arg.Name == "encoding")
        //            {
        //                invoke.Arguments.Add(new LiteralExpression("base64"));
        //                m.Arguments.Remove(arg);
        //            }
        //            else if (arg.Name == "content")
        //            {
        //                invoke.Arguments.Add(new TypeReferenceExpression(typeof(Convert)).CreateInvokeMethodExpression(nameof(Convert.ToBase64String), arg));
        //                arg.Type = typeof(byte[]);
        //            }
        //            else
        //            {
        //                invoke.Arguments.Add(arg);
        //            }
        //        }

        //        m.Statements.Add(new ReturnStatement(invoke));

        //        m.Name = m.Name.Replace(extensionClass.Name, "", StringComparison.OrdinalIgnoreCase);
        //        m.Arguments.Insert(0, extensionArgument);
        //    }

        //    static bool ContainsFileArgument(MethodDeclaration m)
        //    {
        //        return m.Arguments.Any(a => a.Name == "content" && a.Type.ClrFullTypeName == typeof(string).FullName) &&
        //               m.Arguments.Any(a => a.Name == "encoding" && a.Type.ClrFullTypeName == typeof(string).FullName);
        //    }
        //}

        private static string ToFieldName(string value)
        {
            var pascalCase = ToPropertyName(value);
            return "_" + char.ToLowerInvariant(pascalCase[0]) + pascalCase[1..];
        }

        private static string ToPropertyName(string value)
        {
            return value.Split(new[] { "_" }, StringSplitOptions.RemoveEmptyEntries)
             .Select(s => char.ToUpperInvariant(s[0]) + s[1..])
             .Aggregate(string.Empty, (s1, s2) => s1 + s2);
        }

        private static string ToArgumentName(string value)
        {
            var pascalCase = ToPropertyName(value);
            return char.ToLowerInvariant(pascalCase[0]) + pascalCase[1..];
        }

        private static ParameterLocation GetParameterLocation(Method method, MethodParameter parameter)
        {
            if (parameter.Location != ParameterLocation.Default)
            {
                return parameter.Location;
            }

            if (method.UrlTemplate.Contains($":{parameter.Name}/", StringComparison.Ordinal) || method.UrlTemplate.EndsWith($":{parameter.Name}", StringComparison.Ordinal))
                return ParameterLocation.Url;

            return method.MethodType switch
            {
                MethodType.Get => ParameterLocation.Url,
                MethodType.GetPaged => ParameterLocation.Url,
                MethodType.Put => ParameterLocation.Body,
                MethodType.Post => ParameterLocation.Body,
                MethodType.Delete => ParameterLocation.Body,
                _ => throw new ArgumentOutOfRangeException(nameof(method)),
            };
        }

        private static TypeReference GetPropertyTypeRef(ModelRef modelRef)
        {
            var typeRef = modelRef.ToPropertyTypeReference();
            return typeRef;
        }

        private static TypeReference GetArgumentTypeRef(MethodParameter param)
        {
            var typeRef = param.Type.ToArgumentTypeReference();

            if (!param.IsRequired)
            {
                typeRef = typeRef.MakeNullable();
            }

            return typeRef;
        }
    }
}
