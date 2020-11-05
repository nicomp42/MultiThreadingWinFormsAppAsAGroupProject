/*
 * Christian Grothaus grothact@mail.uc.edu
 * Assignment 07
 * IT3045C/001/2020
 * Due 11/5/2020
 * Implement the RunThread and SayHello methods in your beast.
 * Citations: None
 */
using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class DoggedDog : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("My class name is " + this.GetType().Name);
        }
        public override void RunThread()
        {
            int factorRequest = Int32.Parse(request);
            int factor = factorRequest - 1;
            for (int i = factorRequest - 1; factorRequest % factor != 0; i--) // Finds the highest factor of the number given by the String request.
            {
                factor = i;
            }
            response = $"{factor}";
        }

    }
}
