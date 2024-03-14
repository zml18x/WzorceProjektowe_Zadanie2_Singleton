using singletonzad2.Interfaces;

namespace singletonzad2.Models
{
    public class PrinterTask : IPrinterTask
    {
        public Guid Id { get; set; }
        public string? Content { get; set; }


        
        public PrinterTask(string? content)
        {
            Id = Guid.NewGuid();
            Content = content;
        }
    }
}