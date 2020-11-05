/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */



/*
 * Alex Moore
 * Moore5ar@mail.uc.edu
 * Assignment 07 
 * Contemporary Porgramming IT3045C
 * Due November 5th, 2020
 * Multi Threading Windows Forms App As A Group Project
 */

using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class AdorableAnt : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello From" + this.GetType().Name);
        }
        public override void RunThread()
        {


            long num = Convert.ToInt64(request);
            response = Convert.ToString(BiggestPrimeFactor(num));
        }
        private static long BiggestPrimeFactor(long num)
        {
            long a = 2;
            while (a * a <= num)
            {
                if (num % a == 0)
                {
                    num /= a;
                }
                else
                {
                    ++a;
                }
            }

            return num;
        }
    }
}
