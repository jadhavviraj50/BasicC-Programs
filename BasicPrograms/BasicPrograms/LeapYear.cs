using System;
using System.Collections.Generic;
using System.Text;


namespace BasicPrograms
{
    public class LeapYear
    {
        public void checkLeapYear()
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year%4== 0) && (year % 100 != 0))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
