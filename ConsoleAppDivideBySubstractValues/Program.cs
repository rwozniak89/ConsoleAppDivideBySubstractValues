using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDivideBySubstractValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int d = 3;
            bool is_d_minus = false;
            bool is_a_minus = false;

            Console.WriteLine("Podaj dzielną a: (jak pusto lub błąd przypisze 7)");
            string sa = Console.ReadLine();
            try { a = int.Parse(sa); }
            catch (Exception) { Console.WriteLine("podano liczbę niecałkowitą, dlatego ustalono wartość na 7"); }

            Console.WriteLine("Podaj dzielnik d: (jak pusto lub błąd przypisze 3)");
            string sd = Console.ReadLine();
            try { d = int.Parse(sd); }
            catch (Exception) { Console.WriteLine("podano liczbę niecałkowitą, dlatego ustalono wartość na 3"); }

            //warunek
            if (d < 0)
            {
                d = d * (-1);
                is_d_minus = true;
            }
            //warunek
            if (a < 0)
            {
                a = a * (-1);
                is_a_minus = true;
            }

            int r = a;
            int q = 0;
            //pętla
            while (r-d >=0)
            {
                r = r - d;
                q++;
            }

            //warunki
            if (is_a_minus && r != 0) { q++; r++; }
            if (is_d_minus == true && is_a_minus == false) { q = q * -1; }
            if (is_d_minus == false && is_a_minus == true) { q = q * -1; }


            Console.WriteLine("Dzielna a={0}, dzielnik d={1}, iloraz q={2}, reszta r={3}", a, d, q, r);

            Console.ReadKey();

        }
    }
}
