namespace maze
{
    internal struct PathResult
    {
        private List<Coordinate> path { get; } = new List<Coordinate>();
        private List<Coordinate> searchOrder { get; } = new List<Coordinate>();

        public PathResult(List<Coordinate> path, List<Coordinate> searchOrder)
        {
            this.path = path;
            this.searchOrder = searchOrder;
        }

    }
}
