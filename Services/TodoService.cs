using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService
    {
        private readonly List<TodoItem> _todos = new List<TodoItem>();

        public IReadOnlyList<TodoItem> GetTodos() => _todos;

        public void AddTodo(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                _todos.Add(new TodoItem { Title = title });
            }
        }

        public void ToggleTodoCompletion(TodoItem todo)
        {
            todo.IsCompleted = !todo.IsCompleted;
        }
    }
}
