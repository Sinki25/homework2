using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, e, s, n, y, f;

            e = 0.00001;
            a = Double.Parse(Console.ReadLine());
            x = Double.Parse(Console.ReadLine());     
            n = 1;
            y = -1 + a;
            f = 1;
            s = y * x * Math.Log(x) * Math.Log(x) / f;
            while (Math.Abs(s-(s - (y * x * Math.Log(x) * Math.Log(x) / f))) >e)
            {
                y = 1;
                for (int i = 1; i <= n; i++)
                    y = y * (-1 + a);
                f = f * n;                                 
                s = s + (y * x * Math.Log(x) * Math.Log(x) / f);
                n++;
            }
            Console.WriteLine(s);
            Console.WriteLine("Шаг равен {0}", n-1);



        }
    }
}

