namespace maze
{
    internal struct PathResult
    {
        public List<Coordinate> path = new List<Coordinate>();
        public List<Coordinate> searchOrder = new List<Coordinate>();

        public PathResult(List<Coordinate> path, List<Coordinate> searchOrder)
        {
            this.path = path;
            this.searchOrder = searchOrder;
        }

    }
}
