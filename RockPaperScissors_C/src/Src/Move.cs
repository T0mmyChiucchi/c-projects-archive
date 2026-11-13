namespace Src
{
    public abstract class Move
    {
        public string Name { get; set; }
        public Move() { }

        public abstract int CompareTo(Move otherMove);
    }
}
