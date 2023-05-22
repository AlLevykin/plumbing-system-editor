using PSEClassLibrary;
using PSEClassLibrary.Helpers;

namespace PSE
{
    public partial class MainForm : Form
    {
        private Solution? _solution;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SolutionTreeView_CurrentNodeChanged(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                object obj = e.Node.Tag;
                propertyGrid.SelectedObject = obj;
                contentViewer.ClearViewer();
                if ((obj is Module) && (_solution != null))
                {
                    Module module = (Module)obj;
                    string dxf = File.ReadAllText(Path.Combine(_solution.ModulesPath, module.Index, module.Drawing));
                    contentViewer.ShowDXF(dxf);
                }
            }            
        }

        private bool openSolution(string path)
        {
            if (!Directory.Exists(path))
            {
                return false;
            }

            _solution = SolutionHelper.Open(path);
            propertyGrid.SelectedObject = _solution;
            solutionTreeView.Solution = _solution;
            return true;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog(this) == DialogResult.OK)
            {
                string path = folderBrowser.SelectedPath;
                if (openSolution(path))
                {
                    Properties.Settings.Default.LastSolution = path;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.LastSolution;
            openSolution(path);
        }
    }
}