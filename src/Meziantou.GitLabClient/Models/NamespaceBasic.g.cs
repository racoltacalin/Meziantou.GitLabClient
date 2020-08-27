// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
#nullable enable
namespace Meziantou.GitLab
{
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.NamespaceBasicJsonConverter))]
    [System.Diagnostics.DebuggerDisplayAttribute("{GetType().Name,nq} FullPath={FullPath}, Id={Id}")]
    public partial class NamespaceBasic : Meziantou.GitLab.Core.GitLabObject, System.IEquatable<Meziantou.GitLab.NamespaceBasic>
    {
        internal NamespaceBasic(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("full_path")]
        public string FullPath
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("full_path");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("id")]
        public long Id
        {
            get
            {
                return this.GetRequiredNonNullValue<long>("id");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("kind")]
        public string Kind
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("kind");
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

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("parent_id")]
        public long? ParentId
        {
            get
            {
                return this.GetValueOrDefault<long?>("parent_id", default(long?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("path")]
        public string Path
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("path");
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals((obj as Meziantou.GitLab.NamespaceBasic));
        }

        public virtual bool Equals(Meziantou.GitLab.NamespaceBasic? obj)
        {
            return ((!object.ReferenceEquals(obj, null)) && (this.Id == obj.Id));
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(this.Id);
        }

        public static bool operator !=(Meziantou.GitLab.NamespaceBasic? a, Meziantou.GitLab.NamespaceBasic? b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.NamespaceBasic? a, Meziantou.GitLab.NamespaceBasic? b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.NamespaceBasic>.Default.Equals(a, b);
        }
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal sealed partial class NamespaceBasicJsonConverter : Meziantou.GitLab.Serialization.GitLabObjectBaseJsonConverter<Meziantou.GitLab.NamespaceBasic>
    {
        protected override Meziantou.GitLab.NamespaceBasic CreateInstance(System.Text.Json.JsonElement jsonElement)
        {
            return new Meziantou.GitLab.NamespaceBasic(jsonElement);
        }
    }
}
