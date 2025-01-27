using System;

namespace DoorsAndDungeons
{
    class Menu
    {
        public void DisplayMainMenu()
        {
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                Console.WriteLine("Welcome to DoorsAndDungeons");
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. Credits");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        isValidChoice = true;
                        Game game = new Game();
                        game.Start();
                        break;
                    case "2":
                        isValidChoice = true;
                        DisplayCredits();
                        break;
                    case "3":
                        isValidChoice = true;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You are returning to the main menu. Please try again.");
                        break;
                }
            }
        }

        private void DisplayCredits()
        {
            Console.WriteLine("Credits:");
            Console.WriteLine("Coded by Iraz Edizcan");
            Console.WriteLine("School number: 2305041042");
            Console.WriteLine("I got helped from Copilot just for one part of this code (in Map.cs)");
        }
    }
}
