using System;
using TodoListConsoleApp.Model;
using TodoListConsoleApp.Repository;

namespace TodoListConsoleApp.Service
{
  public class TodoListService : ITodoListService
  {
    private readonly TodoListRepository _todoListRepository;

    public TodoListService(TodoListRepository todoListRepository)
    {
      _todoListRepository = todoListRepository;
    }

    public void ShowTodoList()
    {
      var model = _todoListRepository.GetAll();
      Console.WriteLine("TODOLIST");

      for (var i = 0; i < model.Length; i++)
      {
        var todolist = model[i];
        var no = i + 1;
        if (todolist != null) Console.WriteLine(no + ". " + todolist.GetTodo());
      }
    }

    public void AddTodoList(string todo)
    {
      var todolist = new Todolist(todo);
      _todoListRepository.Add(todolist);
      Console.WriteLine("SUKSES MENAMBAH TODO: " + todo);
    }

    public bool RemoveTodoList(int number)
    {
      var succes = _todoListRepository.Remove(number);
      return succes;
    }
  }
}