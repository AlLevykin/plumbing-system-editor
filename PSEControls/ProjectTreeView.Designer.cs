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
            // 
            // ProjectTreeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(treeView);
            Name = "ProjectTreeView";
            Size = new Size(500, 500);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList;
        private TreeView treeView;
    }
}