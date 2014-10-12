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
      Task task = new Task("need to do task 1");
      Task task2 = new Task("need to do task 2");
      task.subTasks.Add(task2);
      Console.WriteLine("added task2 to task1");
    }
  }
}
