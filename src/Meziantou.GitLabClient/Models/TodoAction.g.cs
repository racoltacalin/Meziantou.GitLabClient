// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
#nullable enable
namespace Meziantou.GitLab
{
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.TodoActionJsonConverter))]
    public enum TodoAction
    {
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "assigned")]
        Assigned,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "mentioned")]
        Mentioned,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "build_failed")]
        BuildFailed,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "marked")]
        Marked,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "approval_required")]
        ApprovalRequired,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "unmergeable")]
        Unmergeable,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "directly_addressed")]
        DirectlyAddressed
    }

    internal partial class UrlBuilder
    {
        public void SetValue(string key, Meziantou.GitLab.TodoAction? value)
        {
            if (value.HasValue)
            {
                this.SetValue(key, value.GetValueOrDefault());
            }
            else
            {
                this.RemoveValues(key);
            }
        }

        public void SetValue(string key, Meziantou.GitLab.TodoAction value)
        {
            this.SetStringValue(key, Meziantou.GitLab.Serialization.EnumMember.ToString(value));
        }
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal partial class EnumMember
    {
        private static readonly Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>[] s_todoActionMembers = Meziantou.GitLab.Serialization.EnumMember.CreateTodoActionMembers();

        public static string ToString(Meziantou.GitLab.TodoAction value)
        {
            if ((value == Meziantou.GitLab.TodoAction.Assigned))
            {
                return "assigned";
            }

            if ((value == Meziantou.GitLab.TodoAction.Mentioned))
            {
                return "mentioned";
            }

            if ((value == Meziantou.GitLab.TodoAction.BuildFailed))
            {
                return "build_failed";
            }

            if ((value == Meziantou.GitLab.TodoAction.Marked))
            {
                return "marked";
            }

            if ((value == Meziantou.GitLab.TodoAction.ApprovalRequired))
            {
                return "approval_required";
            }

            if ((value == Meziantou.GitLab.TodoAction.Unmergeable))
            {
                return "unmergeable";
            }

            if ((value == Meziantou.GitLab.TodoAction.DirectlyAddressed))
            {
                return "directly_addressed";
            }

            throw new System.ArgumentOutOfRangeException(nameof(value), string.Concat("Value '", value.ToString(), "' is not valid"));
        }

        public static Meziantou.GitLab.TodoAction TodoActionFromString(string value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.FromString(value, Meziantou.GitLab.Serialization.EnumMember.s_todoActionMembers);
        }

        private static Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>[] CreateTodoActionMembers()
        {
            Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>[] result = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>[7];
            result[0] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>(Meziantou.GitLab.TodoAction.Assigned, "assigned");
            result[1] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>(Meziantou.GitLab.TodoAction.Mentioned, "mentioned");
            result[2] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>(Meziantou.GitLab.TodoAction.BuildFailed, "build_failed");
            result[3] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>(Meziantou.GitLab.TodoAction.Marked, "marked");
            result[4] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>(Meziantou.GitLab.TodoAction.ApprovalRequired, "approval_required");
            result[5] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>(Meziantou.GitLab.TodoAction.Unmergeable, "unmergeable");
            result[6] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.TodoAction>(Meziantou.GitLab.TodoAction.DirectlyAddressed, "directly_addressed");
            return result;
        }
    }

    internal sealed partial class TodoActionJsonConverter : Meziantou.GitLab.Serialization.EnumBaseJsonConverter<Meziantou.GitLab.TodoAction>
    {
        protected override Meziantou.GitLab.TodoAction FromString(string value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.TodoActionFromString(value);
        }

        protected override string ToString(Meziantou.GitLab.TodoAction value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.ToString(value);
        }
    }
}