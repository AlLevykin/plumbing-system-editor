using Microsoft.VisualBasic;
using PSEClassLibrary;
using PSEClassLibrary.Helpers;
using System;

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
                prn = new("СТМ") { Tag = "СТМ", ImageIndex = 0, SelectedImageIndex = 0, ContextMenuStrip = mnuProjects };
                treeView.Nodes.Add(prn);

                ln = new("Библиотека") { Tag = "Библиотека", ImageIndex = 1, SelectedImageIndex = 1 };
                treeView.Nodes.Add(ln);

                pn = new("Трубы") { Tag = "Трубы", ImageIndex = 2, SelectedImageIndex = 2, ContextMenuStrip = mnuPipes };
                ln.Nodes.Add(pn);

                fn = new("Фиттинги") { Tag = "Фиттинги", ImageIndex = 3, SelectedImageIndex = 3, ContextMenuStrip = mnuFittings };
                ln.Nodes.Add(fn);

                mn = new("СТУ") { Tag = "СТУ", ImageIndex = 4, SelectedImageIndex = 4, ContextMenuStrip = mnuModules };
                ln.Nodes.Add(mn);
            }
        }

        public ProjectTreeView()
        {
            InitializeComponent();
        }

        private void miNewPipe_Click(object sender, EventArgs e)
        {
            string index = Interaction.InputBox("Введите обозначение типа труб", Application.ProductName).Trim();
            if (!string.IsNullOrEmpty(index) && this.Solution != null)
            {
                SolutionHelper.NewPipe(this.Solution, index);
            }
        }

        private void miNewModule_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Чертеж|*.dxf";
            if (openDialog.ShowDialog() != DialogResult.OK) { return; }

            string dxf = openDialog.FileName;
            string index = Path.GetFileNameWithoutExtension(dxf);
            index = Interaction.InputBox("Введите обозначение типа труб", Application.ProductName, index).Trim();
            if (!string.IsNullOrEmpty(index) && this.Solution != null)
            {
                SolutionHelper.NewModule(this.Solution, index, dxf);
            }
        }

        private void miNewFitting_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "3D-модель STEP|*.stp";
            if (openDialog.ShowDialog() != DialogResult.OK) { return; }

            string model = openDialog.FileName;
            string index = Path.GetFileNameWithoutExtension(model);
            index = Interaction.InputBox("Введите обозначение типа фиттингов", Application.ProductName, index).Trim();
            if (!string.IsNullOrEmpty(index) && this.Solution != null)
            {
                SolutionHelper.NewFitting(this.Solution, index, model);
            }
        }
    }
}