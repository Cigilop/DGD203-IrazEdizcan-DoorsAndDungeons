using System;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;

namespace DoorsAndDungeons
{
    class Game
    {
        private Player player;
        private Map map;

        public Game()
        {
            player = new Player();
            map = new Map();
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine($"You are at location {player.Position.X}, {player.Position.Y}");
                map.DisplayLocationDescription(player.Position);

                if (map.HasItem(player.Position))
                {
                    Console.WriteLine("Do you want to pick up the item here? (yes/no)");
                    string pickUpResponse = Console.ReadLine();
                    if (pickUpResponse.ToLower() == "yes")
                    {
                        player.PickUpItem(map.GetItem(player.Position));
                        map.RemoveItem(player.Position);
                        Console.WriteLine("You picked up the key.");
                    }
                    else
                    {
                        Console.WriteLine("You didn't pick up the key. It is still laying here.");
                    }
                }

                if (map.HasDoor(player.Position))
                {
                    Console.WriteLine("Do you want to open the door here? (yes/no)");
                    string openDoorResponse = Console.ReadLine();
                    if (openDoorResponse.ToLower() == "yes")
                    {
                        bool success = player.OpenDoor(map.GetDoor(player.Position));
                        if (success && map.GetDoor(player.Position).Name == "Blue Door")
                        {
                            Console.WriteLine("Congratulations! You've opened the blue door and escaped!");
                            DisplayMainMenu();
                            break;
                        }
                        else if (success && map.GetDoor(player.Position).Name == "Red Door")
                        {
                            Console.WriteLine("You opened the red door and got killed by a monster. Game Over.");
                            DisplayMainMenu();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You don't have the right key to open this door.");
                        }
                    }
                }

                string command = Console.ReadLine();
                if (command == "w") player.MoveNorth();
                if (command == "s") player.MoveSouth();
                if (command == "a") player.MoveWest();
                if (command == "d") player.MoveEast();
            }
        }

        private void DisplayMainMenu()
        {
            Menu menu = new Menu();
            menu.DisplayMainMenu();
        }
    }
}
