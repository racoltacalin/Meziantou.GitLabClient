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
    public partial class Job : Meziantou.GitLab.Core.GitLabObject, System.IEquatable<Meziantou.GitLab.Job>
    {
        internal Job(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("allow_failure")]
        public bool AllowFailure
        {
            get
            {
                return this.GetRequiredNonNullValue<bool>("allow_failure");
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

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("finished_at")]
        public System.DateTimeOffset? FinishedAt
        {
            get
            {
                return this.GetValueOrDefault<System.DateTimeOffset?>("finished_at", default(System.DateTimeOffset?));
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

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("started_at")]
        public System.DateTimeOffset? StartedAt
        {
            get
            {
                return this.GetValueOrDefault<System.DateTimeOffset?>("started_at", default(System.DateTimeOffset?));
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("status")]
        public JobStatus Status
        {
            get
            {
                return this.GetRequiredNonNullValue<JobStatus>("status");
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals((obj as Meziantou.GitLab.Job));
        }

        public virtual bool Equals(Meziantou.GitLab.Job? other)
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
            return (((((("Job { " + "Id = ") + this.Id) + ", ") + "Name = ") + this.Name) + " }");
        }

        public static bool operator !=(Meziantou.GitLab.Job? a, Meziantou.GitLab.Job? b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.Job? a, Meziantou.GitLab.Job? b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.Job>.Default.Equals(a, b);
        }
    }
}