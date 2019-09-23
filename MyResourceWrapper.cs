using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDispose
{
    class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            // Clean up unmanaged resources...
            // Dispose other contained disposable objects...
            // Just for a test.
            Console.WriteLine("***** In Dispose! *****");
        }
    }
}
