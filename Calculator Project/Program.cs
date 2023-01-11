using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine("Hello World bbsita");
#if DEBUG
                Console.WriteLine("Debug cersion");
#else
            Console.WriteLine("Release Version");
#endif
            if (i == 1)
                Console.WriteLine("Hello World bbsita");
        }
        
    }
    
}
