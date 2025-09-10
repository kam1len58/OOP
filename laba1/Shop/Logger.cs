
namespace WorkShop;

class Logger:ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine(message);
    }
}
