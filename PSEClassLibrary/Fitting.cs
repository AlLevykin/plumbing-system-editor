using System.ComponentModel;

namespace PSEClassLibrary
{
    public class Fitting
    {
        [DisplayName("Обозначение"), Description("Обозначение типа фиттинга"), Category("Фиттинг"), ReadOnly(true)]
        public string Index { get; set; } = "";
        [DisplayName("3D модель"), Description("Имя STEP-файла"), Category("Фиттинг"), ReadOnly(true)]
        public string Model { get; set; } = "";
        [DisplayName("Входы"), Description("Входные отверстия фиттинга"), Category("Фиттинг")]
        public IList<Entry> Entries { get; } = new List<Entry>();
    }
}
