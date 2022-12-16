using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                string s = Console.ReadLine();

                int a1 = Int32.Parse(s.Split(' ')[0]);
                int b1 = Int32.Parse(s.Split(' ')[1]);
                int c1 = Int32.Parse(s.Split(' ')[2]);
                int a2 = Int32.Parse(s.Split(' ')[3]);
                int b2 = Int32.Parse(s.Split(' ')[4]);
                int c2 = Int32.Parse(s.Split(' ')[5]);


                int result = (a2 * 3600 + b2 * 60 + c2) - (a1 * 3600 + b1 * 60 + c1);

                int h = result / 3600;
                int m = (result % 3600) / 60;
                int second = result % 60;
                Console.WriteLine("{0} {1} {2}", h, m, second);
            }
        }
    }