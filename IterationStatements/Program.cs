﻿namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void print()
        {
            for (int i = -1000; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void print2()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void IsEqual(int number1,int number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine( $"{number1} is equal to {number2}");

            }
            else
            {
                Console.WriteLine($"{number1} is Not equal to {number2}");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int number)
        {
            if(number >= 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative");
            }
            else
            {
                Console.WriteLine($"{number} is 0");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            Console.WriteLine("Enter your age");
            
            var age = int.Parse(Console.ReadLine());
           
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("Sorry, you cannot vote");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IsNumberInRage()
        {
            Console.WriteLine("Plese enter in a number:");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("Number is in range");
            }
            else
            {
                Console.WriteLine( "Number is not in range");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{i} x {num} = {i * num}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //print();
            //print2();
            //IsEqual();
            //EvenOrOdd();
            //PositiveOrNegative();
            //CanVote();
            //IsNumberInRage();
            //MultiplicationTable(5);
            //IsNumberInRage();
        }
    }
}
