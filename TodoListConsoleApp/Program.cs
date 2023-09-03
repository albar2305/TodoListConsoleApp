using TodoListConsoleApp.Repository;
using TodoListConsoleApp.Service;
using TodoListConsoleApp.View;

namespace TodoListConsoleApp
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var todoListRepository = new TodoListRepository();
      var todoListService = new TodoListService(todoListRepository);
      var todoListView = new TodoListView(todoListService);
      todoListView.ShowTodolist();
    }
  }
}