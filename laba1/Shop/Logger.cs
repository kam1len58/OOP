
namespace WorkShop;

public class Logger : ILoger
{
    public void WriteLog(string message)
    {
        Console.WriteLine(message);
    }
}
