using System.ComponentModel;

namespace PSEClassLibrary
{
    public class Solution
    {
        private string _path = "";

        [DisplayName("Папка"), Description("Папка для хранения рабочего пространства"), Category("Рабочее пространство")]
        public string Path { get { return _path; } }
        [Browsable(false)]
        public Library Library { get; } = new Library();
        [Browsable(false)]
        public IList<Project> Projects { get; } = new List<Project>();

        public Solution(string path) { 
            _path = path;
        }
    }
}
