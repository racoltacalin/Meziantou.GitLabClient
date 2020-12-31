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
        Meziantou.GitLab.IGitLabWikisClient Wikis
        {
            get;
        }
    }

    public partial interface IGitLabWikisClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:project_id/wikis</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#create-a-new-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<WikiPage> CreateWikiPageAsync(Meziantou.GitLab.CreateWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>DELETE /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#delete-a-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task DeleteWikiPageAsync(Meziantou.GitLab.DeleteWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>GET /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#get-a-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<WikiPage?> GetWikiPageAsync(Meziantou.GitLab.GetWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>GET /projects/:project_id/wikis</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#list-wiki-pages" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<WikiPage>> GetWikiPagesAsync(Meziantou.GitLab.GetWikiPagesRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>PUT /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#edit-an-existing-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<WikiPage> UpdateWikiPageAsync(Meziantou.GitLab.UpdateWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabWikisClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:project_id/wikis</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#create-a-new-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<WikiPage> Meziantou.GitLab.IGitLabWikisClient.CreateWikiPageAsync(Meziantou.GitLab.CreateWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Wikis_CreateWikiPageAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#delete-a-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task Meziantou.GitLab.IGitLabWikisClient.DeleteWikiPageAsync(Meziantou.GitLab.DeleteWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Wikis_DeleteWikiPageAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#get-a-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<WikiPage?> Meziantou.GitLab.IGitLabWikisClient.GetWikiPageAsync(Meziantou.GitLab.GetWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Wikis_GetWikiPageAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /projects/:project_id/wikis</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#list-wiki-pages" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<WikiPage>> Meziantou.GitLab.IGitLabWikisClient.GetWikiPagesAsync(Meziantou.GitLab.GetWikiPagesRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Wikis_GetWikiPagesAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>PUT /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#edit-an-existing-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<WikiPage> Meziantou.GitLab.IGitLabWikisClient.UpdateWikiPageAsync(Meziantou.GitLab.UpdateWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Wikis_UpdateWikiPageAsync(request, requestOptions, cancellationToken);
        }

        public Meziantou.GitLab.IGitLabWikisClient Wikis
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        ///   <para>URL: <c>POST /projects/:project_id/wikis</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#create-a-new-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task<WikiPage> Wikis_CreateWikiPageAsync(Meziantou.GitLab.CreateWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("projects/");
                if (request.ProjectId.HasValue)
                {
                    urlBuilder.AppendParameter(request.ProjectId.GetValueOrDefault().ValueAsString);
                }

                urlBuilder.Append("/wikis");
                url = urlBuilder.ToString();
            }

            System.Collections.Generic.Dictionary<string, object> body = new System.Collections.Generic.Dictionary<string, object>();
            if ((request.Title != null))
            {
                body.Add("title", request.Title);
            }

            if ((request.Content != null))
            {
                body.Add("content", request.Content);
            }

            if ((request.Format != null))
            {
                body.Add("format", request.Format);
            }

            return this.PostJsonAsync<WikiPage>(url, body, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#delete-a-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task Wikis_DeleteWikiPageAsync(Meziantou.GitLab.DeleteWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("projects/");
                if (request.ProjectId.HasValue)
                {
                    urlBuilder.AppendParameter(request.ProjectId.GetValueOrDefault().ValueAsString);
                }

                urlBuilder.Append("/wikis/");
                if ((!object.ReferenceEquals(request.Slug, null)))
                {
                    urlBuilder.AppendParameter(request.Slug);
                }

                url = urlBuilder.ToString();
            }

            return this.DeleteAsync(url, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#get-a-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task<WikiPage?> Wikis_GetWikiPageAsync(Meziantou.GitLab.GetWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("projects/");
                if (request.ProjectId.HasValue)
                {
                    urlBuilder.AppendParameter(request.ProjectId.GetValueOrDefault().ValueAsString);
                }

                urlBuilder.Append("/wikis/");
                if ((!object.ReferenceEquals(request.Slug, null)))
                {
                    urlBuilder.AppendParameter(request.Slug);
                }

                url = urlBuilder.ToString();
            }

            return this.GetAsync<WikiPage>(url, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /projects/:project_id/wikis</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#list-wiki-pages" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<WikiPage>> Wikis_GetWikiPagesAsync(Meziantou.GitLab.GetWikiPagesRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("projects/");
                if (request.ProjectId.HasValue)
                {
                    urlBuilder.AppendParameter(request.ProjectId.GetValueOrDefault().ValueAsString);
                }

                urlBuilder.Append("/wikis");
                url = urlBuilder.ToString();
            }

            return this.GetCollectionAsync<WikiPage>(url, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>PUT /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#edit-an-existing-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task<WikiPage> Wikis_UpdateWikiPageAsync(Meziantou.GitLab.UpdateWikiPageRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("projects/");
                if (request.ProjectId.HasValue)
                {
                    urlBuilder.AppendParameter(request.ProjectId.GetValueOrDefault().ValueAsString);
                }

                urlBuilder.Append("/wikis/");
                if ((!object.ReferenceEquals(request.Slug, null)))
                {
                    urlBuilder.AppendParameter(request.Slug);
                }

                url = urlBuilder.ToString();
            }

            System.Collections.Generic.Dictionary<string, object> body = new System.Collections.Generic.Dictionary<string, object>();
            if ((request.Title != null))
            {
                body.Add("title", request.Title);
            }

            if ((request.Content != null))
            {
                body.Add("content", request.Content);
            }

            if ((request.Format != null))
            {
                body.Add("format", request.Format);
            }

            return this.PutJsonAsync<WikiPage>(url, body, requestOptions, cancellationToken);
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:project_id/wikis</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#create-a-new-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<WikiPage> CreateWikiPageAsync(this Meziantou.GitLab.IGitLabWikisClient client, ProjectIdOrPathRef projectId, string title, string content, WikiPageFormat? format = default(WikiPageFormat?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.CreateWikiPageRequest request = new Meziantou.GitLab.CreateWikiPageRequest(projectId, title, content);
            request.Format = format;
            return client.CreateWikiPageAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#delete-a-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task DeleteWikiPageAsync(this Meziantou.GitLab.IGitLabWikisClient client, ProjectIdOrPathRef projectId, string slug, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.DeleteWikiPageRequest request = new Meziantou.GitLab.DeleteWikiPageRequest(projectId, slug);
            return client.DeleteWikiPageAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#get-a-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<WikiPage?> GetWikiPageAsync(this Meziantou.GitLab.IGitLabWikisClient client, ProjectIdOrPathRef projectId, string slug, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.GetWikiPageRequest request = new Meziantou.GitLab.GetWikiPageRequest(projectId, slug);
            return client.GetWikiPageAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /projects/:project_id/wikis</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#list-wiki-pages" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<WikiPage>> GetWikiPagesAsync(this Meziantou.GitLab.IGitLabWikisClient client, ProjectIdOrPathRef projectId, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.GetWikiPagesRequest request = new Meziantou.GitLab.GetWikiPagesRequest(projectId);
            return client.GetWikiPagesAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>PUT /projects/:project_id/wikis/:slug</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/wikis.html#edit-an-existing-wiki-page" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<WikiPage> UpdateWikiPageAsync(this Meziantou.GitLab.IGitLabWikisClient client, ProjectIdOrPathRef projectId, string slug, string? title = default(string?), string? content = default(string?), WikiPageFormat? format = default(WikiPageFormat?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.UpdateWikiPageRequest request = new Meziantou.GitLab.UpdateWikiPageRequest(projectId, slug);
            request.Title = title;
            request.Content = content;
            request.Format = format;
            return client.UpdateWikiPageAsync(request, requestOptions, cancellationToken);
        }
    }

    public partial class GetWikiPagesRequest
    {
        private ProjectIdOrPathRef? _projectId;

        public GetWikiPagesRequest(ProjectIdOrPathRef? projectId)
        {
            this._projectId = projectId;
        }

        public GetWikiPagesRequest()
        {
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
    }

    public partial class GetWikiPageRequest
    {
        private ProjectIdOrPathRef? _projectId;

        private string? _slug;

        public GetWikiPageRequest(ProjectIdOrPathRef? projectId, string? slug)
        {
            this._projectId = projectId;
            this._slug = slug;
        }

        public GetWikiPageRequest()
        {
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

        public string? Slug
        {
            get
            {
                return this._slug;
            }
            set
            {
                this._slug = value;
            }
        }
    }

    public partial class CreateWikiPageRequest
    {
        private string? _content;

        private WikiPageFormat? _format;

        private ProjectIdOrPathRef? _projectId;

        private string? _title;

        public CreateWikiPageRequest(ProjectIdOrPathRef? projectId, string? title, string? content)
        {
            this._projectId = projectId;
            this._title = title;
            this._content = content;
        }

        public CreateWikiPageRequest()
        {
        }

        public string? Content
        {
            get
            {
                return this._content;
            }
            set
            {
                this._content = value;
            }
        }

        public WikiPageFormat? Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
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

    public partial class UpdateWikiPageRequest
    {
        private string? _content;

        private WikiPageFormat? _format;

        private ProjectIdOrPathRef? _projectId;

        private string? _slug;

        private string? _title;

        public UpdateWikiPageRequest(ProjectIdOrPathRef? projectId, string? slug)
        {
            this._projectId = projectId;
            this._slug = slug;
        }

        public UpdateWikiPageRequest()
        {
        }

        public string? Content
        {
            get
            {
                return this._content;
            }
            set
            {
                this._content = value;
            }
        }

        public WikiPageFormat? Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
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

        public string? Slug
        {
            get
            {
                return this._slug;
            }
            set
            {
                this._slug = value;
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

    public partial class DeleteWikiPageRequest
    {
        private ProjectIdOrPathRef? _projectId;

        private string? _slug;

        public DeleteWikiPageRequest(ProjectIdOrPathRef? projectId, string? slug)
        {
            this._projectId = projectId;
            this._slug = slug;
        }

        public DeleteWikiPageRequest()
        {
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

        public string? Slug
        {
            get
            {
                return this._slug;
            }
            set
            {
                this._slug = value;
            }
        }
    }
}
