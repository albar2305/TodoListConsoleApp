namespace TodoListConsoleApp.Model
{
  public class Todolist
  {
    private string _todo;

    public Todolist(string todo)
    {
      _todo = todo;
    }

    public Todolist()
    {
    }

    public void SetTodo(string value)
    {
      _todo = value;
    }

    public string GetTodo()
    {
      return _todo;
    }
  }
}