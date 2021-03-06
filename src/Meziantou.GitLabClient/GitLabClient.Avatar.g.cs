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
        Meziantou.GitLab.IGitLabAvatarClient Avatar
        {
            get;
        }
    }

    public partial interface IGitLabAvatarClient
    {
        /// <summary>
        ///   <para>URL: <c>GET /avatar</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/avatar.html#get-a-single-avatar-url" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<UserAvatar?> GetUserAvatarAsync(Meziantou.GitLab.GetUserAvatarRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabAvatarClient
    {
        /// <summary>
        ///   <para>URL: <c>GET /avatar</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/avatar.html#get-a-single-avatar-url" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<UserAvatar?> Meziantou.GitLab.IGitLabAvatarClient.GetUserAvatarAsync(Meziantou.GitLab.GetUserAvatarRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Avatar_GetUserAvatarAsync(request, requestOptions, cancellationToken);
        }

        public Meziantou.GitLab.IGitLabAvatarClient Avatar
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        ///   <para>URL: <c>GET /avatar</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/avatar.html#get-a-single-avatar-url" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private async System.Threading.Tasks.Task<UserAvatar?> Avatar_GetUserAvatarAsync(Meziantou.GitLab.GetUserAvatarRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url = Meziantou.GitLab.GitLabClient.Avatar_GetUserAvatarAsync_BuildUrl(request);
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
                    UserAvatar? result = await response.ToObjectAsync<UserAvatar>(cancellationToken).ConfigureAwait(false);
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
        private static string Avatar_GetUserAvatarAsync_BuildUrl(Meziantou.GitLab.GetUserAvatarRequest request)
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("avatar");
                char separator = '?';
                if ((!object.ReferenceEquals(request.Email, null)))
                {
                    urlBuilder.Append(separator);
                    separator = '&';
                    urlBuilder.Append("email=");
                    urlBuilder.AppendParameter(request.Email);
                }

                if (request.Size.HasValue)
                {
                    urlBuilder.Append(separator);
                    separator = '&';
                    urlBuilder.Append("size=");
                    urlBuilder.AppendParameter(request.Size.GetValueOrDefault());
                }

                url = urlBuilder.ToString();
            }

            return url;
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <summary>
        ///   <para>URL: <c>GET /avatar</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/avatar.html#get-a-single-avatar-url" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<UserAvatar?> GetUserAvatarAsync(this Meziantou.GitLab.IGitLabAvatarClient client, string email, int? size = default(int?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.GetUserAvatarRequest request = new Meziantou.GitLab.GetUserAvatarRequest(email);
            request.Size = size;
            return client.GetUserAvatarAsync(request, requestOptions, cancellationToken);
        }
    }

    public partial class GetUserAvatarRequest
    {
        private string? _email;

        private int? _size;

        /// <param name="email">Public email address of the user.</param>
        public GetUserAvatarRequest(string? email)
        {
            this._email = email;
        }

        public GetUserAvatarRequest()
        {
        }

        /// <summary>
        ///   <para>Public email address of the user.</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnoreAttribute]
        public string? Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }

        /// <summary>
        ///   <para>Single pixel dimension (since images are squares). Only used for avatar lookups at Gravatar or at the configured Libravatar server.</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnoreAttribute]
        public int? Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
    }
}
