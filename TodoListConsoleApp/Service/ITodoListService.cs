namespace TodoListConsoleApp.Service
{
  public interface ITodoListService
  {
    void ShowTodoList();

    void AddTodoList(string todo);

    bool RemoveTodoList(int number);
  }
}