using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
  public class Project : Task, IEnumerable<Task>
  {
    private List<Task> _children = new List<Task>();

    public Project(string name) : base(name)
    {
    }

    public override void Add(Task component)
    {
      _children.Add(component);
    }

    public override void Remove(Task component)
    {
      _children.Remove(component);
    }

    public override void Display(int depth)
    {
      Console.WriteLine(new String('-', depth) + _name);
      foreach ( Task component in _children )
      {
        component.Display(depth + 2);
      }
    }

    public override Task GetChild(int index)
    {
      return _children[index];
    }

    public override IList<Task> GetChildren()
    {
      return _children;
    }

    public IEnumerator<Task> GetEnumerator()
    {
      foreach (Task child in _children)
      {
        yield return child;
      }
        
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
