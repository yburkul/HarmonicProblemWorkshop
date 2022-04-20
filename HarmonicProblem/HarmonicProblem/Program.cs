using System;

//Harmonic Number
//a. Desc ­> Prints the Nth harmonic number: 1 / 1 + 1 / 2 + ... +1 / N
//    (http://users.encs.concordia.ca/~chvatal/notes/harmonic.html).
//    b.I / P ­> The Harmonic Value N.Ensure N != 0
//    c.Logic ­> compute 1 / 1 + 1 / 2 + 1 / 3 + ... +1 / N
//    d.O / P ­> Print the Nth Harmonic Value.

namespace HarmonicProblem
{
    class Program
    {
        public static void Main(string[] arg)
        {
            int N = 1;
            float Harmonic = 0;
            Console.WriteLine("Enter a number");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Harmonic += 1 /(float) i;
            }
            Console.WriteLine("Nth Harmonic Value is: " + Harmonic);
        }

    }
}