using System;
namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("Select Number\n1)Leap Year \n2)Even odd\n3)FlipCoinPercentage\n4)HarmonicNumber\n5)PrimeFactorization\n6)QuotientRemainder\n7)SwapNumbers\n8)Largestof3Number\n9)VowelConsonant");
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
                    case 5:
                        PrimeFactorization factorization = new PrimeFactorization();
                        factorization.primeFactors();
                        break;
                    case 6:
                        QuotientRemainder quotientRemainder = new QuotientRemainder();
                        quotientRemainder.quotient();
                        break;
                    case 7:
                        SwapNumber swapNumber = new SwapNumber();
                        swapNumber.swap();
                        break;
                    case 8:
                        Largestof3 large = new Largestof3();
                        large.largest();
                        break;
                    case 9:
                        VowelConsonant checkVowel = new VowelConsonant();
                        checkVowel.vowel();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}