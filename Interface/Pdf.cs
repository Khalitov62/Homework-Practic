using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class Pdf:MainPrintFile
    {
        public override void Print()
        {
            Console.WriteLine("Pdf cap edildi");
        }
    }
}
