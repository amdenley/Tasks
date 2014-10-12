using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMD.Tasks
{
  public interface ITask : IEnumerable
  {
    string name { get; set; }
    Boolean complete { get; set; }
    DateTime dueDate { get; set; }
    List<ITask> subTasks { get; set; }

    void MarkComplete();

  }
}
