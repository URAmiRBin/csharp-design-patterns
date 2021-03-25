using System;
using Factory;

namespace csharp_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Run(args[0]);
        }
    }
}
