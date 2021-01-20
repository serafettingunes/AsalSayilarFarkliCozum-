using System;
using System.Collections;

namespace AsalSayilarFarkliCozum
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            int sayac = 0;
            for (int i = 2; i <= 1000; i++)
            {
                for (int J = 1; J <= i; J++)
                {
                    if (i % J == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 2)
                {
                    ar.Add(i);

                }
                sayac = 0;
            }

            foreach (var x in ar)
            {
                Console.WriteLine(x);
            }

        }
    }
}
