/*
 * Travis Newberry
 * newberts@mail.uc.edu
 * 34IT3045C
 * Assignemnt07
 * 11/5/2020
 * A FranticFox that says hello and finds the larges prime factor of a number.
 * Citations: NA
 * ExtraNotes: NA
 */
/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Windows.Forms;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class FranticFox : FantasticBeast
    {
        /// <summary>
        /// Prints a message to the console saying hello from this class
        /// </summary>
        public override void SayHello()
        {
            try
            {
                Console.WriteLine(this.GetType().Name + " frantically says hello");
            }
            catch (Exception) 
            {
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// Tests to find the largest prime factor of request and puts it in response
        /// </summary>
        public override void RunThread()
        {
            try
            {
                int testnum = Int32.Parse(request);
                for (int i = 2; i * i <= testnum;)
                {
                    if (testnum % i == 0)
                    {
                        testnum /= i;
                    }
                    else
                    {
                        i++;
                    }
                }
                response = testnum.ToString();
            }
            catch (Exception) 
            { 
                throw new NotImplementedException();
            }
        }

    }
}
