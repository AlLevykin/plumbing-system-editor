namespace PSEClassLibrary
{
    public class Project
    {
        public string Name { get; set; } = "";
        public string ModuleName { get; set; } = "";
        public Entry Waste { get; set; } = new Entry();
        public IList<Entry> Drains { get; } = new List<Entry>();
    }
}