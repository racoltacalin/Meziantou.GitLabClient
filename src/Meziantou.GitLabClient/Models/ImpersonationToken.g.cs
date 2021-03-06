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
    public partial class ImpersonationToken : Meziantou.GitLab.Core.GitLabObject, System.IEquatable<Meziantou.GitLab.ImpersonationToken>
    {
        internal ImpersonationToken(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("active")]
        public bool Active
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("active");
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

        /// <remarks>The value may not be an UTC DateTime</remarks>
        [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.GitLabDateJsonConverter))]
        [Meziantou.GitLab.Internals.SkipUtcDateValidationAttribute]
        [Meziantou.GitLab.Internals.MappedPropertyAttribute("expires_at")]
        public System.DateTime? ExpiresAt
        {
            get
            {
                return this.GetValueOrDefault<System.DateTime?>("expires_at", default(System.DateTime?));
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

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("impersonation")]
        public bool Impersonation
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("impersonation");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("name")]
        public string Name
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("name");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("revoked")]
        public bool Revoked
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("revoked");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("scopes")]
        public System.Collections.Generic.IReadOnlyList<ImpersonationTokenScope> Scopes
        {
            get
            {
                return this.GetRequiredNonNullValue<System.Collections.Generic.IReadOnlyList<ImpersonationTokenScope>>("scopes");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("token")]
        public string Token
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("token");
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals((obj as Meziantou.GitLab.ImpersonationToken));
        }

        public virtual bool Equals(Meziantou.GitLab.ImpersonationToken? other)
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
            return (((((("ImpersonationToken { " + "Id = ") + this.Id) + ", ") + "Name = ") + this.Name) + " }");
        }

        public static bool operator !=(Meziantou.GitLab.ImpersonationToken? a, Meziantou.GitLab.ImpersonationToken? b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.ImpersonationToken? a, Meziantou.GitLab.ImpersonationToken? b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.ImpersonationToken>.Default.Equals(a, b);
        }
    }
}
