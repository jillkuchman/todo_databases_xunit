using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using Xunit.Abstractions;

namespace ToDoList
{

  public class ToDoTest : IDisposable
  {
    private readonly ITestOutputHelper output;

    public ToDoTest(ITestOutputHelper output)
    {
      DBConfiguration.connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=todo_test;Integrated Security=SSPI;";
      this.output = output;
    }

    [Fact]
    public void Test_All()
    {
      //Arrange
      var description = "Wash the dog";
      var description2 = "Do the dishes";
      Task testTask = new Task(description);
      testTask.Save();
      Task testTask2 = new Task(description2);
      testTask2.Save();

      //Act
      List<Task> result = Task.All();
      List<Task> testList = new List<Task>{testTask, testTask2};

      //Assert
      Assert.Equal(result, testList);
    }



    public void Dispose()
      {
        Task.DeleteAll();
      }
    }
}
