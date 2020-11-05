/*
 * Blake Barr
 * IT3045C
 * Assignment 07
 * Due Date: November 5 2020
 * Description: This class will be joined with many others in a shared repo.
 * Citation: Past Assignments and notes
 */

/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Dynamic;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world.
    /// This canary has the ability to tweet back the largest prime factor of a number
    /// </summary>
    class CrucialCanary : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello, I am a " + this.GetType().Name); // Some say this was impossible
        }
        public override void RunThread()
        {
            int num = Convert.ToInt32(request);

            int largestPFactor = 0;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) // check factor for primeness
                {
                    bool isPrime = true;
                    for (int j = 2; j < i / 2; j++)
                    {

                        if (i % j == 0)
                        {
                            isPrime = false;
                        }


                    }

                    if (isPrime == true)
                    {
                        largestPFactor = i; // if it's prime, change it to that number. larger primes will replace the smaller ones because of how the loop works
                    }
                }
            }

            if (largestPFactor != 0)
            {
                response = Convert.ToString(largestPFactor);
            }
            else
            {
                response = "None"; // in the case that there exists no prime
            }
        }
    }
}
