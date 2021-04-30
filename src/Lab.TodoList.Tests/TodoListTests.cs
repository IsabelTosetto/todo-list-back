using System;
using FluentAssertions;
using Lab.TodoList.Domain;
using Xunit;

namespace Lab.TodoList.Tests
{
    public class TodoListTests
    {
        [Fact]
        public void Should_Return_All_Items()
        {
            // arr
            var collection = new TodoItem[]
            {
                new TodoItem(),
                new TodoItem(),
                new TodoItem()
            };
            var todoList = new Domain.TodoList(collection);

            // act
            var items = todoList.GetAllItems();

            // assert

            items.Should().NotBeNullOrEmpty();
        }
    }
}
