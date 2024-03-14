namespace singletonzad2.Interfaces
{
    public interface IPrinterTask
    {
        public Guid Id { get; set; }
        public string? Content { get; set; }
    }
}