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
    public partial class FileCreated : Meziantou.GitLab.Core.GitLabObject
    {
        internal FileCreated(System.Text.Json.JsonElement obj)
            : base(obj)
        {
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("branch")]
        public string Branch
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("branch");
            }
        }

        [Meziantou.GitLab.Internals.MappedPropertyAttribute("file_path")]
        public string FilePath
        {
            get
            {
                return this.GetRequiredNonNullValue<string>("file_path");
            }
        }
    }
}
