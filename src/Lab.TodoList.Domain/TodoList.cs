using System.Collections.Generic;

namespace Lab.TodoList.Domain
{
    public class TodoList
    {
        private ICollection<TodoItem> Items { get; set; }
        public TodoList(ICollection<TodoItem> items)
        {
            Items = items;
        }

        public void ClearCompleted()
        {
        }

        public IEnumerable<TodoItem> GetAllItems()
        {
            return Items;
        }
    }
}