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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.TodoTargetTypeJsonConverter))]
    public enum TodoTargetType
    {
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "Issue")]
        Issue,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "MergeRequest")]
        MergeRequest,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "Commit")]
        Commit
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal partial class EnumMember
    {
        private static readonly Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoTargetType>[] s_todoTargetTypeMembers = Meziantou.GitLab.Serialization.EnumMember.CreateTodoTargetTypeMembers();

        public static string ToString(Meziantou.GitLab.TodoTargetType value)
        {
            if ((value == Meziantou.GitLab.TodoTargetType.Issue))
            {
                return "Issue";
            }

            if ((value == Meziantou.GitLab.TodoTargetType.MergeRequest))
            {
                return "MergeRequest";
            }

            if ((value == Meziantou.GitLab.TodoTargetType.Commit))
            {
                return "Commit";
            }

            throw new System.ArgumentOutOfRangeException(nameof(value), string.Concat("Value '", value.ToString(), "' is not valid"));
        }

        public static Meziantou.GitLab.TodoTargetType TodoTargetTypeFromString(string value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.FromString(value, Meziantou.GitLab.Serialization.EnumMember.s_todoTargetTypeMembers);
        }

        private static Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoTargetType>[] CreateTodoTargetTypeMembers()
        {
            Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoTargetType>[] result = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoTargetType>[3];
            result[0] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoTargetType>(Meziantou.GitLab.TodoTargetType.Issue, "Issue");
            result[1] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoTargetType>(Meziantou.GitLab.TodoTargetType.MergeRequest, "MergeRequest");
            result[2] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoTargetType>(Meziantou.GitLab.TodoTargetType.Commit, "Commit");
            return result;
        }
    }

    internal sealed partial class TodoTargetTypeJsonConverter : Meziantou.GitLab.Serialization.EnumBaseJsonConverter<Meziantou.GitLab.TodoTargetType>
    {
        protected override Meziantou.GitLab.TodoTargetType FromString(string value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.TodoTargetTypeFromString(value);
        }

        protected override string ToString(Meziantou.GitLab.TodoTargetType value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.ToString(value);
        }
    }
}

namespace Meziantou.GitLab.Internals
{
    internal partial struct UrlBuilder
    {
        public void AppendParameter(Meziantou.GitLab.TodoTargetType value)
        {
            this.Append(Meziantou.GitLab.Serialization.EnumMember.ToString(value));
        }

        public void AppendRawParameter(Meziantou.GitLab.TodoTargetType value)
        {
            this.Append(Meziantou.GitLab.Serialization.EnumMember.ToString(value));
        }
    }
}
