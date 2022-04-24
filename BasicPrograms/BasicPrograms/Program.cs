using System;
namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("Select Number\n1)Leap Year \n2)Even odd\n3)FlipCoinPercentage\n4)HarmonicNumber");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        LeapYear leap = new LeapYear();
                        leap.checkLeapYear();
                        break;
                    case 2:
                        EvenOdd even = new EvenOdd();
                        even.checkEvenOdd();
                        break;
                    case 3:
                        FlipCoin coin = new FlipCoin();
                        coin.flipCoinPercentage();
                        break;
                    case 4:
                        HarmonicNumber harmonic = new HarmonicNumber();
                        harmonic.harmonicNumber();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}