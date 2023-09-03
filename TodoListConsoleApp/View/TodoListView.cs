using System;
using TodoListConsoleApp.Service;

namespace TodoListConsoleApp.View
{
  public class TodoListView
  {
    private readonly TodoListService _todoListService;

    public TodoListView(TodoListService todoListService)
    {
      _todoListService = todoListService;
    }

    public void ShowTodolist()
    {
      while (true)
      {
        _todoListService.ShowTodoList();
        Console.WriteLine("Menu");
        Console.WriteLine("1. Tambah");
        Console.WriteLine("2. Hapus");
        Console.WriteLine("x. Keluar");
        Console.Write("Pilih: ");
        var input = Console.ReadLine();
        if (input != null)
        {
          if (input.Equals("1"))
          {
            AddTodolist();
          }
          else if (input.Equals("2"))
          {
            RemoveTodolist();
          }
          else
          {
            if (input.Equals("x")) return;

            Console.WriteLine("Pilihan tidak dimengerti");
          }
        }
        else
        {
          Console.WriteLine("Masukan Pilihan");
        }
      }
    }

    private void AddTodolist()
    {
      Console.WriteLine("MENAMBAH TODOLIST");
      Console.Write("Todo (x jika batal): ");
      var todo = Console.ReadLine();
      if (todo != null && !todo.Equals("x")) _todoListService.AddTodoList(todo);
    }

    private void RemoveTodolist()
    {
      Console.WriteLine("MENGHAPUS TODOLIST");
      Console.Write("Nomor yang Dihapus (x jika batal): ");
      var number = Console.ReadLine();
      if (number != null && !number.Equals("x"))
      {
        var succes = _todoListService.RemoveTodoList(int.Parse(number));
        if (!succes) Console.WriteLine("GAGAL MENGHAPUS TODOLIST : " + number);
      }
    }
  }
}