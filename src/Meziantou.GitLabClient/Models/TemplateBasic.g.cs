﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
#nullable enable
namespace Meziantou.GitLab
{
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.TemplateBasicJsonConverter))]
    [System.Diagnostics.DebuggerDisplayAttribute("{GetType().Name,nq} Name={Name}, Key={Key}")]
    public partial class TemplateBasic : Meziantou.GitLab.Core.GitLabObject, System.IEquatable<Meziantou.GitLab.TemplateBasic>
    {
        internal TemplateBasic(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("key")]
        public string Key
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("key");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("name")]
        public string Name
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("name");
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals((obj as Meziantou.GitLab.TemplateBasic));
        }

        public virtual bool Equals(Meziantou.GitLab.TemplateBasic? other)
        {
            return ((!object.ReferenceEquals(other, null)) && (this.Key == other.Key));
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(this.Key);
        }

        public static bool operator !=(Meziantou.GitLab.TemplateBasic? a, Meziantou.GitLab.TemplateBasic? b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.TemplateBasic? a, Meziantou.GitLab.TemplateBasic? b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.TemplateBasic>.Default.Equals(a, b);
        }
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal sealed partial class TemplateBasicJsonConverter : Meziantou.GitLab.Serialization.GitLabObjectBaseJsonConverter<Meziantou.GitLab.TemplateBasic>
    {
        protected override Meziantou.GitLab.TemplateBasic CreateInstance(System.Text.Json.JsonElement jsonElement)
        {
            return new Meziantou.GitLab.TemplateBasic(jsonElement);
        }
    }
}
