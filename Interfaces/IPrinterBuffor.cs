namespace singletonzad2.Interfaces
{
    public interface IPrinterBuffor
    {
        public bool AddTask(IPrinterTask task);
        public IList<IPrinterTask> GetAllTasks();
        public void Print();
        public bool Cancel(Guid taskId);
    }
}