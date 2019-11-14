using System;
using System.Diagnostics.Tracing;

namespace Number_of_Proper_Fractions_with_Denominator_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProperFractionsSolution.ProperFractions(987764257));
            Console.ReadLine();
        }

        public class ProperFractionsSolution
        {
            public static long ProperFractions(long n)
            {
                if (n == 0 || n < 0)
                {
                    return 0;
                }

                int counter = 0;

                for (long i = 1; i <= n; i++)
                {
                    long gcd = Gcd(i, n);

                    if (gcd == 1)
                    {
                        counter += 1;
                    }
                    
                }

                return counter;
            }

            public static long Gcd(long a, long b)
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                        a %= b;
                    else
                        b %= a;
                }

                return a == 0 ? b : a;
            }
        }
    }
}
