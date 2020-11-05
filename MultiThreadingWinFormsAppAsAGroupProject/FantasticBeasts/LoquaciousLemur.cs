/*
 * Brandon Zachary
 * zacharba@mail.uc.edu
 * IT3045-001 - Fall2020
 * Assignment 07
 * Attempt Due Date: 11/05/2020
 * This is my Beast, LoquaciousLemur. In this class, I have implemented both the RunThread() method, and the SayHello() method. Run thread returns the largest prime factor in 'request' and sets the largest prime factor as 'response'. SayHello() prints a message as well as the name of the class (or the name of my beast) to the console.
 * Citation: https://stackoverflow.com/questions/2113069/c-sharp-getting-its-own-class-name --> used to determine how to return the name of the class.
 */

using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class LoquaciousLemur : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Greetings, from " + this.GetType().Name);
        }
        public override void RunThread()
        {
            long num = Convert.ToInt64(request);
            long largestPrime = -1;

            while (num % 2 == 0)
            {
                largestPrime = 2;
                num /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    largestPrime = i;
                    num = num / i;
                }
            }

            if (num > 2)
            {
                largestPrime = num;
            }

            response = Convert.ToString(largestPrime);

        }

    }
}
