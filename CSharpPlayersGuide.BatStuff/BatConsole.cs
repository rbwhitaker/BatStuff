using System;

namespace BatConsole
{
    public class BatConsole
    {
        public static void WriteLine(string message)
        {
            Console.WriteLine($"Holy {message}, Batman!");
        }

        public static void Write(string message)
        {
            Console.Write($"Holy {message}");
        }
    }
}
