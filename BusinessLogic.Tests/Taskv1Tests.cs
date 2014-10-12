using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogicLayer;

namespace TaskTests
{
  /// <summary>
  /// Summary description for TaskTests
  /// </summary>
  [TestClass]
  public class TaskTestsv1
  {
    public TaskTestsv1()
    {
      //
      // TODO: Add constructor logic here
      //
    }

    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void Creation()
    {
      Taskv1 task = new Taskv1("task 1");
      Assert.IsNotNull(task);
    }
    [TestMethod]
    public void MarkComplete()
    {
      Taskv1 task = new Taskv1("task 1");
      task.MarkComplete();
      Assert.AreEqual(true, task.complete);
    }
    [TestMethod]
    public void TaskHasChildTask()
    {
      Taskv1 task = new Taskv1("task 1");
      Taskv1 subTask = new Taskv1("task 1a");
      task.subTasks.Add(subTask);
      //task.subTasks.Add(new Task("test3"));
      Assert.AreEqual(1, task.subTasks.Count());
    }
      
  }
}
