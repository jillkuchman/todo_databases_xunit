using Xunit;
using System.Collections.Generic;
using System;

namespace ToDoList
{
  public class ToDoTest : IDisposable
  {
    [Fact]
    public void Test_GetAll()
    {
      //Arrange
      var description = "Wash the dog";
      var description2 = "Water the plants";
      Task testTask = new Task(description);
      testTask.Save();
      Task testTask2 = new Task(description2);
      testTask2.Save();

      //Act
      List<Task> result = Task.All();
      List<Task> testList = new List<Task>{testTask, testTask2};

      //debugging
      string descriptionString1 = "";
      foreach (Task thisTask in result ){
        descriptionString1 += thisTask.GetId();
      }
      Console.WriteLine("descriptionstring1: " + descriptionString1);

      string descriptionstring2 = "";
      foreach (Task thisTask in testList ){
        descriptionstring2 += thisTask.GetId();
      }
      Console.WriteLine("descriptionstring2: " + descriptionstring2);

      //Assert
      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_GetAll2()
    {
      //Arrange
      var description = "Wash the dog";
      var description2 = "Water the plants";
      var description3 = "Sweep the floor";
      Task testTask = new Task(description);
      testTask.Save();
      Task testTask2 = new Task(description2);
      testTask2.Save();
      Task testTask3 = new Task(description3);
      testTask3.Save();


      //Act
      List<Task> result = Task.All();
      List<Task> testList = new List<Task>{testTask, testTask2, testTask3};

      //debugging
      string descriptionString1 = "";
      foreach (Task thisTask in result ){
        descriptionString1 += thisTask.GetId();
      }
      Console.WriteLine("descriptionstring1: " + descriptionString1);

      string descriptionstring2 = "";
      foreach (Task thisTask in testList ){
        descriptionstring2 += thisTask.GetId();
      }
      Console.WriteLine("descriptionstring2: " + descriptionstring2);

      string descriptionstring3 = "";
      foreach (Task thisTask in testList ){
        descriptionstring3 += thisTask.GetId();
      }
      Console.WriteLine("descriptionstring3: " + descriptionstring3);


      //Assert
      Assert.Equal(testList, result);
    }

    public void Dispose()
      {
        Task.DeleteAll();
      }
    }
}
