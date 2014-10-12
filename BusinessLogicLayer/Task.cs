using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMD.Tasks
{
  public class Task : ITask
  {
    private string _name;
    private bool _complete;
    private DateTime _dueDate;
    private List<ITask> _subTasks = new List<ITask>();

    public Task(string name)
    {
      _name = name;
      Console.WriteLine(this + " has been instantiated.");
    }

    public override string ToString()
    {
      return "Task: " + _name;
    }

    public string name
    {
      get { return _name; }
      set { _name = name; }
    }

    public bool complete
    {
      get { return _complete; }
      set { _complete = complete; }
    }

    public DateTime dueDate
    {
      get { return _dueDate; }
      set { _dueDate = dueDate; }
    }
    public List<ITask> subTasks
    {
      get { return _subTasks; }
      set { _subTasks = subTasks; }
    }

    public void MarkComplete()
    {
      _complete = true;
      Console.WriteLine(this + " has been marked complete.");
    }

    public IEnumerator<ITask> GetEnumerator()
    {
      foreach (ITask task in _subTasks)
      {
        yield return task;
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
