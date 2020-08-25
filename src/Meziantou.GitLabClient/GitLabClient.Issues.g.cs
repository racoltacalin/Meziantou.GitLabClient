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
    public partial interface IGitLabClient
    {
        Meziantou.GitLab.IGitLabIssuesClient Issues
        {
            get;
        }
    }

    public partial interface IGitLabIssuesClient
    {
        /// <seealso href="https://docs.gitlab.com/ee/api/issues.html#new-issue" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Issue> CreateAsync(Meziantou.GitLab.CreateIssueRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabIssuesClient
    {
        /// <seealso href="https://docs.gitlab.com/ee/api/issues.html#new-issue" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Issue> Meziantou.GitLab.IGitLabIssuesClient.CreateAsync(Meziantou.GitLab.CreateIssueRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Issues_CreateAsync(request, requestOptions, cancellationToken);
        }

        public Meziantou.GitLab.IGitLabIssuesClient Issues
        {
            get
            {
                return this;
            }
        }

        /// <seealso href="https://docs.gitlab.com/ee/api/issues.html#new-issue" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private System.Threading.Tasks.Task<Issue> Issues_CreateAsync(Meziantou.GitLab.CreateIssueRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.UrlBuilder urlBuilder = Meziantou.GitLab.UrlBuilder.Get("projects/:project_id/issues");
            if (request.ProjectId.HasValue)
            {
                urlBuilder.SetValue("project_id", request.ProjectId.Value.ValueAsString);
            }

            string url = urlBuilder.Build();
            System.Collections.Generic.Dictionary<string, object> body = new System.Collections.Generic.Dictionary<string, object>();
            if ((request.Title != null))
            {
                body.Add("title", request.Title);
            }

            if ((request.Description != null))
            {
                body.Add("description", request.Description);
            }

            if ((request.Confidential != null))
            {
                body.Add("confidential", request.Confidential);
            }

            return this.PostJsonAsync<Issue>(url, body, requestOptions, cancellationToken);
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <seealso href="https://docs.gitlab.com/ee/api/issues.html#new-issue" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<Issue> CreateAsync(this Meziantou.GitLab.IGitLabIssuesClient client, ProjectIdOrPathRef projectId, string title, string? description = default(string?), bool? confidential = default(bool?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.CreateIssueRequest request = new Meziantou.GitLab.CreateIssueRequest(projectId, title);
            request.Description = description;
            request.Confidential = confidential;
            return client.CreateAsync(request, requestOptions, cancellationToken);
        }
    }

    public partial class CreateIssueRequest
    {
        private bool? _confidential;

        private string? _description;

        private ProjectIdOrPathRef? _projectId;

        private string? _title;

        public CreateIssueRequest(ProjectIdOrPathRef? projectId, string? title)
        {
            this._projectId = projectId;
            this._title = title;
        }

        public CreateIssueRequest()
        {
        }

        public bool? Confidential
        {
            get
            {
                return this._confidential;
            }
            set
            {
                this._confidential = value;
            }
        }

        public string? Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public ProjectIdOrPathRef? ProjectId
        {
            get
            {
                return this._projectId;
            }
            set
            {
                this._projectId = value;
            }
        }

        public string? Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
    }
}
