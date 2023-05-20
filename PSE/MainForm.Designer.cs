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
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectSplitContainer).BeginInit();
            projectSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(0, 0);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(projectSplitContainer);
            mainSplitContainer.Size = new Size(800, 450);
            mainSplitContainer.SplitterDistance = 266;
            mainSplitContainer.TabIndex = 0;
            // 
            // projectSplitContainer
            // 
            projectSplitContainer.Dock = DockStyle.Fill;
            projectSplitContainer.Location = new Point(0, 0);
            projectSplitContainer.Name = "projectSplitContainer";
            projectSplitContainer.Orientation = Orientation.Horizontal;
            projectSplitContainer.Size = new Size(266, 450);
            projectSplitContainer.SplitterDistance = 213;
            projectSplitContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainSplitContainer);
            Name = "MainForm";
            Text = "Редактор СТМ";
            mainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)projectSplitContainer).EndInit();
            projectSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer mainSplitContainer;
        private SplitContainer projectSplitContainer;
    }
}