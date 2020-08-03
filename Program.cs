using System;

namespace hello_console
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = BuildMessage("Andrew");

            Console.WriteLine(message);
        }



        static String BuildMessage(String name)
        {
            return "Hello " + name + "!";
        }
    }
}
