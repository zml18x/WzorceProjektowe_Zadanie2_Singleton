using singletonzad2.Interfaces;

namespace SingletonZad2.Models
{
    public class PrinterBuffor : IPrinterBuffor
    {
        private static PrinterBuffor? _printerBuffor;
        private static readonly object _lock = new object();
        private static IList<IPrinterTask>? _tasks;



        private PrinterBuffor()
        {
            _tasks = new List<IPrinterTask>();
        }



        public static IPrinterBuffor GetBuffor()
        {
            lock (_lock)
            {
                if(_printerBuffor == null)
                {
                    _printerBuffor = new PrinterBuffor();
                    _tasks!.Clear();
                }
                return _printerBuffor;
            }
        }

        public bool AddTask(IPrinterTask task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task), "Task cannot be null");

            _tasks!.Add(task);

            return true;
        }

        public void Print()
        {
            if (!_tasks!.Any())
                throw new ArgumentException("Tasks collection is empty", nameof(_tasks));

            var printedTask = _tasks!.First();
            _tasks!.Remove(printedTask);

            Console.WriteLine($"Task was printed.\n ID: {printedTask.Id} || Task content: {printedTask.Content}");
        }

        public bool Cancel(Guid taskId)
        {
            if(!_tasks!.Any())
                throw new ArgumentException("Tasks collection is empty",nameof(_tasks));

            if (taskId == Guid.Empty)
                throw new ArgumentException($"TaskId cannot be empty", nameof(taskId));

            _tasks!.Remove(_tasks.First(x => x.Id == taskId));

            return true;
        }

        public IList<IPrinterTask> GetAllTasks()
            => _tasks!;
    }
}