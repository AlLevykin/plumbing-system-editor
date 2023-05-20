namespace PSEClassLibrary
{
    public class Library
    {
        public IList<Pipe> Pipes { get; } = new List<Pipe>();
        public IList<Fitting> Fittings { get; } = new List<Fitting>();
        public IList<Module> Modules { get; } = new List<Module>();
    }
}
