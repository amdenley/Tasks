﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
  public abstract class Task
  {
    protected string _name;

    public Task(string name)
    {
      _name = name;
    }
    public virtual void Add(Task t)
    {
      throw new NotSupportedException();
    }

    public virtual void Remove(Task t)
    {
      throw new NotSupportedException();
    }

    public virtual void Display(int depth)
    {
      throw new NotSupportedException();
    }
  }
}
