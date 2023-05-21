using PSEClassLibrary;
using PSEClassLibrary.Helpers;

namespace PSE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SolutionTreeView_CurrentNodeChanged(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                propertyGrid.SelectedObject = e.Node.Tag;
            }            
        }

        private bool openSolution(string path)
        {
            if (!Directory.Exists(path))
            {
                return false;
            }

            Solution solution = SolutionHelper.Open(path);
            propertyGrid.SelectedObject = solution;
            solutionTreeView.Solution = solution;
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