namespace DoorsAndDungeons
{
    class Door
    {
        public string Name { get; }
        public string RequiredKey { get; }

        public Door(string name, string requiredKey)
        {
            Name = name;
            RequiredKey = requiredKey;
        }
    }
}
