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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.UserStateJsonConverter))]
    public enum UserState
    {
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "active")]
        Active,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "blocked")]
        Blocked
    }

    internal partial class UrlBuilder
    {
        public void SetValue(string key, Meziantou.GitLab.UserState? value)
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

        public void SetValue(string key, Meziantou.GitLab.UserState value)
        {
            this.SetStringValue(key, Meziantou.GitLab.Serialization.EnumMember.ToString(value));
        }
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal partial class EnumMember
    {
        private static readonly Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.UserState>[] s_userStateMembers = Meziantou.GitLab.Serialization.EnumMember.CreateUserStateMembers();

        public static string ToString(Meziantou.GitLab.UserState value)
        {
            if ((value == Meziantou.GitLab.UserState.Active))
            {
                return "active";
            }

            if ((value == Meziantou.GitLab.UserState.Blocked))
            {
                return "blocked";
            }

            throw new System.ArgumentOutOfRangeException(nameof(value), string.Concat("Value '", value.ToString(), "' is not valid"));
        }

        public static Meziantou.GitLab.UserState UserStateFromString(string value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.FromString(value, Meziantou.GitLab.Serialization.EnumMember.s_userStateMembers);
        }

        private static Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.UserState>[] CreateUserStateMembers()
        {
            Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.UserState>[] result = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.UserState>[2];
            result[0] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.UserState>(Meziantou.GitLab.UserState.Active, "active");
            result[1] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.UserState>(Meziantou.GitLab.UserState.Blocked, "blocked");
            return result;
        }
    }

    internal sealed partial class UserStateJsonConverter : Meziantou.GitLab.Serialization.EnumBaseJsonConverter<Meziantou.GitLab.UserState>
    {
        protected override Meziantou.GitLab.UserState FromString(string value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.UserStateFromString(value);
        }

        protected override string ToString(Meziantou.GitLab.UserState value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.ToString(value);
        }
    }
}
