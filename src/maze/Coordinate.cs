namespace maze
{
    internal class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinate(Coordinate other)
        {
            this.x = other.x;
            this.y = other.y;
        }

        public override string ToString()
        {

            return "(" + x + "," + y + ")";
        }
        public void printDebug()
        {
            System.Diagnostics.Debug.Write(this);
        }

        public void printDebugln()
        {
            System.Diagnostics.Debug.WriteLine(this);
        }

        public bool Equals(Coordinate other)
        {
            return x == other.x && y == other.y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            else
            {
                Coordinate objAsPart = obj as Coordinate;
                if (objAsPart == null) return false;
                else return Equals(objAsPart);
            }
        }
        public static bool operator==(Coordinate a, Coordinate b)
        {
            return a.Equals(b);
        }
        public static bool operator!=(Coordinate a, Coordinate b)
        {
            return !a.Equals(b);
        }
    }
}
