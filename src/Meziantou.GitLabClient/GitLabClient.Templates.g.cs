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
        Meziantou.GitLab.IGitLabTemplatesClient Templates
        {
            get;
        }
    }

    public partial interface IGitLabTemplatesClient
    {
        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/dockerfiles.html#single-dockerfile-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Template?> GetDockerfileByKeyAsync(Meziantou.GitLab.GetDockerfileByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/dockerfiles.html#list-dockerfile-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<TemplateBasic> GetDockerfiles(Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions));

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitignores.html#single-gitignore-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Template?> GetGitIgnoreByKeyAsync(Meziantou.GitLab.GetGitIgnoreByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitignores.html#list-gitignore-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<TemplateBasic> GetGitIgnores(Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions));

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitlab_ci_ymls.html#single-gitlab-ci-yaml-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Template?> GetGitLabCiYmlByKeyAsync(Meziantou.GitLab.GetGitLabCiYmlByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitlab_ci_ymls.html#list-gitlab-ci-yaml-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<TemplateBasic> GetGitLabCiYmls(Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions));

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/licenses.html#single-license-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Template?> GetLicenseByKeyAsync(Meziantou.GitLab.GetLicenseByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/licenses.html#list-license-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<TemplateBasic> GetLicenses(Meziantou.GitLab.GetLicensesTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabTemplatesClient
    {
        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/dockerfiles.html#single-dockerfile-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Template?> Meziantou.GitLab.IGitLabTemplatesClient.GetDockerfileByKeyAsync(Meziantou.GitLab.GetDockerfileByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Templates_GetDockerfileByKeyAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/dockerfiles.html#list-dockerfile-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<TemplateBasic> Meziantou.GitLab.IGitLabTemplatesClient.GetDockerfiles(Meziantou.GitLab.RequestOptions? requestOptions)
        {
            return this.Templates_GetDockerfiles(requestOptions);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitignores.html#single-gitignore-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Template?> Meziantou.GitLab.IGitLabTemplatesClient.GetGitIgnoreByKeyAsync(Meziantou.GitLab.GetGitIgnoreByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Templates_GetGitIgnoreByKeyAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitignores.html#list-gitignore-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<TemplateBasic> Meziantou.GitLab.IGitLabTemplatesClient.GetGitIgnores(Meziantou.GitLab.RequestOptions? requestOptions)
        {
            return this.Templates_GetGitIgnores(requestOptions);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitlab_ci_ymls.html#single-gitlab-ci-yaml-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Template?> Meziantou.GitLab.IGitLabTemplatesClient.GetGitLabCiYmlByKeyAsync(Meziantou.GitLab.GetGitLabCiYmlByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Templates_GetGitLabCiYmlByKeyAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitlab_ci_ymls.html#list-gitlab-ci-yaml-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<TemplateBasic> Meziantou.GitLab.IGitLabTemplatesClient.GetGitLabCiYmls(Meziantou.GitLab.RequestOptions? requestOptions)
        {
            return this.Templates_GetGitLabCiYmls(requestOptions);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/licenses.html#single-license-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Template?> Meziantou.GitLab.IGitLabTemplatesClient.GetLicenseByKeyAsync(Meziantou.GitLab.GetLicenseByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Templates_GetLicenseByKeyAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/licenses.html#list-license-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<TemplateBasic> Meziantou.GitLab.IGitLabTemplatesClient.GetLicenses(Meziantou.GitLab.GetLicensesTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions)
        {
            return this.Templates_GetLicenses(request, requestOptions);
        }

        public Meziantou.GitLab.IGitLabTemplatesClient Templates
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/dockerfiles.html#single-dockerfile-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task<Template?> Templates_GetDockerfileByKeyAsync(Meziantou.GitLab.GetDockerfileByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("templates/dockerfiles/");
                if ((!object.ReferenceEquals(request.Key, null)))
                {
                    urlBuilder.AppendParameter(request.Key);
                }

                url = urlBuilder.ToString();
            }

            return this.GetAsync<Template>(url, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/dockerfiles.html#list-dockerfile-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        private Meziantou.GitLab.PagedResponse<TemplateBasic> Templates_GetDockerfiles(Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            string url;
            url = "templates/dockerfiles";
            return new Meziantou.GitLab.PagedResponse<TemplateBasic>(this, url, requestOptions);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitignores.html#single-gitignore-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task<Template?> Templates_GetGitIgnoreByKeyAsync(Meziantou.GitLab.GetGitIgnoreByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("templates/gitignores/");
                if ((!object.ReferenceEquals(request.Key, null)))
                {
                    urlBuilder.AppendParameter(request.Key);
                }

                url = urlBuilder.ToString();
            }

            return this.GetAsync<Template>(url, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitignores.html#list-gitignore-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        private Meziantou.GitLab.PagedResponse<TemplateBasic> Templates_GetGitIgnores(Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            string url;
            url = "templates/gitignores";
            return new Meziantou.GitLab.PagedResponse<TemplateBasic>(this, url, requestOptions);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitlab_ci_ymls.html#single-gitlab-ci-yaml-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task<Template?> Templates_GetGitLabCiYmlByKeyAsync(Meziantou.GitLab.GetGitLabCiYmlByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("templates/gitlab_ci_ymls/");
                if ((!object.ReferenceEquals(request.Key, null)))
                {
                    urlBuilder.AppendParameter(request.Key);
                }

                url = urlBuilder.ToString();
            }

            return this.GetAsync<Template>(url, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitlab_ci_ymls.html#list-gitlab-ci-yaml-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        private Meziantou.GitLab.PagedResponse<TemplateBasic> Templates_GetGitLabCiYmls(Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            string url;
            url = "templates/gitlab_ci_ymls";
            return new Meziantou.GitLab.PagedResponse<TemplateBasic>(this, url, requestOptions);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/licenses.html#single-license-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private System.Threading.Tasks.Task<Template?> Templates_GetLicenseByKeyAsync(Meziantou.GitLab.GetLicenseByKeyTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("templates/licenses/");
                if ((!object.ReferenceEquals(request.Key, null)))
                {
                    urlBuilder.AppendParameter(request.Key);
                }

                char separator = '?';
                if ((!object.ReferenceEquals(request.Project, null)))
                {
                    urlBuilder.Append(separator);
                    separator = '&';
                    urlBuilder.Append("project=");
                    urlBuilder.AppendParameter(request.Project);
                }

                if ((!object.ReferenceEquals(request.Fullname, null)))
                {
                    urlBuilder.Append(separator);
                    separator = '&';
                    urlBuilder.Append("fullname=");
                    urlBuilder.AppendParameter(request.Fullname);
                }

                url = urlBuilder.ToString();
            }

            return this.GetAsync<Template>(url, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/licenses.html#list-license-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The rule doesn't understand ref struct")]
        private Meziantou.GitLab.PagedResponse<TemplateBasic> Templates_GetLicenses(Meziantou.GitLab.GetLicensesTemplateRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            string url;
            using (Meziantou.GitLab.Internals.UrlBuilder urlBuilder = new Meziantou.GitLab.Internals.UrlBuilder())
            {
                urlBuilder.Append("templates/licenses");
                char separator = '?';
                if (request.Popular.HasValue)
                {
                    urlBuilder.Append(separator);
                    separator = '&';
                    urlBuilder.Append("popular=");
                    urlBuilder.AppendParameter(request.Popular.GetValueOrDefault());
                }

                url = urlBuilder.ToString();
            }

            return new Meziantou.GitLab.PagedResponse<TemplateBasic>(this, url, requestOptions);
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/dockerfiles.html#single-dockerfile-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<Template?> GetDockerfileByKeyAsync(this Meziantou.GitLab.IGitLabTemplatesClient client, string key, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.GetDockerfileByKeyTemplateRequest request = new Meziantou.GitLab.GetDockerfileByKeyTemplateRequest(key);
            return client.GetDockerfileByKeyAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitignores.html#single-gitignore-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<Template?> GetGitIgnoreByKeyAsync(this Meziantou.GitLab.IGitLabTemplatesClient client, string key, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.GetGitIgnoreByKeyTemplateRequest request = new Meziantou.GitLab.GetGitIgnoreByKeyTemplateRequest(key);
            return client.GetGitIgnoreByKeyAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/gitlab_ci_ymls.html#single-gitlab-ci-yaml-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<Template?> GetGitLabCiYmlByKeyAsync(this Meziantou.GitLab.IGitLabTemplatesClient client, string key, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.GetGitLabCiYmlByKeyTemplateRequest request = new Meziantou.GitLab.GetGitLabCiYmlByKeyTemplateRequest(key);
            return client.GetGitLabCiYmlByKeyAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/licenses.html#single-license-template" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<Template?> GetLicenseByKeyAsync(this Meziantou.GitLab.IGitLabTemplatesClient client, string key, string? project = default(string?), string? fullname = default(string?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.GetLicenseByKeyTemplateRequest request = new Meziantou.GitLab.GetLicenseByKeyTemplateRequest(key);
            request.Project = project;
            request.Fullname = fullname;
            return client.GetLicenseByKeyAsync(request, requestOptions, cancellationToken);
        }

        /// <summary>
        ///   <para>
        ///     <seealso href="https://docs.gitlab.com/ee/api/templates/licenses.html#list-license-templates" />
        ///   </para>
        /// </summary>
        /// <param name="requestOptions">Options of the request</param>
        public static Meziantou.GitLab.PagedResponse<TemplateBasic> GetLicenses(this Meziantou.GitLab.IGitLabTemplatesClient client, bool? popular = default(bool?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            Meziantou.GitLab.GetLicensesTemplateRequest request = new Meziantou.GitLab.GetLicensesTemplateRequest();
            request.Popular = popular;
            return client.GetLicenses(request, requestOptions);
        }
    }

    public partial class GetGitIgnoreByKeyTemplateRequest
    {
        private string? _key;

        public GetGitIgnoreByKeyTemplateRequest(string? key)
        {
            this._key = key;
        }

        public GetGitIgnoreByKeyTemplateRequest()
        {
        }

        public string? Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
    }

    public partial class GetGitLabCiYmlByKeyTemplateRequest
    {
        private string? _key;

        public GetGitLabCiYmlByKeyTemplateRequest(string? key)
        {
            this._key = key;
        }

        public GetGitLabCiYmlByKeyTemplateRequest()
        {
        }

        public string? Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
    }

    public partial class GetDockerfileByKeyTemplateRequest
    {
        private string? _key;

        public GetDockerfileByKeyTemplateRequest(string? key)
        {
            this._key = key;
        }

        public GetDockerfileByKeyTemplateRequest()
        {
        }

        public string? Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
    }

    public partial class GetLicensesTemplateRequest
    {
        private bool? _popular;

        public GetLicensesTemplateRequest()
        {
        }

        public bool? Popular
        {
            get
            {
                return this._popular;
            }
            set
            {
                this._popular = value;
            }
        }
    }

    public partial class GetLicenseByKeyTemplateRequest
    {
        private string? _fullname;

        private string? _key;

        private string? _project;

        public GetLicenseByKeyTemplateRequest(string? key)
        {
            this._key = key;
        }

        public GetLicenseByKeyTemplateRequest()
        {
        }

        public string? Fullname
        {
            get
            {
                return this._fullname;
            }
            set
            {
                this._fullname = value;
            }
        }

        public string? Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }

        public string? Project
        {
            get
            {
                return this._project;
            }
            set
            {
                this._project = value;
            }
        }
    }
}
