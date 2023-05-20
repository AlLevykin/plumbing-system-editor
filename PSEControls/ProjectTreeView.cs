using PSEClassLibrary;

namespace PSEControls
{
    public partial class ProjectTreeView : UserControl
    {
        private Solution? _solution;

        public Solution? Solution
        {
            get { return _solution; }
            set
            {
                treeView.Nodes.Clear();
                _solution = value;
                if (_solution == null) return;

                TreeNode prn, ln, pn, fn, mn;
                prn = new("СТМ") { Tag = "СТМ", ImageIndex = 0, SelectedImageIndex = 0 };
                treeView.Nodes.Add(prn);

                ln = new("Библиотека") { Tag = "Библиотека", ImageIndex = 1, SelectedImageIndex = 1 };
                treeView.Nodes.Add(ln);

                pn = new("Трубы") { Tag = "Трубы", ImageIndex = 2, SelectedImageIndex = 2 };
                ln.Nodes.Add(pn);

                fn = new("Фиттинги") { Tag = "Фиттинги", ImageIndex = 3, SelectedImageIndex = 3 };
                ln.Nodes.Add(fn);

                mn = new("СТУ") { Tag = "СТУ", ImageIndex = 4, SelectedImageIndex = 4 };
                ln.Nodes.Add(mn);
            }
        }

        public ProjectTreeView()
        {
            InitializeComponent();
        }
    }
}