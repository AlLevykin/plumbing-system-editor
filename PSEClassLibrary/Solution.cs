using System.ComponentModel;
using IO = System.IO;

namespace PSEClassLibrary
{
    public class Solution
    {
        private string _path = "";

        [DisplayName("Папка"), Description("Папка для хранения рабочего пространства"), Category("Рабочее пространство")]
        public string Path { get { return _path; } }
        [Browsable(false)]
        public string PipesPath { get { return IO.Path.Combine(_path, "Library", "Pipes"); } }
        [Browsable(false)]
        public string ModulesPath { get { return IO.Path.Combine(_path, "Library", "Modules"); } }
        [Browsable(false)]
        public string FittingsPath { get { return IO.Path.Combine(_path, "Library", "Fittings"); } }
        [Browsable(false)]
        public Library Library { get; } = new Library();
        [Browsable(false)]
        public IList<Project> Projects { get; } = new List<Project>();

        public Solution(string path) { 
            _path = path;
        }
    }
}
