using System;

namespace ageComparison___20._08._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name and age for the Person 1: ");

            string name1 = Console.ReadLine();

            int age1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the name and age for the Person 2: ");

            string name2 = Console.ReadLine();

            int age2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Can you guess who is older? ");

        nameEntering:
            string guessedName = Console.ReadLine();

            if (guessedName == name1)
            {
                if (age1 > age2)
                {
                    Console.WriteLine("The answer is correct. {0} is {2} years older than {1}. ", name1, name2, age1 - age2);
                }

                else
                {
                    Console.WriteLine("The answer is incorrect. Please try again.");
                    goto nameEntering;
                }
            }

            else if (guessedName == name2)
            {
                if (age1 < age2)
                {
                    Console.WriteLine("The answer is correct. { 0 } is { 2 } years older than { 1}."
                    , name2, name1, age2 - age1);
                }

                else
                {
                    Console.WriteLine("The answer is incorrect. Please try again. ");
                    goto nameEntering;
                }
            }

            else
            {
                Console.WriteLine("Please choose one of previously entered names.");
                goto nameEntering;
            }

        }
    }
}
