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

                TreeNode prn, ln, pn, fn, mn, nn;
                prn = new("СТМ") { Tag = "СТМ", ImageIndex = 0, SelectedImageIndex = 0, ContextMenuStrip = mnuProjects };
                mnuProjects.Tag = prn;
                treeView.Nodes.Add(prn);

                ln = new("Библиотека") { Tag = "Библиотека", ImageIndex = 1, SelectedImageIndex = 1 };
                treeView.Nodes.Add(ln);

                pn = new("Трубы") { Tag = "Трубы", ImageIndex = 2, SelectedImageIndex = 2, ContextMenuStrip = mnuPipes };
                mnuPipes.Tag = pn;
                ln.Nodes.Add(pn);
                foreach (Pipe pipe in _solution.Library.Pipes)
                {
                    nn = new(pipe.Index);
                    nn.Tag = pipe;
                    nn.ImageIndex = 100;
                    nn.SelectedImageIndex = 100;
                    pn.Nodes.Add(nn);
                }

                fn = new("Фиттинги") { Tag = "Фиттинги", ImageIndex = 3, SelectedImageIndex = 3, ContextMenuStrip = mnuFittings };
                mnuFittings.Tag = fn;
                ln.Nodes.Add(fn);
                foreach (Fitting fitting in _solution.Library.Fittings)
                {
                    nn = new(fitting.Index);
                    nn.Tag = fitting;
                    nn.ImageIndex = 100;
                    nn.SelectedImageIndex = 100;
                    fn.Nodes.Add(nn);
                }

                mn = new("СТУ") { Tag = "СТУ", ImageIndex = 4, SelectedImageIndex = 4, ContextMenuStrip = mnuModules };
                mnuModules.Tag = mn;
                ln.Nodes.Add(mn);
                foreach (Module module in _solution.Library.Modules)
                {
                    nn = new(module.Index);
                    nn.Tag = module;
                    nn.ImageIndex = 100;
                    nn.SelectedImageIndex = 100;
                    mn.Nodes.Add(nn);
                }
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
                Pipe pipe = SolutionHelper.NewPipe(this.Solution, index);
                TreeNode nn = new(pipe.Index);
                nn.Tag = pipe;
                nn.ImageIndex = 100;
                nn.SelectedImageIndex = 100;
                ToolStripMenuItem mi = (ToolStripMenuItem)sender;
                ToolStrip mnu = mi.GetCurrentParent();
                TreeNode pn = (TreeNode)mnu.Tag;
                pn.Nodes.Add(nn);
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
                Module module = SolutionHelper.NewModule(this.Solution, index, dxf);
                TreeNode nn = new(module.Index);
                nn.Tag = module;
                nn.ImageIndex = 100;
                nn.SelectedImageIndex = 100;
                ToolStripMenuItem mi = (ToolStripMenuItem)sender;
                ToolStrip mnu = mi.GetCurrentParent();
                TreeNode pn = (TreeNode)mnu.Tag;
                pn.Nodes.Add(nn);
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
                Fitting fitting = SolutionHelper.NewFitting(this.Solution, index, model);
                TreeNode nn = new(fitting.Index);
                nn.Tag = fitting;
                nn.ImageIndex = 100;
                nn.SelectedImageIndex = 100;
                ToolStripMenuItem mi = (ToolStripMenuItem)sender;
                ToolStrip mnu = mi.GetCurrentParent();
                TreeNode pn = (TreeNode)mnu.Tag;
                pn.Nodes.Add(nn);
            }
        }
    }
}