﻿namespace Meziantou.GitLabClient.Generator.GitLabModels
{
    partial class Models
    {
        public static ParameterEntityBuilder UserIdOrUserNameRef { get; } = CreateParameterEntity(entity =>
            entity.SetRefs(
                ParameterEntityRef.Create("userId", ModelRef.NumberId),
                ParameterEntityRef.Create("userName", ModelRef.String),
                ParameterEntityRef.Create("user", Models.UserSafe))
        );
    }
}
