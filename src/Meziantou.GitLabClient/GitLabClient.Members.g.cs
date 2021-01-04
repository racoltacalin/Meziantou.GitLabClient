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
        Meziantou.GitLab.IGitLabMembersClient Members
        {
            get;
        }
    }

    public partial interface IGitLabMembersClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:id/members</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/members.html#add-a-member-to-a-group-or-project" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Member> AddMemberToProjectAsync(Meziantou.GitLab.AddMemberToProjectRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabMembersClient
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:id/members</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/members.html#add-a-member-to-a-group-or-project" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Member> Meziantou.GitLab.IGitLabMembersClient.AddMemberToProjectAsync(Meziantou.GitLab.AddMemberToProjectRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Members_AddMemberToProjectAsync(request, requestOptions, cancellationToken);
        }

        public Meziantou.GitLab.IGitLabMembersClient Members
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        ///   <para>URL: <c>POST /projects/:id/members</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/members.html#add-a-member-to-a-group-or-project" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private async System.Threading.Tasks.Task<Member> Members_AddMemberToProjectAsync(Meziantou.GitLab.AddMemberToProjectRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url = Meziantou.GitLab.GitLabClient.Members_AddMemberToProjectAsync_BuildUrl(request);
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
                    Member? result = await response.ToObjectAsync<Member>(cancellationToken).ConfigureAwait(false);
                    if ((result == null))
                    {
                        throw new Meziantou.GitLab.GitLabException(response.RequestMethod, response.RequestUri, response.StatusCode, "The response cannot be converted to 'Member' because the body is null or empty");
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
        private static string Members_AddMemberToProjectAsync_BuildUrl(Meziantou.GitLab.AddMemberToProjectRequest request)
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("projects/");
                if (request.Id.HasValue)
                {
                    urlBuilder.AppendParameter(request.Id.GetValueOrDefault().ValueAsString);
                }

                urlBuilder.Append("/members");
                url = urlBuilder.ToString();
            }

            return url;
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <summary>
        ///   <para>URL: <c>POST /projects/:id/members</c></para>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/members.html#add-a-member-to-a-group-or-project" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<Member> AddMemberToProjectAsync(this Meziantou.GitLab.IGitLabMembersClient client, ProjectIdOrPathRef id, UserIdRef userId, AccessLevel accessLevel, System.DateTime? expiresAt = default(System.DateTime?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.AddMemberToProjectRequest request = new Meziantou.GitLab.AddMemberToProjectRequest(id, userId, accessLevel);
            request.ExpiresAt = expiresAt;
            return client.AddMemberToProjectAsync(request, requestOptions, cancellationToken);
        }
    }

    public partial class AddMemberToProjectRequest
    {
        private AccessLevel? _accessLevel;

        private System.DateTime? _expiresAt;

        private ProjectIdOrPathRef? _id;

        private UserIdRef? _userId;

        /// <param name="id">The ID or URL-encoded path of the project or group owned by the authenticated user</param>
        /// <param name="userId">The user ID of the new member or multiple IDs separated by commas</param>
        /// <param name="accessLevel">A valid access level</param>
        public AddMemberToProjectRequest(ProjectIdOrPathRef? id, UserIdRef? userId, AccessLevel? accessLevel)
        {
            this._id = id;
            this._userId = userId;
            this._accessLevel = accessLevel;
        }

        public AddMemberToProjectRequest()
        {
        }

        /// <summary>
        ///   <para>A valid access level</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("access_level")]
        public AccessLevel? AccessLevel
        {
            get
            {
                return this._accessLevel;
            }
            set
            {
                this._accessLevel = value;
            }
        }

        /// <summary>
        ///   <para>A date string in the format YEAR-MONTH-DAY</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expires_at")]
        [System.Text.Json.Serialization.JsonIgnoreAttribute(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
        public System.DateTime? ExpiresAt
        {
            get
            {
                return this._expiresAt;
            }
            set
            {
                this._expiresAt = value;
            }
        }

        /// <summary>
        ///   <para>The ID or URL-encoded path of the project or group owned by the authenticated user</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnoreAttribute]
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
        ///   <para>The user ID of the new member or multiple IDs separated by commas</para>
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user_id")]
        public UserIdRef? UserId
        {
            get
            {
                return this._userId;
            }
            set
            {
                this._userId = value;
            }
        }
    }
}