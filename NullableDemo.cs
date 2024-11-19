using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class NullableDemo
    {
        static void Main(string[] args)
        {
            int? i = null;
            int j = 10;

            if (Nullable.Compare<int>(i, j) < 0)
            {
                Console.WriteLine("i<j");
            }
            else if (Nullable.Compare<int>(i, j) > 0)
            {
                Console.WriteLine("i>j");
            }
            else {
                Console.WriteLine("i=j");
            }
        } 
    }
}
