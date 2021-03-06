﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Meziantou.GitLab.Core;
using Meziantou.GitLab.Internals;
using Xunit;
using Xunit.Abstractions;

namespace Meziantou.GitLab.Tests
{
    public class PagedResponseTests : GitLabTestBase
    {
        public PagedResponseTests(ITestOutputHelper testOutputHelper)
            : base(testOutputHelper)
        {
        }

        [Fact]
        public async Task FillPropertiesAsync()
        {
            using var handler = new MockHandler();
            handler.AddResponse("GET http://localhost:3000/", new HttpResponseMessage(HttpStatusCode.OK)
            {
                Headers =
                {
                    { "Link", "<http://localhost:3000/?page=3>; rel=\"next\", <http://localhost:3000/?page=1>; rel=\"prev\", <http://localhost:3000/?page=1>; rel=\"first\", <http://localhost:3000/?page=10>; rel=\"last\"" },
                    { "X-Page", "2" },
                    { "X-Per-Page", "5" },
                    { "X-Total", "50" },
                    { "X-Total-Pages", "10" },
                },
                Content = new JsonContent(new[] { new object(), new object() }, settings: null),
            });

            using var context = await CreateContextAsync(parallelizable: true, handler);

            // Act
            var page = await ((TestGitLabClient)context.AdminClient).GetPagedCollectionAsync<GitLabObject>("http://localhost:3000", default, CancellationToken.None);

            // Assert
            Assert.Equal(2, page.PageIndex);
            Assert.Equal(5, page.PageSize);
            Assert.Equal(10, page.TotalPages);
            Assert.Equal(50, page.TotalItems);
            Assert.False(page.IsFirstPage);
            Assert.False(page.IsLastPage);
        }

        private sealed class MockHandler : HttpClientHandler
        {
            private readonly List<(string Request, HttpResponseMessage Response)> _mocks = new List<(string request, HttpResponseMessage response)>();
            private int _index;

            public void AddResponse(string expectedRequest, HttpResponseMessage response)
            {
                _mocks.Add((expectedRequest, response));
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var (expectedRequest, response) = _mocks[_index++];
                Assert.Equal(expectedRequest, $"{request.Method} {request.RequestUri}");
                return Task.FromResult(response);
            }
        }
    }
}
