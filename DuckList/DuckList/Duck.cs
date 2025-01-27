namespace DuckList
{
    internal class Duck (int size, KindOfDuck kind) : Bird, IComparable<Duck>
    {
        public int Size { get { return size; } }
        public KindOfDuck Kind { get { return kind; } }

        public int CompareTo(Duck? other)
        {
            if (other == null) return 0;
            if (this.Size > other.Size) return 1;
            else if (this.Size < other.Size) return -1;
            else return 0;
        }
        public override string ToString()
        {
            return $"A {size} inch {kind}";
        }
    }
}
