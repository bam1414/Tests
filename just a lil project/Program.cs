using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace just_a_lil_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 22;

            x = y + x;
            y = x * y;
            Console.WriteLine(y);
            Console.ReadKey(true);

            }
    }
}
