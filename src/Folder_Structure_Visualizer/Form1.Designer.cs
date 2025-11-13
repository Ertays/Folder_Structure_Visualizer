using System.Security.Cryptography.X509Certificates;

namespace Folder_Structure_Visualizer
{
    partial class Form1
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
            lblTitle = new Label();
            lblCurrentPath = new Label();
            lblPathValue = new Label();
            lblFilesTitle = new Label();
            btnRefresh = new Button();
            btnDelete = new Button();
            txtFileList = new TextBox();
            btnAddFile = new Button();
            btnAddFolder = new Button();
            btnChangeDrive = new Button();
            btnRename = new Button();
            lblDriveInfo = new Label();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 17);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(376, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Folder Structure Visualizer";

            lblCurrentPath.AutoSize = true;
            lblCurrentPath.Location = new Point(20, 87);
            lblCurrentPath.Margin = new Padding(5, 0, 5, 0);
            lblCurrentPath.Name = "lblCurrentPath";
            lblCurrentPath.Size = new Size(113, 25);
            lblCurrentPath.TabIndex = 1;
            lblCurrentPath.Text = "Current Path:";

            lblPathValue.AutoSize = true;
            lblPathValue.Location = new Point(145, 87);
            lblPathValue.Margin = new Padding(5, 0, 5, 0);
            lblPathValue.Name = "lblPathValue";
            lblPathValue.Size = new Size(34, 25);
            lblPathValue.TabIndex = 2;
            lblPathValue.Text = "C:\\";

            lblFilesTitle.AutoSize = true;
            lblFilesTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblFilesTitle.Location = new Point(20, 163);
            lblFilesTitle.Margin = new Padding(5, 0, 5, 0);
            lblFilesTitle.Name = "lblFilesTitle";
            lblFilesTitle.Size = new Size(65, 25);
            lblFilesTitle.TabIndex = 4;
            lblFilesTitle.Text = "Files:";

            btnRefresh.Location = new Point(20, 673);
            btnRefresh.Margin = new Padding(5, 6, 5, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(125, 44);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;

            btnDelete.Location = new Point(475, 673);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 44);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            txtFileList.Location = new Point(20, 202);
            txtFileList.Margin = new Padding(5, 6, 5, 6);
            txtFileList.Multiline = true;
            txtFileList.Name = "txtFileList";
            txtFileList.ReadOnly = true;
            txtFileList.ScrollBars = ScrollBars.Vertical;
            txtFileList.Size = new Size(764, 439);
            txtFileList.TabIndex = 7;

            btnAddFile.Location = new Point(20, 731);
            btnAddFile.Margin = new Padding(5, 6, 5, 6);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(125, 44);
            btnAddFile.TabIndex = 8;
            btnAddFile.Text = "Add File";
            btnAddFile.UseVisualStyleBackColor = true;
            btnAddFile.Click += btnAddFile_Click;

            btnAddFolder.Location = new Point(155, 731);
            btnAddFolder.Margin = new Padding(5, 6, 5, 6);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new Size(133, 44);
            btnAddFolder.TabIndex = 9;
            btnAddFolder.Text = "Add Folder";
            btnAddFolder.UseVisualStyleBackColor = true;
            btnAddFolder.Click += btnAddFolder_Click;

            btnChangeDrive.Location = new Point(298, 731);
            btnChangeDrive.Margin = new Padding(5, 6, 5, 6);
            btnChangeDrive.Name = "btnChangeDrive";
            btnChangeDrive.Size = new Size(167, 44);
            btnChangeDrive.TabIndex = 12;
            btnChangeDrive.Text = "Change Drive";
            btnChangeDrive.UseVisualStyleBackColor = true;
            btnChangeDrive.Click += btnChangeDrive_Click;

            btnRename.Location = new Point(475, 731);
            btnRename.Margin = new Padding(5, 6, 5, 6);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(125, 44);
            btnRename.TabIndex = 13;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;

            lblDriveInfo.AutoSize = true;
            lblDriveInfo.Location = new Point(20, 125);
            lblDriveInfo.Margin = new Padding(5, 0, 5, 0);
            lblDriveInfo.Name = "lblDriveInfo";
            lblDriveInfo.Size = new Size(61, 25);
            lblDriveInfo.TabIndex = 3;
            lblDriveInfo.Text = "Drives";

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 785);
            Controls.Add(btnRename);
            Controls.Add(btnChangeDrive);
            Controls.Add(btnAddFolder);
            Controls.Add(btnAddFile);
            Controls.Add(txtFileList);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(lblFilesTitle);
            Controls.Add(lblDriveInfo);
            Controls.Add(lblPathValue);
            Controls.Add(lblCurrentPath);
            Controls.Add(lblTitle);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folder Structure Visualizer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCurrentPath;
        private Label lblPathValue;
        private Label lblDriveInfo;
        private Label lblFilesTitle;
        private Button btnRefresh;
        private Button btnDelete;
        private TextBox txtFileList;
        private Button btnAddFile;
        private Button btnAddFolder;
        private Button btnChangeDrive;
        private Button btnRename;
    }
}
