﻿using System;
using System.Text;
using System.Threading.Tasks;

namespace Meziantou.GitLab.Tests
{
    public static class GitLabClientExtensions
    {
        public static async Task<MergeRequest> CreateMergeRequestAsync(this GitLabTestContext context, IGitLabClient client, ProjectIdOrPathRef project,
            bool assignedToMe = false,
            bool hasConflict = false,
            Action<CreateMergeRequestRequest> configure = null)
        {
            var filePath = context.GetRandomString();
            var branchName = context.GetRandomString();
            var assignee = assignedToMe ? await client.Users.GetCurrentUserAsync() : null;

            await client.RepositoryFiles.CreateFileAsync(new CreateFileRepositoryFileRequest(project, filePath, "master", content: context.GetRandomString(), commitMessage: context.GetRandomString()));

            await client.RepositoryFiles.UpdateFileAsync(new UpdateFileRepositoryFileRequest(project, filePath, branchName, content: TextOrBinaryData.FromString(context.GetRandomString(), Encoding.UTF8), commitMessage: context.GetRandomString())
            {
                StartBranch = "master",
            });

            if (hasConflict)
            {
                await client.RepositoryFiles.UpdateFileAsync(new UpdateFileRepositoryFileRequest(project, filePath, "master", content: context.GetRandomString(), commitMessage: context.GetRandomString()));
            }

            // Create merge request
            var request = new CreateMergeRequestRequest(project, branchName, "master", title: context.GetRandomString())
            {
                AssigneeId = assignee,
            };
            configure?.Invoke(request);

            var mergeRequest = await client.MergeRequests.CreateMergeRequestAsync(request);

            return mergeRequest;
        }

        public static async Task<MergeRequest> WaitForStatusReadyAsync(this IGitLabMergeRequestsClient client, MergeRequest mergeRequest)
        {
            while (mergeRequest.MergeStatus == MergeRequestStatus.Checking)
            {
                mergeRequest = await client.GetMergeRequestAsync(mergeRequest.ProjectId, mergeRequest.Iid);
            }

            return mergeRequest;
        }
    }
}
