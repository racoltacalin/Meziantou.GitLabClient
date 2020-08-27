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
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.MergeRequestViewJsonConverter))]
    public enum MergeRequestView
    {
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "default")]
        Default,
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "simple")]
        Simple
    }
}

namespace Meziantou.GitLab.Serialization
{
    internal partial class EnumMember
    {
        private static readonly Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.MergeRequestView>[] s_mergeRequestViewMembers = Meziantou.GitLab.Serialization.EnumMember.CreateMergeRequestViewMembers();

        public static Meziantou.GitLab.MergeRequestView MergeRequestViewFromString(string value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.FromString(value, Meziantou.GitLab.Serialization.EnumMember.s_mergeRequestViewMembers);
        }

        public static string ToString(Meziantou.GitLab.MergeRequestView value)
        {
            if ((value == Meziantou.GitLab.MergeRequestView.Default))
            {
                return "default";
            }

            if ((value == Meziantou.GitLab.MergeRequestView.Simple))
            {
                return "simple";
            }

            throw new System.ArgumentOutOfRangeException(nameof(value), string.Concat("Value '", value.ToString(), "' is not valid"));
        }

        private static Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.MergeRequestView>[] CreateMergeRequestViewMembers()
        {
            Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.MergeRequestView>[] result = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.MergeRequestView>[2];
            result[0] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.MergeRequestView>(Meziantou.GitLab.MergeRequestView.Default, "default");
            result[1] = new Meziantou.GitLab.Serialization.EnumMember<Meziantou.GitLab.MergeRequestView>(Meziantou.GitLab.MergeRequestView.Simple, "simple");
            return result;
        }
    }

    internal sealed partial class MergeRequestViewJsonConverter : Meziantou.GitLab.Serialization.EnumBaseJsonConverter<Meziantou.GitLab.MergeRequestView>
    {
        protected override Meziantou.GitLab.MergeRequestView FromString(string value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.MergeRequestViewFromString(value);
        }

        protected override string ToString(Meziantou.GitLab.MergeRequestView value)
        {
            return Meziantou.GitLab.Serialization.EnumMember.ToString(value);
        }
    }
}

namespace Meziantou.GitLab.Internals
{
    internal partial struct UrlBuilder
    {
        public void AppendParameter(Meziantou.GitLab.MergeRequestView value)
        {
            this.Append(Meziantou.GitLab.Serialization.EnumMember.ToString(value));
        }
    }
}
