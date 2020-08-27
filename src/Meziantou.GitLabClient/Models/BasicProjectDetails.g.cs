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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.BasicProjectDetailsJsonConverter))]
    public partial class BasicProjectDetails : ProjectIdentity
    {
        internal BasicProjectDetails(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("avatar_url")]
        public System.Uri? AvatarUrl
        {
            get
            {
                return this.GetValueOrDefault<System.Uri?>("avatar_url", default(System.Uri?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("default_branch")]
        public string? DefaultBranch
        {
            get
            {
                return this.GetValueOrDefault<string?>("default_branch", default(string?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("forks_count")]
        public int ForksCount
        {
            get
            {
                return this.GetRequiredNonNullValue<int>("forks_count");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("http_url_to_repo")]
        public System.Uri HttpUrlToRepo
        {
            get
            {
                return this.GetRequiredNonNullValue<System.Uri>("http_url_to_repo");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("last_activity_at")]
        public System.DateTimeOffset LastActivityAt
        {
            get
            {
                return this.GetRequiredNonNullValue<System.DateTimeOffset>("last_activity_at");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("namespace")]
        public NamespaceBasic Namespace
        {
            get
            {
                return this.GetRequiredNonNullValue<NamespaceBasic>("namespace");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("readme_url")]
        public System.Uri? ReadmeUrl
        {
            get
            {
                return this.GetValueOrDefault<System.Uri?>("readme_url", default(System.Uri?));
            }
        }

        [Meziantou.GitLab.Internals.SkipAbsoluteUriValidationAttribute]
        [Meziantou.GitLab.Internals.MappedPropertyAttribute("ssh_url_to_repo")]
        public System.Uri? SshUrlToRepo
        {
            get
            {
                return this.GetValueOrDefault<System.Uri?>("ssh_url_to_repo", default(System.Uri?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("star_count")]
        public int StarCount
        {
            get
            {
                return this.GetRequiredNonNullValue<int>("star_count");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("tag_list")]
        public System.Collections.Generic.IReadOnlyList<string> TagList
        {
            get
            {
                return this.GetRequiredNonNullValue<System.Collections.Generic.IReadOnlyList<string>>("tag_list");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("web_url")]
        public System.Uri? WebUrl
        {
            get
            {
                return this.GetValueOrDefault<System.Uri?>("web_url", default(System.Uri?));
            }
        }
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal sealed partial class BasicProjectDetailsJsonConverter : Meziantou.GitLab.Serialization.GitLabObjectBaseJsonConverter<Meziantou.GitLab.BasicProjectDetails>
    {
        protected override Meziantou.GitLab.BasicProjectDetails CreateInstance(System.Text.Json.JsonElement jsonElement)
        {
            return new Meziantou.GitLab.BasicProjectDetails(jsonElement);
        }
    }
}
