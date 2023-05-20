namespace PSEClassLibrary
{
    public class Module
    {
        public string Name { get; set; } = "";
        public IList<Point2D> Route { get; } = new List<Point2D>();
    }
}
