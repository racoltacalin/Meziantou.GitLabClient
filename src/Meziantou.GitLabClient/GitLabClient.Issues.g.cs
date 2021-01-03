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
    public partial interface IGitLabClient
    {
        Meziantou.GitLab.IGitLabIssuesClient Issues
        {
            get;
        }
    }

    public partial interface IGitLabIssuesClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:id/issues</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/issues.html#new-issue" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Issue> CreateAsync(Meziantou.GitLab.CreateIssueRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabIssuesClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:id/issues</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/issues.html#new-issue" />
        ///   </para>
        /// </summary>
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

        /// <summary>
        ///   <para>URL: <c>POST /projects/:id/issues</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/issues.html#new-issue" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private async System.Threading.Tasks.Task<Issue> Issues_CreateAsync(Meziantou.GitLab.CreateIssueRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url = Meziantou.GitLab.GitLabClient.Issues_CreateAsync_BuildUrl(request);
            using (System.Net.Http.HttpRequestMessage requestMessage = new System.Net.Http.HttpRequestMessage())
            {
                requestMessage.Method = System.Net.Http.HttpMethod.Post;
                requestMessage.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
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

                requestMessage.Content = new Meziantou.GitLab.Internals.JsonContent(body, Meziantou.GitLab.Serialization.JsonSerialization.Options);
                HttpResponse? response = null;
                try
                {
                    response = await this.SendAsync(requestMessage, requestOptions, cancellationToken).ConfigureAwait(false);
                    await response.EnsureStatusCodeAsync(cancellationToken).ConfigureAwait(false);
                    Issue? result = await response.ToObjectAsync<Issue>(cancellationToken).ConfigureAwait(false);
                    if ((result == null))
                    {
                        throw new Meziantou.GitLab.GitLabException(response.RequestMethod, response.RequestUri, response.StatusCode, "The response cannot be converted to 'Issue' because the body is null or empty");
                    }

                    return result;
                }
                finally
                {
                    if ((response != null))
                    {
                        response.Dispose();
                    }
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private static string Issues_CreateAsync_BuildUrl(Meziantou.GitLab.CreateIssueRequest request)
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("projects/");
                if (request.Id.HasValue)
                {
                    urlBuilder.AppendParameter(request.Id.GetValueOrDefault().ValueAsString);
                }

                urlBuilder.Append("/issues");
                url = urlBuilder.ToString();
            }

            return url;
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:id/issues</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/issues.html#new-issue" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<Issue> CreateAsync(this Meziantou.GitLab.IGitLabIssuesClient client, ProjectIdOrPathRef id, string title, string? description = default(string?), bool? confidential = default(bool?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.CreateIssueRequest request = new Meziantou.GitLab.CreateIssueRequest(id, title);
            request.Description = description;
            request.Confidential = confidential;
            return client.CreateAsync(request, requestOptions, cancellationToken);
        }
    }

    public partial class CreateIssueRequest
    {
        private bool? _confidential;

        private string? _description;

        private ProjectIdOrPathRef? _id;

        private string? _title;

        /// <param name="id">The ID or URL-encoded path of the project owned by the authenticated user</param>
        /// <param name="title">The title of an issue</param>
        public CreateIssueRequest(ProjectIdOrPathRef? id, string? title)
        {
            this._id = id;
            this._title = title;
        }

        public CreateIssueRequest()
        {
        }

        /// <summary>
        ///   <para>Set an issue to be confidential. Default is false.</para>
        /// </summary>
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

        /// <summary>
        ///   <para>The description of an issue. Limited to 1,048,576 characters.</para>
        /// </summary>
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

        /// <summary>
        ///   <para>The ID or URL-encoded path of the project owned by the authenticated user</para>
        /// </summary>
        public ProjectIdOrPathRef? Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        /// <summary>
        ///   <para>The title of an issue</para>
        /// </summary>
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
