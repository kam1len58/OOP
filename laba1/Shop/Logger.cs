
namespace WorkShop;

public class Logger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine(message);
    }
}
