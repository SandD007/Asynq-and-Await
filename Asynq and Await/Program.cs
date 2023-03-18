using System;

namespace Asynq_and_Await
{
    internal class Program
    {
         public static void Main(string[] args)
        {
            var action = new Actions();
            action.Run();
            Console.WriteLine("Hello, World!");
        }
    }
}