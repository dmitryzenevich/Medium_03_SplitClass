namespace SplitClass
{
    public abstract class Character : ICharacter
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
    }
}