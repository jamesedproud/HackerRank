using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            string choice;
            string[] options = new string[] {"Array Manipulation","String Manipulation","Sorting","Math Functions"};
            MenuMaker("hacker rank challenges", "default", 4, options, "Selection: ");
            choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.Clear();
                    ArrayManipulation();
                    break;
                case "2":
                    Console.WriteLine("Not Implemented");
                    MainMenu();
                    break;
                case "3":
                    Console.WriteLine("Not Implemented");
                    MainMenu();
                    break;
                case "4":
                    Console.Clear();
                    MathFunctions();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
            }
        }

        static void MenuMaker(string title, string description, int noOfOptions, string[] options, string inputText)
        {
            Console.Clear();
            Console.WriteLine($"- - - - - - - - {title.ToUpper()} - - - - - - - - - ");
            Console.WriteLine("");

            if (description == "default")
                Console.WriteLine("Please select an option:    (b --> back)    (exit --> close application)");
            else
                Console.WriteLine($"DESCRIPTION: {description}");

            Console.WriteLine("--------------------------------------------");

            if (noOfOptions > 0) //check whether it is a menu or a challenge
            {
                for (int i = 0; i < noOfOptions; i++)
                {
                    Console.WriteLine($"{i + 1}: {options[i]}");
                }
            }


            Console.WriteLine("");
            Console.WriteLine($"{inputText}");
        }


        static void ArrayManipulation()
        {
            string[] options = new string[] {"Array: Left Rotation"};
            MenuMaker("Array manipulation", "default", 1, options, "Selection: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":

                    MenuMaker("array: left rotaion", "A left rotation operation on an array shifts each of the array's elements  unit to the left. For example, if 2 left rotations are performed on array [1,2,3,4,5] , then the array would become [3,4,5,1,2]",0,null, "Please enter numbers seperated by commas: ");
                    string word = Console.ReadLine();

                    if (word == "b")
                        MainMenu();

                    Console.WriteLine("Please enter a value n (no. of left shifts)");
                    Console.Write("N = ");
                    int n = int.Parse(Console.ReadLine());

                    if (word == "b")
                    {
                        ArrayManipulation();
                    }

                    ArrayChallenges.LeftRotation(word, n);
                    break;


                 case "b":
                    Console.Clear();
                    MainMenu();
                    break;

            }
        }


        static void MathFunctions()
        {
            string[] options = new string[] {"Factorial","Fibonacci"};
            MenuMaker("math functions", "default", 2, options, "Selection: ");
            string choice = Console.ReadLine();
            string word;
            int num;

            switch (choice)
            {
                case "1":
                    MenuMaker("factorial", "A factorial (!) of a positive integer number is the product of all positive integers less than or equal to the number.", 0, null, "Please enter a number: ");
                    word = Console.ReadLine();

                    if (word == "b")
                    { 
                        MathFunctions();
                    }

                    num = int.Parse(word);

                    Console.WriteLine(num + "! = " + MathChallenges.RecursiveFactorial(num));
                    Console.ReadLine();
                    break;

                case "2":
                    MenuMaker("Fibonacci", "The Fibonacci sequence is the sequence defined by F(0) = 0, F(1) = 1, F(n + 2) = F(n) + F(n + 1). The first few terms are 0, 1, 1, 2, 3, 5, 8.", 0, null, "Please enter a value for n: ");
                    word = Console.ReadLine();

                    if (word == "b")
                    {
                        MathFunctions();
                    }

                    num = int.Parse(word);

                    Console.WriteLine($"the {num}th Fibonacci Number is: " + MathChallenges.Fibonacci(num));
                    break;

                case "b":
                    MainMenu();
                    break;
            }

            MathFunctions();

        }



    }
}
