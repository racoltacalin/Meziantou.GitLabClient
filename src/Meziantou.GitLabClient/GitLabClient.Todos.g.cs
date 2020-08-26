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
    public partial interface IGitLabClient
    {
        Meziantou.GitLab.IGitLabTodosClient Todos
        {
            get;
        }
    }

    public partial interface IGitLabTodosClient
    {
        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#get-a-list-of-todos" />
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<Todo> GetTodos(Meziantou.GitLab.GetTodosRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions));

        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#mark-all-todos-as-done" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task MarkAllTodosAsDoneAsync(Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#mark-a-todo-as-done" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Todo> MarkTodoAsDoneAsync(Meziantou.GitLab.MarkTodoAsDoneRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }

    public partial class GitLabClient : Meziantou.GitLab.IGitLabTodosClient
    {
        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#get-a-list-of-todos" />
        /// <param name="requestOptions">Options of the request</param>
        Meziantou.GitLab.PagedResponse<Todo> Meziantou.GitLab.IGitLabTodosClient.GetTodos(Meziantou.GitLab.GetTodosRequest request, Meziantou.GitLab.RequestOptions? requestOptions)
        {
            return this.Todos_GetTodos(request, requestOptions);
        }

        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#mark-all-todos-as-done" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task Meziantou.GitLab.IGitLabTodosClient.MarkAllTodosAsDoneAsync(Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Todos_MarkAllTodosAsDoneAsync(requestOptions, cancellationToken);
        }

        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#mark-a-todo-as-done" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        System.Threading.Tasks.Task<Todo> Meziantou.GitLab.IGitLabTodosClient.MarkTodoAsDoneAsync(Meziantou.GitLab.MarkTodoAsDoneRequest request, Meziantou.GitLab.RequestOptions? requestOptions, System.Threading.CancellationToken cancellationToken)
        {
            return this.Todos_MarkTodoAsDoneAsync(request, requestOptions, cancellationToken);
        }

        public Meziantou.GitLab.IGitLabTodosClient Todos
        {
            get
            {
                return this;
            }
        }

        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#get-a-list-of-todos" />
        /// <param name="requestOptions">Options of the request</param>
        private Meziantou.GitLab.PagedResponse<Todo> Todos_GetTodos(Meziantou.GitLab.GetTodosRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            Meziantou.GitLab.UrlBuilder urlBuilder = Meziantou.GitLab.UrlBuilder.Get("todos");
            urlBuilder.SetValue("action", request.Action);
            string url = urlBuilder.Build();
            return new Meziantou.GitLab.PagedResponse<Todo>(this, url, requestOptions);
        }

        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#mark-all-todos-as-done" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private System.Threading.Tasks.Task Todos_MarkAllTodosAsDoneAsync(Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.UrlBuilder urlBuilder = Meziantou.GitLab.UrlBuilder.Get("todos/mark_as_done");
            string url = urlBuilder.Build();
            return this.PostJsonAsync(url, null, requestOptions, cancellationToken);
        }

        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#mark-a-todo-as-done" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        private System.Threading.Tasks.Task<Todo> Todos_MarkTodoAsDoneAsync(Meziantou.GitLab.MarkTodoAsDoneRequest request, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.UrlBuilder urlBuilder = Meziantou.GitLab.UrlBuilder.Get("todos/:todo_id/mark_as_done");
            if (request.TodoId.HasValue)
            {
                urlBuilder.SetValue("todo_id", request.TodoId.Value.Value);
            }

            string url = urlBuilder.Build();
            return this.PostJsonAsync<Todo>(url, null, requestOptions, cancellationToken);
        }
    }

    public static partial class GitLabClientExtensions
    {
        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#get-a-list-of-todos" />
        /// <param name="requestOptions">Options of the request</param>
        public static Meziantou.GitLab.PagedResponse<Todo> GetTodos(this Meziantou.GitLab.IGitLabTodosClient client, TodoAction? action = default(TodoAction?), Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions))
        {
            Meziantou.GitLab.GetTodosRequest request = new Meziantou.GitLab.GetTodosRequest();
            request.Action = action;
            return client.GetTodos(request, requestOptions);
        }

        /// <seealso href="https://docs.gitlab.com/ee/api/todos.html#mark-a-todo-as-done" />
        /// <param name="requestOptions">Options of the request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        public static System.Threading.Tasks.Task<Todo> MarkTodoAsDoneAsync(this Meziantou.GitLab.IGitLabTodosClient client, TodoRef todoId, Meziantou.GitLab.RequestOptions? requestOptions = default(Meziantou.GitLab.RequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Meziantou.GitLab.MarkTodoAsDoneRequest request = new Meziantou.GitLab.MarkTodoAsDoneRequest(todoId);
            return client.MarkTodoAsDoneAsync(request, requestOptions, cancellationToken);
        }
    }

    public partial class GetTodosRequest
    {
        private TodoAction? _action;

        public GetTodosRequest()
        {
        }

        public TodoAction? Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
            }
        }
    }

    public partial class MarkTodoAsDoneRequest
    {
        private TodoRef? _todoId;

        public MarkTodoAsDoneRequest(TodoRef? todoId)
        {
            this._todoId = todoId;
        }

        public MarkTodoAsDoneRequest()
        {
        }

        public TodoRef? TodoId
        {
            get
            {
                return this._todoId;
            }
            set
            {
                this._todoId = value;
            }
        }
    }
}
