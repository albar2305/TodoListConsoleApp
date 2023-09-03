using TodoListConsoleApp.Model;

namespace TodoListConsoleApp.Repository
{
  public class TodoListRepository : ITodoListRepository
  {
    private Todolist[] _data = new Todolist[10];

    public Todolist[] GetAll()
    {
      return _data;
    }

    public void Add(Todolist todo)
    {
      ResizeIsFull();

      for (var i = 0; i < _data.Length; i++)
        if (_data[i] == null)
        {
          _data[i] = todo;
          break;
        }
    }

    public bool Remove(int number)
    {
      if (number - 1 >= _data.Length) return false;

      if (_data[number - 1] == null) return false;

      for (var i = number - 1; i < _data.Length; ++i)
        if (i == _data.Length - 1)
          _data[i] = null;
        else
          _data[i] = _data[i + 1];

      return true;
    }

    public void ResizeIsFull()
    {
      if (IsFull())
      {
        var temp = _data;
        _data = new Todolist[_data.Length * 2];

        for (var i = 0; i < temp.Length; ++i) _data[i] = temp[i];
      }
    }

    public bool IsFull()
    {
      var isFull = true;

      for (var i = 0; i < _data.Length; i++)
        if (_data[i] == null)
        {
          isFull = false;
          break;
        }

      return isFull;
    }
  }
}