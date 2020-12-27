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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.WikiPageJsonConverter))]
    public partial class WikiPage : Meziantou.GitLab.Core.GitLabObject, System.IEquatable<Meziantou.GitLab.WikiPage>
    {
        internal WikiPage(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("content")]
        public string? Content
        {
            get
            {
                return this.GetValueOrDefault<string?>("content", default(string?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("format")]
        public WikiPageFormat Format
        {
            get
            {
                return this.GetRequiredNonNullValue<WikiPageFormat>("format");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("slug")]
        public string Slug
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("slug");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("title")]
        public string Title
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("title");
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals((obj as Meziantou.GitLab.WikiPage));
        }

        public virtual bool Equals(Meziantou.GitLab.WikiPage? other)
        {
            return ((!object.ReferenceEquals(other, null)) && (this.Slug == other.Slug));
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(this.Slug);
        }

        public static bool operator !=(Meziantou.GitLab.WikiPage? a, Meziantou.GitLab.WikiPage? b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.WikiPage? a, Meziantou.GitLab.WikiPage? b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.WikiPage>.Default.Equals(a, b);
        }
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal sealed partial class WikiPageJsonConverter : Meziantou.GitLab.Serialization.GitLabObjectBaseJsonConverter<Meziantou.GitLab.WikiPage>
    {
        protected override Meziantou.GitLab.WikiPage CreateInstance(System.Text.Json.JsonElement jsonElement)
        {
            return new Meziantou.GitLab.WikiPage(jsonElement);
        }
    }
}
