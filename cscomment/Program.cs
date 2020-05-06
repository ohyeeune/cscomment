using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscomment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            //x = 2; y = 10;
            //x = 1; y = 4;
            x = 10; y = 2;

            if (x>4)
            {
                if(y>2)
                {
                    Console.WriteLine(x * y);
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
