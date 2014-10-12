using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogicLayer;

namespace GTDTestConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Task t1 = new Project("task1");
      t1.Add(new TaskItem("task2"));
      var t3 = new Project("subtask 3");
      t1.Add(t3);
      t3.Add(new TaskItem("subtask 3a"));
      t3.Add(new TaskItem("subtask 3b"));

      t1.Display(0);

    }
  }
}
