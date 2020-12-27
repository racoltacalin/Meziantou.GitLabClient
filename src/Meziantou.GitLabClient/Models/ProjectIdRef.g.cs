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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.GitLabObjectInt64ReferenceJsonConverter))]
    public readonly partial struct ProjectIdRef : Meziantou.GitLab.Internals.IGitLabObjectReference<long>, System.IEquatable<Meziantou.GitLab.ProjectIdRef>
    {
        private readonly long _value;

        private ProjectIdRef(long projectId)
        {
            this._value = projectId;
        }

        private ProjectIdRef(ProjectIdentity project)
        {
            if ((project == null))
            {
                throw new System.ArgumentNullException(nameof(project));
            }

            this._value = project.Id;
        }

        public long Value
        {
            get
            {
                return this._value;
            }
        }

        public override bool Equals(object? obj)
        {
            if ((obj is Meziantou.GitLab.ProjectIdRef))
            {
                return this.Equals(((Meziantou.GitLab.ProjectIdRef)obj));
            }
            else
            {
                return false;
            }
        }

        public bool Equals(Meziantou.GitLab.ProjectIdRef other)
        {
            return object.Equals(this.Value, other.Value);
        }

        public static Meziantou.GitLab.ProjectIdRef FromProject(ProjectIdentity project)
        {
            if ((project == null))
            {
                throw new System.ArgumentNullException(nameof(project));
            }

            return new Meziantou.GitLab.ProjectIdRef(project);
        }

        public static Meziantou.GitLab.ProjectIdRef FromProjectId(long projectId)
        {
            return new Meziantou.GitLab.ProjectIdRef(projectId);
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(this.Value);
        }

        public override string ToString()
        {
            return this.Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static implicit operator Meziantou.GitLab.ProjectIdRef(long projectId)
        {
            return Meziantou.GitLab.ProjectIdRef.FromProjectId(projectId);
        }

        public static implicit operator Meziantou.GitLab.ProjectIdRef?(long? projectId)
        {
            if (projectId.HasValue)
            {
                return Meziantou.GitLab.ProjectIdRef.FromProjectId(projectId.Value);
            }
            else
            {
                return null;
            }
        }

        public static implicit operator Meziantou.GitLab.ProjectIdRef(ProjectIdentity project)
        {
            return Meziantou.GitLab.ProjectIdRef.FromProject(project);
        }

        public static implicit operator Meziantou.GitLab.ProjectIdRef?(ProjectIdentity? project)
        {
            if (object.ReferenceEquals(project, null))
            {
                return null;
            }
            else
            {
                return Meziantou.GitLab.ProjectIdRef.FromProject(project);
            }
        }

        public static bool operator !=(Meziantou.GitLab.ProjectIdRef a, Meziantou.GitLab.ProjectIdRef b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.ProjectIdRef a, Meziantou.GitLab.ProjectIdRef b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.ProjectIdRef>.Default.Equals(a, b);
        }
    }
}
