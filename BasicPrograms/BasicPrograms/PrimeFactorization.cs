using System;
using System.Collections.Generic;
using System.Text;


namespace BasicPrograms
{
    public class PrimeFactorization
    {
        public void primeFactors()
        {
            int a, b;
            Console.WriteLine("Please enter number: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
            Console.ReadLine();
        }

    }
}
