namespace PSE
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainSplitContainer = new SplitContainer();
            projectSplitContainer = new SplitContainer();
            solutionTreeView = new PSEControls.ProjectTreeView();
            propertyGrid = new PropertyGrid();
            contentViewer = new PSEControls.Viewer();
            menuStrip = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            folderBrowser = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectSplitContainer).BeginInit();
            projectSplitContainer.Panel1.SuspendLayout();
            projectSplitContainer.Panel2.SuspendLayout();
            projectSplitContainer.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.FixedPanel = FixedPanel.Panel1;
            mainSplitContainer.Location = new Point(0, 24);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(projectSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(contentViewer);
            mainSplitContainer.Size = new Size(784, 537);
            mainSplitContainer.SplitterDistance = 265;
            mainSplitContainer.TabIndex = 0;
            // 
            // projectSplitContainer
            // 
            projectSplitContainer.Dock = DockStyle.Fill;
            projectSplitContainer.FixedPanel = FixedPanel.Panel2;
            projectSplitContainer.Location = new Point(0, 0);
            projectSplitContainer.Name = "projectSplitContainer";
            projectSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // projectSplitContainer.Panel1
            // 
            projectSplitContainer.Panel1.Controls.Add(solutionTreeView);
            // 
            // projectSplitContainer.Panel2
            // 
            projectSplitContainer.Panel2.Controls.Add(propertyGrid);
            projectSplitContainer.Size = new Size(265, 537);
            projectSplitContainer.SplitterDistance = 337;
            projectSplitContainer.TabIndex = 0;
            // 
            // solutionTreeView
            // 
            solutionTreeView.Dock = DockStyle.Fill;
            solutionTreeView.Location = new Point(0, 0);
            solutionTreeView.Name = "solutionTreeView";
            solutionTreeView.Size = new Size(265, 337);
            solutionTreeView.Solution = null;
            solutionTreeView.TabIndex = 0;
            // 
            // propertyGrid
            // 
            propertyGrid.Dock = DockStyle.Fill;
            propertyGrid.Location = new Point(0, 0);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(265, 196);
            propertyGrid.TabIndex = 0;
            // 
            // contentViewer
            // 
            contentViewer.Dock = DockStyle.Fill;
            contentViewer.Location = new Point(0, 0);
            contentViewer.Name = "contentViewer";
            contentViewer.Size = new Size(515, 537);
            contentViewer.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(784, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuOpen });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(48, 20);
            mnuFile.Text = "Файл";
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(249, 22);
            mnuOpen.Text = "Открыть рабочее пространство";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(mainSplitContainer);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор СТМ";
            Load += MainForm_Load;
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            projectSplitContainer.Panel1.ResumeLayout(false);
            projectSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)projectSplitContainer).EndInit();
            projectSplitContainer.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer mainSplitContainer;
        private SplitContainer projectSplitContainer;
        private PSEControls.ProjectTreeView solutionTreeView;
        private PropertyGrid propertyGrid;
        private MenuStrip menuStrip;
        private PSEControls.Viewer contentViewer;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuOpen;
        private FolderBrowserDialog folderBrowser;
    }
}