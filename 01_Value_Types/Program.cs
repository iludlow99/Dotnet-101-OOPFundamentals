using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 1;

            bool False = false;

            char Char = (char)89;

            decimal Decimal = 967.35m;

            double Double = 47.23;

            float Float = 235;

            short Short = 3;

            long Long = 3498598;

            byte? Byte = 4;

            Console.WriteLine(Byte.HasValue);
        }
    }
}
