using System;
using System.IO;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Dispose *****\n");
            // Create a disposable object and call Dispose() to free any internal resources.
            using (MyResourceWrapper rw = new MyResourceWrapper(), rw2 = new MyResourceWrapper())
            {
                // Use rw and rw2 objects
            }

            Console.ReadLine();
        }

    }
}
