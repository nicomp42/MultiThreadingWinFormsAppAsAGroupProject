/*
 * Joseph Wilson
 * Assignment 07
 * IT3045C Fall Semester
 * Dues 11/05/2020
 * We are multi threading the githubs
 * PassionatePanda shall rise
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class PassionatePanda : FantasticBeast
    {
        public override void SayHello()
        {
            //Found this as a possible solution
            Console.WriteLine("Hello from " + typeof(PassionatePanda).Name);
        }
        public override void RunThread()
        {
            msg = "Hello from PassionatPanda.RunThread()";
            Thread.Sleep(2000);
            //Reused code and compiled to get 
            long maxFactor(long n)
            {
                for (long x = n / 2; x > 1; x--)
                {
                    if (n % x == 0 && prime(x))
                    {
                        return x;
                    }
                }

                // no factors found
                return 1;
            }

            //Reused code and compiled to get 
            bool prime(long y)
            {
                bool susPrime = true;
                for (long i = 2; i <= y / 2; i++)
                {
                    if (y % i == 0)
                        susPrime = false;
                }
                return susPrime;
            }
            long num = Convert.ToInt64(request);
            //Used the prime factor checker to check the request.
            response = Convert.ToString(maxFactor(num));
            
        }

    }
}
