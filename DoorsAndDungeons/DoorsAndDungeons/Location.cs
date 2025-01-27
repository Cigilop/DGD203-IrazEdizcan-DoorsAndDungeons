namespace DoorsAndDungeons
{
    class Location
    {
        public string Name { get; }
        public string Description { get; }
        public Item Item { get; set; }
        public Door Door { get; set; }

        public Location(string name, string description, Item item = null, Door door = null)
        {
            Name = name;
            Description = description;
            Item = item;
            Door = door;
        }
    }
}
