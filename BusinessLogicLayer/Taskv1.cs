using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
  public class Taskv1 : ITaskv1
  {
    private string _name;
    private bool _complete;
    private DateTime _dueDate;
    private List<ITaskv1> _subTasks = new List<ITaskv1>();

    public Taskv1(string name)
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
    public List<ITaskv1> subTasks
    {
      get { return _subTasks; }
      set { _subTasks = subTasks; }
    }

    public void MarkComplete()
    {
      _complete = true;
      Console.WriteLine(this + " has been marked complete.");
    }

    public IEnumerator<ITaskv1> GetEnumerator()
    {
      foreach (ITaskv1 task in _subTasks)
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
