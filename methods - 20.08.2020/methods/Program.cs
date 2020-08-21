using System;

namespace methods
{
    class Program
    {
        static string askName ()
        {
            string name = Console.ReadLine();

            return name; 
        }

        static int askAge ()
        {
            int age = Int32.Parse(Console.ReadLine());

            return age; 

        }

        static bool checkName (string name1, string name2, string guessedName) 
        {
            if (guessedName == name1 || guessedName == name2)
            {
                return true; 
            }

            return false; 
        
        }

        static bool compareAges (string name1, string name2, int age1, int age2, string guessedName)
        {
            if (guessedName == name1 & age1 - age2 >= 0)
            {
                return true;  
            }

            else if (guessedName == name2 & age2 - age1 >= 0)
            {
                return true; 
            }

            else
            {
                return false; 
            }
        }

        static int calculateDifference (int age1, int age2)
        {
            int difference = 0; 
            if (age1 > age2)
            {
                difference = age1 - age2;
                return difference; 
            }
            else if (age1 < age2)
            {
                difference = age2 - age1;
                return difference; 
            }
            else
            {
                difference = 0;
                return difference; 
            }

        }

        static string whoIsYounger (string name1, string name2, int age1, int age2)
        {
            if (age1 < age2)
            {
                return name1; 
            }

            else
            {
                return name2; 
            }
        }


        static void Main(string[] args)
        {
                                  

            Console.WriteLine("Please enter the name and age for the Person 1: ");

            string name1 = askName();

            int age1 = askAge();       

            Console.WriteLine("Please enter the name and age for the Person 2: ");

            string name2 = askName();

            int age2 = askAge();

            Console.WriteLine("Can you guess who is older? ");

            nameEntering:
            string guessedName = Console.ReadLine();

            if (checkName(name1, name2, guessedName))
            {
                if (compareAges(name1, name2, age1, age2, guessedName))
                {
                    if (age1 == age2)
                    {
                        Console.WriteLine("They are the same age.");

                    }

                    else
                    {
                        
                    Console.WriteLine("The answer is correct. " + guessedName + " is " + calculateDifference(age1, age2) + " years older than " + whoIsYounger(name1, name2, age1, age2) + ".");
                    
                    }
                }

              
                else
                {
                    Console.WriteLine("The answer is incorrect. Please try again.");
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
