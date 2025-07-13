using System;
namespace ArdalisRating
{
    public interface ILogger
    {
        void Log(string msg);
    }

    public class Logger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}