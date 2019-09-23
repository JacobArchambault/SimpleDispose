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
            MyResourceWrapper rw = new MyResourceWrapper();
            if (rw is IDisposable)
                rw.Dispose();
            DisposeFileStream();

            Console.ReadLine();
        }

        static void DisposeFileStream()
        {
            FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);

            // These method calls do the same thing. Confusing, to say the least.
            fs.Close();
            fs.Dispose();
        }
    }
}
