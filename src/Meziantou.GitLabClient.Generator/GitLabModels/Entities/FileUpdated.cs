﻿namespace Meziantou.GitLabClient.Generator.GitLabModels
{
    partial class Models
    {
        public static EntityBuilder FileUpdated { get; } = CreateEntity(entity => entity
                .AddProperty("file_path", ModelRef.String)
                .AddProperty("branch", ModelRef.String)
        );
    }
}
