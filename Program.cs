using singletonzad2.Models;
using SingletonZad2.Models;

var buffor = PrinterBuffor.GetBuffor();
var buffor2 = PrinterBuffor.GetBuffor();

if (buffor == buffor2)
    Console.WriteLine("Correct implementation of the singleton pattern\n");
else
    Console.WriteLine("Incorrect implementation of the singleton pattern\n");

var tasks = new List<PrinterTask>
{
    new PrinterTask("TASK 1"),
    new PrinterTask("TASK 2"),
    new PrinterTask("TASK 3"),
    new PrinterTask("TASK 4"),
};


foreach(var task in tasks)
    buffor.AddTask(task);

buffor.Print();
buffor.Cancel(tasks[1].Id);
buffor.Print();

buffor.AddTask(new PrinterTask("TASK 5"));
buffor.AddTask(new PrinterTask("TASK 6"));

var allExisitngTasks = buffor.GetAllTasks();

Console.WriteLine("\n\nTasks in queue:");

foreach (var task in allExisitngTasks)
    Console.WriteLine($"ID:{task.Id} || Content: {task.Content}");