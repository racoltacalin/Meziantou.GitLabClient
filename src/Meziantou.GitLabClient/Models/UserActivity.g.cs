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
    public partial class UserActivity : Meziantou.GitLab.Core.GitLabObject
    {
        internal UserActivity(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Meziantou.GitLab.Serialization.GitLabDateJsonConverter))]
        [Meziantou.GitLab.Internals.MappedPropertyAttribute("last_activity_on")]
        public System.DateTime LastActivityOn
        {
            get
            {
                return this.GetRequiredNonNullValue<System.DateTime>("last_activity_on");
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
    }
}
