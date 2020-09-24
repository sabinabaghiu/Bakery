using System.Collections.Generic;
using TodoAdvanced.Models;

namespace TodoAdvanced.Data
{
    public interface ITodosService
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);
        void RemoveTodo(int todoId);
        void Update(Todo todo);
    }
}