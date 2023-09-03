using TodoListConsoleApp.Model;

namespace TodoListConsoleApp.Repository
{
  public interface ITodoListRepository
  {
    Todolist[] GetAll();
    void Add(Todolist todo);
    bool Remove(int number);
  }
}