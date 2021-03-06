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
        Meziantou.GitLab.IGitLabSystemHooksClient SystemHooks
        {
            get;
        }
    }

    public partial interface IGitLabSystemHooksClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /hooks</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#add-new-system-hook" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<SystemHook> AddHookAsync(Meziantou.GitLab.AddHookSystemHookRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>DELETE /hooks/:id</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#delete-system-hook" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task DeleteAsync(Meziantou.GitLab.DeleteSystemHookRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>GET /hooks</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#list-system-hooks" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<SystemHook> GetSystemHooks(Meziantou.GitLab.GetSystemHooksRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabSystemHooksClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /hooks</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#add-new-system-hook" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<SystemHook> Meziantou.GitLab.IGitLabSystemHooksClient.AddHookAsync(Meziantou.GitLab.AddHookSystemHookRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.SystemHooks_AddHookAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /hooks/:id</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#delete-system-hook" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task Meziantou.GitLab.IGitLabSystemHooksClient.DeleteAsync(Meziantou.GitLab.DeleteSystemHookRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.SystemHooks_DeleteAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /hooks</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#list-system-hooks" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<SystemHook> Meziantou.GitLab.IGitLabSystemHooksClient.GetSystemHooks(Meziantou.GitLab.GetSystemHooksRequest request, Meziantou.GitLab.RequestOptions? requestOptions)
        {
            return this.SystemHooks_GetSystemHooks(request, requestOptions);
        }

        public Meziantou.GitLab.IGitLabSystemHooksClient SystemHooks
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        ///   <para>URL: <c>POST /hooks</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#add-new-system-hook" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private async System.Threading.Tasks.Task<SystemHook> SystemHooks_AddHookAsync(Meziantou.GitLab.AddHookSystemHookRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url = Meziantou.GitLab.GitLabClient.SystemHooks_AddHookAsync_BuildUrl();
            using (System.Net.Http.HttpRequestMessage requestMessage = new System.Net.Http.HttpRequestMessage())
            {
                requestMessage.Method = System.Net.Http.HttpMethod.Post;
                requestMessage.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
                requestMessage.Content = new Meziantou.GitLab.Internals.JsonContent(request, Meziantou.GitLab.Serialization.JsonSerialization.Options);
                HttpResponse? response = null;
                try
                {
                    response = await this.SendAsync(requestMessage, requestOptions, cancellationToken).ConfigureAwait(false);
                    await response.EnsureStatusCodeAsync(cancellationToken).ConfigureAwait(false);
                    SystemHook? result = await response.ToObjectAsync<SystemHook>(cancellationToken).ConfigureAwait(false);
                    if ((result == null))
                    {
                        throw new Meziantou.GitLab.GitLabException(response.RequestMethod, response.RequestUri, response.StatusCode, "The response cannot be converted to 'SystemHook' because the body is null or empty");
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

        private static string SystemHooks_AddHookAsync_BuildUrl()
        {
            string url;
            url = "hooks";
            return url;
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /hooks/:id</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#delete-system-hook" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private async System.Threading.Tasks.Task SystemHooks_DeleteAsync(Meziantou.GitLab.DeleteSystemHookRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url = Meziantou.GitLab.GitLabClient.SystemHooks_DeleteAsync_BuildUrl(request);
            using (System.Net.Http.HttpRequestMessage requestMessage = new System.Net.Http.HttpRequestMessage())
            {
                requestMessage.Method = System.Net.Http.HttpMethod.Delete;
                requestMessage.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
                HttpResponse? response = null;
                try
                {
                    response = await this.SendAsync(requestMessage, requestOptions, cancellationToken).ConfigureAwait(false);
                    await response.EnsureStatusCodeAsync(cancellationToken).ConfigureAwait(false);
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
        private static string SystemHooks_DeleteAsync_BuildUrl(Meziantou.GitLab.DeleteSystemHookRequest request)
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("hooks/");
                if (request.Id.HasValue)
                {
                    urlBuilder.AppendParameter(request.Id.GetValueOrDefault().Value);
                }

                url = urlBuilder.ToString();
            }

            return url;
        }

        /// <summary>
        ///   <para>URL: <c>GET /hooks</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#list-system-hooks" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        private Meziantou.GitLab.PagedResponse<SystemHook> SystemHooks_GetSystemHooks(Meziantou.GitLab.GetSystemHooksRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            string url = Meziantou.GitLab.GitLabClient.SystemHooks_GetSystemHooks_BuildUrl();
            return new Meziantou.GitLab.PagedResponse<SystemHook>(this, url, requestOptions);
        }

        private static string SystemHooks_GetSystemHooks_BuildUrl()
        {
            string url;
            url = "hooks";
            return url;
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <summary>
        ///   <para>URL: <c>POST /hooks</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#add-new-system-hook" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<SystemHook> AddHookAsync(this Meziantou.GitLab.IGitLabSystemHooksClient client, System.Uri url, string? token = default(string?), bool? pushEvents = default(bool?), bool? tagPushEvents = default(bool?), bool? mergeRequestsEvents = default(bool?), bool? repositoryUpdateEvents = default(bool?), bool? enableSslVerification = default(bool?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.AddHookSystemHookRequest request = new Meziantou.GitLab.AddHookSystemHookRequest(url);
            request.Token = token;
            request.PushEvents = pushEvents;
            request.TagPushEvents = tagPushEvents;
            request.MergeRequestsEvents = mergeRequestsEvents;
            request.RepositoryUpdateEvents = repositoryUpdateEvents;
            request.EnableSslVerification = enableSslVerification;
            return client.AddHookAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /hooks/:id</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#delete-system-hook" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task DeleteAsync(this Meziantou.GitLab.IGitLabSystemHooksClient client, SystemHookIdRef id, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.DeleteSystemHookRequest request = new Meziantou.GitLab.DeleteSystemHookRequest(id);
            return client.DeleteAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /hooks</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/system_hooks.html#list-system-hooks" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        public static Meziantou.GitLab.PagedResponse<SystemHook> GetSystemHooks(this Meziantou.GitLab.IGitLabSystemHooksClient client, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            Meziantou.GitLab.GetSystemHooksRequest request = new Meziantou.GitLab.GetSystemHooksRequest();
            return client.GetSystemHooks(request, requestOptions);
        }
    }

    public partial class AddHookSystemHookRequest
    {
        private bool? _enableSslVerification;

        private bool? _mergeRequestsEvents;

        private bool? _pushEvents;

        private bool? _repositoryUpdateEvents;

        private bool? _tagPushEvents;

        private string? _token;

        private System.Uri? _url;

        /// <param name="url">The hook URL</param>
        public AddHookSystemHookRequest(System.Uri? url)
        {
            this._url = url;
        }

        public AddHookSystemHookRequest()
        {
        }

        /// <summary>
        ///   <para>Do SSL verification when triggering the hook</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enable_ssl_verification")]
        [System.Text.Json.Serialization.JsonIgnoreAttribute(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableSslVerification
        {
            get
            {
                return this._enableSslVerification;
            }
            set
            {
                this._enableSslVerification = value;
            }
        }

        /// <summary>
        ///   <para>Trigger hook on merge requests events</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("merge_requests_events")]
        [System.Text.Json.Serialization.JsonIgnoreAttribute(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
        public bool? MergeRequestsEvents
        {
            get
            {
                return this._mergeRequestsEvents;
            }
            set
            {
                this._mergeRequestsEvents = value;
            }
        }

        /// <summary>
        ///   <para>When true, the hook fires on push events</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("push_events")]
        [System.Text.Json.Serialization.JsonIgnoreAttribute(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
        public bool? PushEvents
        {
            get
            {
                return this._pushEvents;
            }
            set
            {
                this._pushEvents = value;
            }
        }

        /// <summary>
        ///   <para>Trigger hook on repository update events</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("repository_update_events")]
        [System.Text.Json.Serialization.JsonIgnoreAttribute(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
        public bool? RepositoryUpdateEvents
        {
            get
            {
                return this._repositoryUpdateEvents;
            }
            set
            {
                this._repositoryUpdateEvents = value;
            }
        }

        /// <summary>
        ///   <para>When true, the hook fires on new tags being pushed</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tag_push_events")]
        [System.Text.Json.Serialization.JsonIgnoreAttribute(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
        public bool? TagPushEvents
        {
            get
            {
                return this._tagPushEvents;
            }
            set
            {
                this._tagPushEvents = value;
            }
        }

        /// <summary>
        ///   <para>Secret token to validate received payloads; this isn’t returned in the response</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("token")]
        [System.Text.Json.Serialization.JsonIgnoreAttribute(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
        public string? Token
        {
            get
            {
                return this._token;
            }
            set
            {
                this._token = value;
            }
        }

        /// <summary>
        ///   <para>The hook URL</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public System.Uri? Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = value;
            }
        }
    }

    public partial class GetSystemHooksRequest
    {
        public GetSystemHooksRequest()
        {
        }
    }

    public partial class DeleteSystemHookRequest
    {
        private SystemHookIdRef? _id;

        /// <param name="id">The ID of the hook</param>
        public DeleteSystemHookRequest(SystemHookIdRef? id)
        {
            this._id = id;
        }

        public DeleteSystemHookRequest()
        {
        }

        /// <summary>
        ///   <para>The ID of the hook</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnoreAttribute]
        public SystemHookIdRef? Id
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
    }
}
