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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.MergeRequestJsonConverter))]
    public partial class MergeRequest : Meziantou.GitLab.Core.GitLabObject, System.IEquatable<Meziantou.GitLab.MergeRequest>
    {
        internal MergeRequest(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("assignee")]
        public UserBasic? Assignee
        {
            get
            {
                return this.GetValueOrDefault<UserBasic?>("assignee", default(UserBasic?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("author")]
        public UserBasic Author
        {
            get
            {
                return this.GetRequiredNonNullValue<UserBasic>("author");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("created_at")]
        public System.DateTimeOffset CreatedAt
        {
            get
            {
                return this.GetRequiredNonNullValue<System.DateTimeOffset>("created_at");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("description")]
        public string? Description
        {
            get
            {
                return this.GetValueOrDefault<string?>("description", default(string?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("downvotes")]
        public int Downvotes
        {
            get
            {
                return this.GetRequiredNonNullValue<int>("downvotes");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("force_remove_source_branch")]
        public bool? ForceRemoveSourceBranch
        {
            get
            {
                return this.GetValueOrDefault<bool?>("force_remove_source_branch", default(bool?));
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

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("iid")]
        public long Iid
        {
            get
            {
                return this.GetRequiredNonNullValue<long>("iid");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("labels")]
        public System.Collections.Generic.IReadOnlyList<string> Labels
        {
            get
            {
                return this.GetRequiredNonNullValue<System.Collections.Generic.IReadOnlyList<string>>("labels");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("merge_commit_sha")]
        public Meziantou.GitLab.GitObjectId? MergeCommitSha
        {
            get
            {
                return this.GetValueOrDefault<Meziantou.GitLab.GitObjectId?>("merge_commit_sha", default(Meziantou.GitLab.GitObjectId?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("merge_status")]
        public MergeRequestStatus MergeStatus
        {
            get
            {
                return this.GetRequiredNonNullValue<MergeRequestStatus>("merge_status");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("merge_when_pipeline_succeeds")]
        public bool MergeWhenPipelineSucceeds
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("merge_when_pipeline_succeeds");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("project_id")]
        public long ProjectId
        {
            get
            {
                return this.GetRequiredNonNullValue<long>("project_id");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("sha")]
        public Meziantou.GitLab.GitObjectId Sha
        {
            get
            {
                return this.GetRequiredNonNullValue<Meziantou.GitLab.GitObjectId>("sha");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("should_remove_source_branch")]
        public bool? ShouldRemoveSourceBranch
        {
            get
            {
                return this.GetValueOrDefault<bool?>("should_remove_source_branch", default(bool?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("source_branch")]
        public string SourceBranch
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("source_branch");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("source_project_id")]
        public long SourceProjectId
        {
            get
            {
                return this.GetRequiredNonNullValue<long>("source_project_id");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("squash")]
        public bool Squash
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("squash");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("state")]
        public MergeRequestState State
        {
            get
            {
                return this.GetRequiredNonNullValue<MergeRequestState>("state");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("target_branch")]
        public string TargetBranch
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("target_branch");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("target_project_id")]
        public long TargetProjectId
        {
            get
            {
                return this.GetRequiredNonNullValue<long>("target_project_id");
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

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("updated_at")]
        public System.DateTimeOffset UpdatedAt
        {
            get
            {
                return this.GetRequiredNonNullValue<System.DateTimeOffset>("updated_at");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("upvotes")]
        public int Upvotes
        {
            get
            {
                return this.GetRequiredNonNullValue<int>("upvotes");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("user_notes_count")]
        public int UserNotesCount
        {
            get
            {
                return this.GetRequiredNonNullValue<int>("user_notes_count");
            }
        }

        /// <remarks>The value is an absolute URI</remarks>
        [Meziantou.GitLab.Internals.MappedPropertyAttribute("web_url")]
        public System.Uri WebUrl
        {
            get
            {
                return this.GetRequiredNonNullValue<System.Uri>("web_url");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("work_in_progress")]
        public bool WorkInProgress
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("work_in_progress");
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals((obj as Meziantou.GitLab.MergeRequest));
        }

        public virtual bool Equals(Meziantou.GitLab.MergeRequest? other)
        {
            return ((!object.ReferenceEquals(other, null)) && (this.Id == other.Id));
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(this.Id);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Design", "MA0075:Do not use implicit culture-sensitive ToString", Justification = "Valid in ToString")]
        public override string ToString()
        {
            return (((((("MergeRequest { " + "Id = ") + this.Id) + ", ") + "Title = ") + this.Title) + " }");
        }

        public static bool operator !=(Meziantou.GitLab.MergeRequest? a, Meziantou.GitLab.MergeRequest? b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.MergeRequest? a, Meziantou.GitLab.MergeRequest? b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.MergeRequest>.Default.Equals(a, b);
        }
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal sealed partial class MergeRequestJsonConverter : Meziantou.GitLab.Serialization.GitLabObjectBaseJsonConverter<Meziantou.GitLab.MergeRequest>
    {
        protected override Meziantou.GitLab.MergeRequest CreateInstance(System.Text.Json.JsonElement jsonElement)
        {
            return new Meziantou.GitLab.MergeRequest(jsonElement);
        }
    }
}
