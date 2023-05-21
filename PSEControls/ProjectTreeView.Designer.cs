using System.Windows.Forms;

namespace PSEControls
{
    partial class ProjectTreeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectTreeView));
            imageList = new ImageList(components);
            treeView = new TreeView();
            mnuProjects = new ContextMenuStrip(components);
            miCreateProject = new ToolStripMenuItem();
            mnuPipes = new ContextMenuStrip(components);
            miNewPipe = new ToolStripMenuItem();
            mnuModules = new ContextMenuStrip(components);
            miNewModule = new ToolStripMenuItem();
            mnuFittings = new ContextMenuStrip(components);
            miNewFitting = new ToolStripMenuItem();
            openDialog = new OpenFileDialog();
            mnuProjects.SuspendLayout();
            mnuPipes.SuspendLayout();
            mnuModules.SuspendLayout();
            mnuFittings.SuspendLayout();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "icons8-wrench-50.png");
            imageList.Images.SetKeyName(1, "icons8-library-30.png");
            imageList.Images.SetKeyName(2, "icons8-pipe-26.png");
            imageList.Images.SetKeyName(3, "icons8-pipe-24.png");
            imageList.Images.SetKeyName(4, "icons8-room-36.png");
            // 
            // treeView
            // 
            treeView.Dock = DockStyle.Fill;
            treeView.ImageIndex = 0;
            treeView.ImageList = imageList;
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.SelectedImageIndex = 0;
            treeView.Size = new Size(500, 500);
            treeView.TabIndex = 0;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // mnuProjects
            // 
            mnuProjects.Items.AddRange(new ToolStripItem[] { miCreateProject });
            mnuProjects.Name = "mnuProjects";
            mnuProjects.Size = new Size(226, 26);
            // 
            // miCreateProject
            // 
            miCreateProject.Name = "miCreateProject";
            miCreateProject.Size = new Size(225, 22);
            miCreateProject.Text = "Создать новый проект СТМ";
            // 
            // mnuPipes
            // 
            mnuPipes.Items.AddRange(new ToolStripItem[] { miNewPipe });
            mnuPipes.Name = "mnuPipes";
            mnuPipes.Size = new Size(216, 26);
            // 
            // miNewPipe
            // 
            miNewPipe.Name = "miNewPipe";
            miNewPipe.Size = new Size(215, 22);
            miNewPipe.Text = "Добавить новый тип труб";
            miNewPipe.Click += miNewPipe_Click;
            // 
            // mnuModules
            // 
            mnuModules.Items.AddRange(new ToolStripItem[] { miNewModule });
            mnuModules.Name = "mnuModules";
            mnuModules.Size = new Size(212, 26);
            // 
            // miNewModule
            // 
            miNewModule.Name = "miNewModule";
            miNewModule.Size = new Size(211, 22);
            miNewModule.Text = "Добавить новый тип СТУ";
            miNewModule.Click += miNewModule_Click;
            // 
            // mnuFittings
            // 
            mnuFittings.Items.AddRange(new ToolStripItem[] { miNewFitting });
            mnuFittings.Name = "mnuFittings";
            mnuFittings.Size = new Size(249, 26);
            // 
            // miNewFitting
            // 
            miNewFitting.Name = "miNewFitting";
            miNewFitting.Size = new Size(248, 22);
            miNewFitting.Text = "Добавить новый тип фиттингов";
            miNewFitting.Click += miNewFitting_Click;
            // 
            // ProjectTreeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(treeView);
            Name = "ProjectTreeView";
            Size = new Size(500, 500);
            mnuProjects.ResumeLayout(false);
            mnuPipes.ResumeLayout(false);
            mnuModules.ResumeLayout(false);
            mnuFittings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList;
        private TreeView treeView;
        private ContextMenuStrip mnuProjects;
        private ContextMenuStrip mnuPipes;
        private ContextMenuStrip mnuModules;
        private ContextMenuStrip mnuFittings;
        private ToolStripMenuItem miCreateProject;
        private ToolStripMenuItem miNewPipe;
        private ToolStripMenuItem miNewFitting;
        private ToolStripMenuItem miNewModule;
        private OpenFileDialog openDialog;
    }
}