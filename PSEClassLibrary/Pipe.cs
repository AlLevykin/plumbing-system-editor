using System.ComponentModel;

namespace PSEClassLibrary
{
    public class Pipe
    {
        [DisplayName("Обозначение"), Description("Обозначение типа труб"), Category("Труба"), ReadOnly(true)]
        public string Index { get; set; } = "";
        [DisplayName("Диаметр"), Description("Диаметр трубы"), Category("Труба")]
        public int Diameter { get; set; }
    }
}
