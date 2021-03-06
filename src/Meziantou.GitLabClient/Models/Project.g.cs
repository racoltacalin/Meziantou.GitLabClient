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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.GitLabObjectJsonConverterFactory))]
    public partial class Project : BasicProjectDetails
    {
        internal Project(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("approvals_before_merge")]
        public int? ApprovalsBeforeMerge
        {
            get
            {
                return this.GetValueOrDefault<int?>("approvals_before_merge", default(int?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("archived")]
        public bool Archived
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("archived");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("ci_config_path")]
        public string? CiConfigPath
        {
            get
            {
                return this.GetValueOrDefault<string?>("ci_config_path", default(string?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("container_registry_enabled")]
        public bool ContainerRegistryEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("container_registry_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("creator_id")]
        public long CreatorId
        {
            get
            {
                return this.GetRequiredNonNullValue<long>("creator_id");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("forked_from_project")]
        public BasicProjectDetails? ForkedFromProject
        {
            get
            {
                return this.GetValueOrDefault<BasicProjectDetails?>("forked_from_project", default(BasicProjectDetails?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("import_status")]
        public ProjectImportStatus ImportStatus
        {
            get
            {
                return this.GetRequiredNonNullValue<ProjectImportStatus>("import_status");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("issues_enabled")]
        public bool IssuesEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("issues_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("jobs_enabled")]
        public bool JobsEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("jobs_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("lfs_enabled")]
        public bool LfsEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("lfs_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("_links")]
        public ProjectLinks Links
        {
            get
            {
                return this.GetRequiredNonNullValue<ProjectLinks>("_links");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("merge_method")]
        public MergeMethod MergeMethod
        {
            get
            {
                return this.GetRequiredNonNullValue<MergeMethod>("merge_method");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("merge_requests_enabled")]
        public bool MergeRequestsEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("merge_requests_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("mirror")]
        public bool? Mirror
        {
            get
            {
                return this.GetValueOrDefault<bool?>("mirror", default(bool?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("mirror_overwrites_diverged_branches")]
        public bool? MirrorOverwritesDivergedBranches
        {
            get
            {
                return this.GetValueOrDefault<bool?>("mirror_overwrites_diverged_branches", default(bool?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("mirror_trigger_builds")]
        public bool? MirrorTriggerBuilds
        {
            get
            {
                return this.GetValueOrDefault<bool?>("mirror_trigger_builds", default(bool?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("mirror_user_id")]
        public long? MirrorUserId
        {
            get
            {
                return this.GetValueOrDefault<long?>("mirror_user_id", default(long?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("only_allow_merge_if_all_discussions_are_resolved")]
        public bool OnlyAllowMergeIfAllDiscussionsAreResolved
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("only_allow_merge_if_all_discussions_are_resolved");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("only_allow_merge_if_pipeline_succeeds")]
        public bool OnlyAllowMergeIfPipelineSucceeds
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("only_allow_merge_if_pipeline_succeeds");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("only_mirror_protected_branches")]
        public bool? OnlyMirrorProtectedBranches
        {
            get
            {
                return this.GetValueOrDefault<bool?>("only_mirror_protected_branches", default(bool?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("open_issues_count")]
        public int? OpenIssuesCount
        {
            get
            {
                return this.GetValueOrDefault<int?>("open_issues_count", default(int?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("owner")]
        public UserBasic? Owner
        {
            get
            {
                return this.GetValueOrDefault<UserBasic?>("owner", default(UserBasic?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("permissions")]
        public ProjectPermissions? Permissions
        {
            get
            {
                return this.GetValueOrDefault<ProjectPermissions?>("permissions", default(ProjectPermissions?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("printing_merge_request_link_enabled")]
        public bool PrintingMergeRequestLinkEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("printing_merge_request_link_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("public_jobs")]
        public bool PublicJobs
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("public_jobs");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("request_access_enabled")]
        public bool RequestAccessEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("request_access_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("resolve_outdated_diff_discussions")]
        public bool? ResolveOutdatedDiffDiscussions
        {
            get
            {
                return this.GetValueOrDefault<bool?>("resolve_outdated_diff_discussions", default(bool?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("runners_token")]
        public string? RunnersToken
        {
            get
            {
                return this.GetValueOrDefault<string?>("runners_token", default(string?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("shared_runners_enabled")]
        public bool SharedRunnersEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("shared_runners_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("shared_with_groups")]
        public System.Collections.Generic.IReadOnlyList<SharedGroup> SharedWithGroups
        {
            get
            {
                return this.GetRequiredNonNullValue<System.Collections.Generic.IReadOnlyList<SharedGroup>>("shared_with_groups");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("snippets_enabled")]
        public bool SnippetsEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("snippets_enabled");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("visibility")]
        public Visibility Visibility
        {
            get
            {
                return this.GetRequiredNonNullValue<Visibility>("visibility");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("wiki_enabled")]
        public bool WikiEnabled
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("wiki_enabled");
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Design", "MA0075:Do not use implicit culture-sensitive ToString", Justification = "Valid in ToString")]
        public override string ToString()
        {
            return (((((("Project { " + "Id = ") + this.Id) + ", ") + "PathWithNamespace = ") + this.PathWithNamespace) + " }");
        }
    }
}
