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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.GitLabObjectReferenceJsonConverterFactory))]
    public readonly partial struct GroupIdRef : Meziantou.GitLab.Internals.IGitLabObjectReference<long>, System.IEquatable<Meziantou.GitLab.GroupIdRef>
    {
        private readonly long _value;

        private GroupIdRef(long groupId)
        {
            this._value = groupId;
        }

        private GroupIdRef(Group group)
        {
            if ((group == null))
            {
                throw new System.ArgumentNullException(nameof(group));
            }

            this._value = group.Id;
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
            if ((obj is Meziantou.GitLab.GroupIdRef))
            {
                return this.Equals(((Meziantou.GitLab.GroupIdRef)obj));
            }
            else
            {
                return false;
            }
        }

        public bool Equals(Meziantou.GitLab.GroupIdRef other)
        {
            return object.Equals(this.Value, other.Value);
        }

        public static Meziantou.GitLab.GroupIdRef FromGroup(Group group)
        {
            if ((group == null))
            {
                throw new System.ArgumentNullException(nameof(group));
            }

            return new Meziantou.GitLab.GroupIdRef(group);
        }

        public static Meziantou.GitLab.GroupIdRef FromGroupId(long groupId)
        {
            return new Meziantou.GitLab.GroupIdRef(groupId);
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(this.Value);
        }

        public override string ToString()
        {
            return this.Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static implicit operator Meziantou.GitLab.GroupIdRef(long groupId)
        {
            return Meziantou.GitLab.GroupIdRef.FromGroupId(groupId);
        }

        public static implicit operator Meziantou.GitLab.GroupIdRef?(long? groupId)
        {
            if (groupId.HasValue)
            {
                return Meziantou.GitLab.GroupIdRef.FromGroupId(groupId.Value);
            }
            else
            {
                return null;
            }
        }

        public static implicit operator Meziantou.GitLab.GroupIdRef(Group group)
        {
            return Meziantou.GitLab.GroupIdRef.FromGroup(group);
        }

        public static implicit operator Meziantou.GitLab.GroupIdRef?(Group? group)
        {
            if (object.ReferenceEquals(group, null))
            {
                return null;
            }
            else
            {
                return Meziantou.GitLab.GroupIdRef.FromGroup(group);
            }
        }

        public static bool operator !=(Meziantou.GitLab.GroupIdRef a, Meziantou.GitLab.GroupIdRef b)
        {
            return (!(a == b));
        }

        public static bool operator ==(Meziantou.GitLab.GroupIdRef a, Meziantou.GitLab.GroupIdRef b)
        {
            return System.Collections.Generic.EqualityComparer<Meziantou.GitLab.GroupIdRef>.Default.Equals(a, b);
        }
    }
}