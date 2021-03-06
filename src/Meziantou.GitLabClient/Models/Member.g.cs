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
    public partial class Member : Meziantou.GitLab.Core.GitLabObject, System.IEquatable<Meziantou.GitLab.Member>
    {
        internal Member(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("access_level")]
        public AccessLevel AccessLevel
        {
            get
            {
                return this.GetRequiredNonNullValue<AccessLevel>("access_level");
            }
        }

        /// <remarks>The value is an absolute URI</remarks>
        [Meziantou.GitLab.Internals.MappedPropertyAttribute("avatar_url")]
        public System.Uri AvatarUrl
        {
            get
            {
                return this.GetRequiredNonNullValue<System.Uri>("avatar_url");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("email")]
        public string? Email
        {
            get
            {
                return this.GetValueOrDefault<string?>("email", default(string?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("expires_at")]
        public System.DateTimeOffset? ExpiresAt
        {
            get
            {
                return this.GetValueOrDefault<System.DateTimeOffset?>("expires_at", default(System.DateTimeOffset?));
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

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("name")]
        public string Name
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("name");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("state")]
        public string State
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("state");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("username")]
        public string Username
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("username");
            }
        }

        /// <remarks>The value is an absolute URI</remarks>
        [Meziantou.GitLab.Internals.MappedPropertyAttribute("web_url")]
        public System.Uri WebUrl
        {
            get
            {
                return this.GetRequiredNonNullValue<System.Uri>("web_url");
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals((obj as Meziantou.GitLab.Member));
        }

        public virtual bool Equals(Meziantou.GitLab.Member? other)
        {
            return ((!object.ReferenceEquals(other, null)) && (this.Username == other.Username));
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(this.Username);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Design", "MA0075:Do not use implicit culture-sensitive ToString", Justification = "Valid in ToString")]
        public override string ToString()
        {
            return ((((((((("Member { " + "Username = ") + this.Username) + ", ") + "Name = ") + this.Name) + ", ") + "State = ") + this.State) + " }");
        }

        public static bool operator !=(Meziantou.GitLab.Member? a, Meziantou.GitLab.Member? b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.Member? a, Meziantou.GitLab.Member? b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.Member>.Default.Equals(a, b);
        }
    }
}
