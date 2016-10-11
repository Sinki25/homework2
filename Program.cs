using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, s, e, f, y, n, s0;
            e = 0.0001;
            x = double.Parse(Console.ReadLine());
            a = double.Parse(Console.ReadLine());
            s = 0;
            n = 0;
            y = 1;
            f = 1;
            s0 = 1;       
            while (Math.Abs(s - (s - s0)) > e)
            {
                for (int i = 1; i < n; i++)
                {
                    y = y * x;
                    f = f * i;
                }
                s0 = s0 * y / f;
                for (int i = 0; i <= a - 1; i++)
                    s0 = s0 * (a - i);
                s = s + s0;
                n++;

            }
            Console.WriteLine(s);
            Console.WriteLine("Шаг равен {0}", n - 1);
        }
    }
}

