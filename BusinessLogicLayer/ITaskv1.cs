using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
  public interface ITaskv1 : IEnumerable<ITaskv1>
  {
    string name { get; set; }
    Boolean complete { get; set; }
    DateTime dueDate { get; set; }
    List<ITaskv1> subTasks { get; set; }
    //ICollection<ITask> subTasks { get; set; }
    //ITask parentTask { get; set; }

    void MarkComplete();

  }
}
