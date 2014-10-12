using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
  public class TaskItem : Task
  {
    public TaskItem(string name): base(name)
    {
    }
    public override void Display(int depth)
    {
      Console.WriteLine(new String('-', depth) + _name);
    }
  }
}
