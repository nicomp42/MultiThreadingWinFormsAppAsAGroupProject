/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
/*
 * Name: Dylan Pyles
 * eMail: pylesdn@mail.uc.edu
 * Assignment #: 7
 * Due Date: 11/05/2020
 * Course / Semester / Year: IT3045C / Fall/ 2020
 * Description : My Fantastic Beast, CasualCheetah. Finds the largest prime factor.
 */
using System;
using System.Threading;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class CasualCheetah : FantasticBeast
    {
        public override void SayHello()
        {
            // prints the name of the class in a friendly message
            Console.WriteLine("Hello from " + this.GetType().Name + ". I am probally faster than all of you");
        }
        public override void RunThread()
        {
            Thread.Sleep(2000);
            // convert the value of request so it can be used in the LargestPrimeFactor method
            long num = Convert.ToInt64(request);
            response = Convert.ToString(LargestPrimeFactor(num));
        }
        /// <summary>
        /// Finds the largest prime factor of the value 'request'
        /// Created a new private method for calcutating, then referenced it in the RunThread() method
        /// Kept the algorithm as simple as possible for the fastest execution time.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>num</returns>
        private static long LargestPrimeFactor(long num)
        {
            // variable to store the value of the possible largest prime factor
            long i = 2;
            // while loops checks i for a match, and loops until one is found by adding 1 each time.
            while (i * i <= num)
            {
                if (num % i == 0)
                {
                    num /= i;
                }
                else
                {
                    ++i;
                }
            }

            return num;
        }
    }
}
