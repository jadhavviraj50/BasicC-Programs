using System;
using System.Collections.Generic;
using System.Text;


namespace BasicPrograms
{
    public class EvenOdd
    {
        public void checkEvenOdd()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
    }
}


