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
            int x = 0;
            int y = 55;

            x = y + x;
            y = x * y;
            Console.WriteLine(y);
            Console.ReadKey(true);

            }
    }
}
