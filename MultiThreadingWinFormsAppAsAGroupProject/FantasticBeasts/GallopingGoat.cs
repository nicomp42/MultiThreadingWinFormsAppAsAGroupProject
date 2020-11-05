/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */

/*
 * Gage Goodheart
 * goodheaga@mail.uc.edu
 * Assignment 07
 * 11/6/2020
 * Implmented SayHello() and RunThread() methods for GallopingGoat beast
 * Citation - https://stackoverflow.com/questions/2535251/c-finding-the-largest-prime-factor-of-a-number/2535285#2535285
 */

using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class GallopingGoat : FantasticBeast
    {
        public override void SayHello()
        {
            // Get the name of fantasitic beast
            Console.WriteLine("Hello from " + this.GetType().Name);
        }
        public override void RunThread()
        {
            // Calls to LargestPrimeFactor and stores it
            long number = Convert.ToInt64(request);
            response = Convert.ToString(LargestPrimeFactor(number));
        }
        private static long LargestPrimeFactor(long number)
        {
            long i = 2;
            while (i * i <= number)
            {
                if (number % i == 0)
                {
                    number /= i;
                }
                else
                {
                    ++i;
                }
            }
            return number;
        }

    }
}
