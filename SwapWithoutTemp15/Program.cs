using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithoutTemp15
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        void SwapNumbers(ref int a ,ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            //Usage
            int x = 5, y = 10;
            SwapNumbers(ref x, ref y);
            Console.WriteLine($"x:{x},y:{y}");//output:x:10,y:5
        }
        


    }
}
