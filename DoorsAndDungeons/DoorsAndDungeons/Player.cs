using System.Collections.Generic;

namespace DoorsAndDungeons
{
    class Player
    {
        public (int X, int Y) Position { get; private set; }
        private List<Item> inventory;

        public Player()
        {
            Position = (0, 0);
            inventory = new List<Item>();
        }

        public void MoveNorth() => Position = (Position.X, Position.Y + 1);
        public void MoveSouth() => Position = (Position.X, Position.Y - 1);
        public void MoveEast() => Position = (Position.X + 1, Position.Y);
        public void MoveWest() => Position = (Position.X - 1, Position.Y);

        public void PickUpItem(Item item)
        {
            inventory.Add(item);
            Console.WriteLine($"{item.Name} has been added to your inventory.");
        }

        public bool OpenDoor(Door door)
        {
            foreach (var item in inventory)
            {
                if (item.Name == door.RequiredKey)
                {
                    return true;
                }
            }
            Console.WriteLine("You don't have the required key to open this door. Please find the correct key first.");
            return false;
        }
    }
}
