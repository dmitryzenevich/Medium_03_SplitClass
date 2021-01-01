namespace SplitClass
{
    public abstract class Character : ICharacter
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}