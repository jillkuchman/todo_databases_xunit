##To Do List

###Description
Simple to do list with unit testing using Microsoft SQL Server, Nancy 1.3.0, XUnit 2.1.0.

###Instructions
Download source code and run from the project folder

  `> dnvm install latest`
  `> dnu restore`
  `> dnx kestrel`

App production database named `todo` created using these commands in PowerShell **SQLCMD**

```
1> CREATE DATABASE todo;
2> GO
1> USE to_do;
2> GO
1> CREATE TABLE tasks
2> (
3>   id INT IDENTITY (1,1),
4>   description VARCHAR(255)
5> );
6> GO
```

Testing database is a clone of this named `todo_test`
