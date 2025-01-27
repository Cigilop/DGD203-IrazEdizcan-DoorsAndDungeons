using System;
using System.Collections.Generic;

namespace DoorsAndDungeons
{
    class Map
    {
        private Dictionary<(int, int), Location> locations;

        public Map()
        {
            locations = new Dictionary<(int, int), Location>();
            InitializeMap();
        }

        private void InitializeMap()
        {
            locations[(0, 0)] = new Location("Starting Point", "You find yourself at the start of the spooky and empty dungeon. Where do you want to move next? (North: W, West: A South: S, East: D)");
            locations[(3, 1)] = new Location("Blue Door", "A blue door stands here.", null, new Door("Blue Door", "Blue Key"));
            locations[(-3, -1)] = new Location("Blue Key", "You found a blue key. Find the correct door to open.", new Item("Blue Key", "A shiny blue key."), null);
            locations[(-1, 1)] = new Location("Red Door", "A red door stands here.", null, new Door("Red Door", "Red Key"));
            locations[(1, -1)] = new Location("Red Key", "You found a red key. Find the correct door to open.", new Item("Red Key", "A shiny red key."), null);
        }

        public void DisplayLocationDescription((int, int) position)
        {
            if (locations.ContainsKey(position))
            {
                Console.WriteLine(locations[position].Description);
            }
            else
            {
                Console.WriteLine("There is nothing here. Where do you want to move next? (North: W, West: A South: S, East: D)");
            }
        }
        // I asked Copilot for this part for specified positions.
        public bool HasItem((int, int) position) => locations.ContainsKey(position) && locations[position].Item != null;

        public Item GetItem((int, int) position) => locations.ContainsKey(position) ? locations[position].Item : null;

        public void RemoveItem((int, int) position)
        {
            if (locations.ContainsKey(position))
            {
                locations[position].Item = null;
            }
        }

        public bool HasDoor((int, int) position) => locations.ContainsKey(position) && locations[position].Door != null;

        public Door GetDoor((int, int) position) => locations.ContainsKey(position) ? locations[position].Door : null;
    }
}
