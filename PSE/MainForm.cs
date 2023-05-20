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

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog(this) == DialogResult.OK)
            {
                string path = folderBrowser.SelectedPath;
                Solution solution = SolutionHelper.Open(path);
                propertyGrid.SelectedObject = solution;
                solutionTreeView.Solution = solution;
            }
        }
    }
}