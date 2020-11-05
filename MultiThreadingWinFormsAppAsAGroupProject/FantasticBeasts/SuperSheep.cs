/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class SuperSheep : FantasticBeast
    {
        public override void SayHello() {
            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            msg = "Hello from SuperSheep.RunThread()";
            long num = Convert.ToInt64(request);
            long largoPrime = -1;
            while (num % 2 == 0)
            {
                largoPrime = 2;
                num >>= 1;
            }
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    largoPrime = i;
                    num = num / i;
                }
            }
            if (num > 2)
                largoPrime = num;

            response = Convert.ToString(largoPrime);
        }

    }
}
