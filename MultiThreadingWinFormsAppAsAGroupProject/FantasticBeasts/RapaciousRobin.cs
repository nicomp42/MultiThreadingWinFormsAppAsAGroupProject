/*
 * Steven Bower
 * bowersd@mail.uc.edu
 */
using System;
using System.Threading;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class RapaciousRobin : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            msg = "Hello from RapaciousRobin.RunThread()";
            Thread.Sleep(2000);
            long num = Convert.ToInt64(request);
            response = Convert.ToString(LargestPrimeFactor(num));
        }

        private static long LargestPrimeFactor(long num)
        {
            long j = 2;
            while (j * j <= num)
            {
                if (num % j == 0)
                {
                    num /= j;
                }
                else
                {
                    ++j;
                }
            }
            return num;
        }
    }
}
