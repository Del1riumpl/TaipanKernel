using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace TaipanKernel
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
        }
    }
}
