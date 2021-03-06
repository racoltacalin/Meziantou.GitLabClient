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
        Meziantou.GitLab.IGitLabLicenseClient License
        {
            get;
        }
    }

    public partial interface IGitLabLicenseClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /license</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#add-a-new-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<License> AddLicenseAsync(Meziantou.GitLab.AddLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>DELETE /license/:id</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#delete-a-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task DeleteLicenseAsync(Meziantou.GitLab.DeleteLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>GET /license</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#retrieve-information-about-the-current-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<License?> GetCurrentLicenseAsync(Meziantou.GitLab.GetCurrentLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>URL: <c>GET /licenses</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#retrieve-information-about-all-licenses" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<License> GetLicenses(Meziantou.GitLab.GetLicensesRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabLicenseClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /license</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#add-a-new-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<License> Meziantou.GitLab.IGitLabLicenseClient.AddLicenseAsync(Meziantou.GitLab.AddLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.License_AddLicenseAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /license/:id</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#delete-a-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task Meziantou.GitLab.IGitLabLicenseClient.DeleteLicenseAsync(Meziantou.GitLab.DeleteLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.License_DeleteLicenseAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /license</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#retrieve-information-about-the-current-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<License?> Meziantou.GitLab.IGitLabLicenseClient.GetCurrentLicenseAsync(Meziantou.GitLab.GetCurrentLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.License_GetCurrentLicenseAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /licenses</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#retrieve-information-about-all-licenses" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<License> Meziantou.GitLab.IGitLabLicenseClient.GetLicenses(Meziantou.GitLab.GetLicensesRequest request, Meziantou.GitLab.RequestOptions? requestOptions)
        {
            return this.License_GetLicenses(request, requestOptions);
        }

        public Meziantou.GitLab.IGitLabLicenseClient License
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        ///   <para>URL: <c>POST /license</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#add-a-new-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private async System.Threading.Tasks.Task<License> License_AddLicenseAsync(Meziantou.GitLab.AddLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url = Meziantou.GitLab.GitLabClient.License_AddLicenseAsync_BuildUrl(request);
            using (System.Net.Http.HttpRequestMessage requestMessage = new System.Net.Http.HttpRequestMessage())
            {
                requestMessage.Method = System.Net.Http.HttpMethod.Post;
                requestMessage.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
                HttpResponse? response = null;
                try
                {
                    response = await this.SendAsync(requestMessage, requestOptions, cancellationToken).ConfigureAwait(false);
                    await response.EnsureStatusCodeAsync(cancellationToken).ConfigureAwait(false);
                    License? result = await response.ToObjectAsync<License>(cancellationToken).ConfigureAwait(false);
                    if ((result == null))
                    {
                        throw new Meziantou.GitLab.GitLabException(response.RequestMethod, response.RequestUri, response.StatusCode, "The response cannot be converted to 'License' because the body is null or empty");
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
        private static string License_AddLicenseAsync_BuildUrl(Meziantou.GitLab.AddLicenseRequest request)
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("license");
                char separator = '?';
                if ((!object.ReferenceEquals(request.License, null)))
                {
                    urlBuilder.Append(separator);
                    separator = '&';
                    urlBuilder.Append("license=");
                    urlBuilder.AppendParameter(request.License);
                }

                url = urlBuilder.ToString();
            }

            return url;
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /license/:id</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#delete-a-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private async System.Threading.Tasks.Task License_DeleteLicenseAsync(Meziantou.GitLab.DeleteLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url = Meziantou.GitLab.GitLabClient.License_DeleteLicenseAsync_BuildUrl(request);
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
        private static string License_DeleteLicenseAsync_BuildUrl(Meziantou.GitLab.DeleteLicenseRequest request)
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("license/");
                if (request.Id.HasValue)
                {
                    urlBuilder.AppendParameter(request.Id.GetValueOrDefault());
                }

                url = urlBuilder.ToString();
            }

            return url;
        }

        /// <summary>
        ///   <para>URL: <c>GET /license</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#retrieve-information-about-the-current-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private async System.Threading.Tasks.Task<License?> License_GetCurrentLicenseAsync(Meziantou.GitLab.GetCurrentLicenseRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url = Meziantou.GitLab.GitLabClient.License_GetCurrentLicenseAsync_BuildUrl();
            using (System.Net.Http.HttpRequestMessage requestMessage = new System.Net.Http.HttpRequestMessage())
            {
                requestMessage.Method = System.Net.Http.HttpMethod.Get;
                requestMessage.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
                HttpResponse? response = null;
                try
                {
                    response = await this.SendAsync(requestMessage, requestOptions, cancellationToken).ConfigureAwait(false);
                    if ((response.StatusCode == System.Net.HttpStatusCode.NotFound))
                    {
                        return default;
                    }

                    await response.EnsureStatusCodeAsync(cancellationToken).ConfigureAwait(false);
                    License? result = await response.ToObjectAsync<License>(cancellationToken).ConfigureAwait(false);
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

        private static string License_GetCurrentLicenseAsync_BuildUrl()
        {
            string url;
            url = "license";
            return url;
        }

        /// <summary>
        ///   <para>URL: <c>GET /licenses</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#retrieve-information-about-all-licenses" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        private Meziantou.GitLab.PagedResponse<License> License_GetLicenses(Meziantou.GitLab.GetLicensesRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            string url = Meziantou.GitLab.GitLabClient.License_GetLicenses_BuildUrl();
            return new Meziantou.GitLab.PagedResponse<License>(this, url, requestOptions);
        }

        private static string License_GetLicenses_BuildUrl()
        {
            string url;
            url = "licenses";
            return url;
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <summary>
        ///   <para>URL: <c>POST /license</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#add-a-new-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<License> AddLicenseAsync(this Meziantou.GitLab.IGitLabLicenseClient client, string license, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.AddLicenseRequest request = new Meziantou.GitLab.AddLicenseRequest(license);
            return client.AddLicenseAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>DELETE /license/:id</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#delete-a-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task DeleteLicenseAsync(this Meziantou.GitLab.IGitLabLicenseClient client, long id, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.DeleteLicenseRequest request = new Meziantou.GitLab.DeleteLicenseRequest(id);
            return client.DeleteLicenseAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /license</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#retrieve-information-about-the-current-license" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<License?> GetCurrentLicenseAsync(this Meziantou.GitLab.IGitLabLicenseClient client, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.GetCurrentLicenseRequest request = new Meziantou.GitLab.GetCurrentLicenseRequest();
            return client.GetCurrentLicenseAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>URL: <c>GET /licenses</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/license.html#retrieve-information-about-all-licenses" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        public static Meziantou.GitLab.PagedResponse<License> GetLicenses(this Meziantou.GitLab.IGitLabLicenseClient client, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            Meziantou.GitLab.GetLicensesRequest request = new Meziantou.GitLab.GetLicensesRequest();
            return client.GetLicenses(request, requestOptions);
        }
    }

    public partial class GetCurrentLicenseRequest
    {
        public GetCurrentLicenseRequest()
        {
        }
    }

    public partial class GetLicensesRequest
    {
        public GetLicensesRequest()
        {
        }
    }

    public partial class AddLicenseRequest
    {
        private string? _license;

        /// <param name="license">The license string</param>
        public AddLicenseRequest(string? license)
        {
            this._license = license;
        }

        public AddLicenseRequest()
        {
        }

        /// <summary>
        ///   <para>The license string</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnoreAttribute]
        public string? License
        {
            get
            {
                return this._license;
            }
            set
            {
                this._license = value;
            }
        }
    }

    public partial class DeleteLicenseRequest
    {
        private long? _id;

        /// <param name="id">ID of the GitLab license.</param>
        public DeleteLicenseRequest(long? id)
        {
            this._id = id;
        }

        public DeleteLicenseRequest()
        {
        }

        /// <summary>
        ///   <para>ID of the GitLab license.</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnoreAttribute]
        public long? Id
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
