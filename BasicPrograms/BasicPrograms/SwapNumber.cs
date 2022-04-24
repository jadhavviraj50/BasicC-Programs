using System;
using System.Collections.Generic;
using System.Text;


namespace BasicPrograms
{
    public class SwapNumber
    {
        public void swap()
        {
            int a, b, c;
            Console.WriteLine("Enter the First Number : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number : ");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + a);
            Console.WriteLine("Second Number : " + b);
            Console.Read();
        }
    }
}
