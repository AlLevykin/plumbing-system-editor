using System.ComponentModel;

namespace PSEClassLibrary
{
    public class Section
    {
        [DisplayName("Наименование"), Description("Наименование раздела"), Category("Раздел"), ReadOnly(true)]
        public string Name { get; set; } = "";
    }
}
