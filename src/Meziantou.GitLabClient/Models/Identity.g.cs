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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.IdentityJsonConverter))]
    public partial class Identity : Meziantou.GitLab.Core.GitLabObject, System.IEquatable<Meziantou.GitLab.Identity>
    {
        internal Identity(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("extern_uid")]
        public string ExternUid
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("extern_uid");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("provider")]
        public string Provider
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("provider");
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals((obj as Meziantou.GitLab.Identity));
        }

        public virtual bool Equals(Meziantou.GitLab.Identity? other)
        {
            return (((!object.ReferenceEquals(other, null)) && (this.Provider == other.Provider)) && (this.ExternUid == other.ExternUid));
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(this.Provider, this.ExternUid);
        }

        public static bool operator !=(Meziantou.GitLab.Identity? a, Meziantou.GitLab.Identity? b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.Identity? a, Meziantou.GitLab.Identity? b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.Identity>.Default.Equals(a, b);
        }
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal sealed partial class IdentityJsonConverter : Meziantou.GitLab.Serialization.GitLabObjectBaseJsonConverter<Meziantou.GitLab.Identity>
    {
        protected override Meziantou.GitLab.Identity CreateInstance(System.Text.Json.JsonElement jsonElement)
        {
            return new Meziantou.GitLab.Identity(jsonElement);
        }
    }
}
