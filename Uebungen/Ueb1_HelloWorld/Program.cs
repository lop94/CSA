using System;

namespace Ueb1_HelloWorld
{
    class Program
    {
        private static void PrintMessage(string msg, bool upperCase)
        {
            if(upperCase)
            {
               msg = msg.ToUpper(); 
            }
            Console.WriteLine(msg); 
        }

        static void Main(string[] args)
        {
            PrintMessage("Hello World", false);
            PrintMessage("hello World", true); 

            Console.Read(); 
        }
    }
}
