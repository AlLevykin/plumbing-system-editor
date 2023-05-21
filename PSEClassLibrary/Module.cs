using System.ComponentModel;

namespace PSEClassLibrary
{
    public class Module
    {
        [DisplayName("Обозначение"), Description("Обозначение СТУ"), Category("СТУ"), ReadOnly(true)]
        public string Index { get; set; } = "";
        [DisplayName("Описание"), Description("Описание сантехнического узла"), Category("СТУ")]
        public string Description { get; set; } = "";
        [DisplayName("Чертеж"), Description("Имя файла DXF"), Category("СТУ"), ReadOnly(true)]
        public string Drawing { get; set; } = "";
        [DisplayName("Граф"), Description("Граф прокладки канализации"), Category("СТУ")]
        public IList<Point2D> Route { get; } = new List<Point2D>();
    }
}
