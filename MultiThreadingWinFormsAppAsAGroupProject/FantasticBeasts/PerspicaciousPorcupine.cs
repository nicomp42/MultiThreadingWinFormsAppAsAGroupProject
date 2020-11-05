/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;

namespace MultiThreadingWinFormsAppAsAGroupProject {
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class PerspicaciousPorcupine : FantasticBeast {
        public override void SayHello() {
            // printing the name of this class (dynamically) in a friendly message
            Console.WriteLine("Hello, this is " + this.GetType().Name + ". Nice to meet you.");
        }
        public override void RunThread() {
            // parsing request member from string into int
            if (Int32.TryParse(request, out int requestInt)) {
                // initializing largest prime factor candidate with smallest possible prime number to begin
                int largestPrimeFactor = 2;
                // iterating candidate up to largest number smaller than request member
                while (requestInt > largestPrimeFactor) {
                    // if largest prime factor candidate is a factor of request, halve request number and recheck 
                    // otherwise increment largest prime factor candidate
                    if (requestInt % largestPrimeFactor == 0) {
                        requestInt /= largestPrimeFactor;
                        largestPrimeFactor = 2;
                    }
                    else {
                        largestPrimeFactor++;
                    }
                }
                // store the largest prime factor in response member
                response = largestPrimeFactor.ToString();
            }
            // error if request member can not be parsed
            else {
                Console.WriteLine("Request is not a number.");
            }
        }
    }
}
