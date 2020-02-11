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
            int choice;

            Console.WriteLine("- - - - - - - - - - HACKER RANK CHALLENGES - - - - - - - - - - - ");
            Console.WriteLine("");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. Array Manipulation");
            Console.WriteLine("2. String Manipulation");
            Console.WriteLine("3. Sorting");
            choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.Clear();
                    ArrayManipulation();
                    break;

            }
        }


        static void ArrayManipulation()
        {
            Console.WriteLine("- - - - - - - - - - ARRAY MANIPULATION - - - - - - - - - - - ");
            Console.WriteLine("");
            Console.WriteLine("Please select an option:    (b --> back)");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. Sock Merchant");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter numbers seperated by commas");
                    string word = Console.ReadLine();
                    ArrayChallenges.SockMerchant(word);
                    break;
                case "b":
                    Console.Clear();
                    MainMenu();
                    break;

            }
        }

    }
}
