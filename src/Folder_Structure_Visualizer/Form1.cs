using System;
using System.IO;
using System.Windows.Forms;

namespace Folder_Structure_Visualizer
{
    public partial class Form1 : Form
    {
        string currentFolder = @"C:\";
        int fileCounter = 1;
        int folderCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckDrives();
            LoadFilesAndFolders();
        }

        private void CheckDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            string driveInfo = "Available drives: ";
            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady)
                {
                    driveInfo += drive.Name + " ";
                }
            }

            lblPathValue.Text = currentFolder;
            lblDriveInfo.Text = driveInfo;
        }

        private void LoadFilesAndFolders()
        {
            try
            {
                txtFileList.Text = "";

                if (!Directory.Exists(currentFolder))
                {
                    txtFileList.Text = "Drive not available";
                    return;
                }

                string[] allFolders = Directory.GetDirectories(currentFolder);
                string[] allFiles = Directory.GetFiles(currentFolder);

                UpdateCounters(allFiles, allFolders);

                foreach (string folderPath in allFolders)
                {
                    string folderName = Path.GetFileName(folderPath);
                    txtFileList.Text += "[FOLDER] " + folderName + "\r\n";
                }

                foreach (string filePath in allFiles)
                {
                    string fileName = Path.GetFileName(filePath);
                    txtFileList.Text += "[FILE] " + fileName + "\r\n";
                }

                txtFileList.Text += $"\r\nTotal: {allFolders.Length} folders, {allFiles.Length} files";

            }
            catch (Exception error)
            {
                txtFileList.Text = "Error: " + error.Message;
            }
        }

        private void UpdateCounters(string[] files, string[] folders)
        {
            fileCounter = 1;
            folderCounter = 1;

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                if (fileName.StartsWith("NewFile") || fileName.StartsWith("MyFile"))
                {
                    string numberPart = fileName.Replace("NewFile", "").Replace("MyFile", "").Replace(".txt", "");
                    if (int.TryParse(numberPart, out int num))
                    {
                        if (num >= fileCounter) fileCounter = num + 1;
                    }
                }
            }

            foreach (string folder in folders)
            {
                string folderName = Path.GetFileName(folder);
                if (folderName.StartsWith("NewFolder") || folderName.StartsWith("MyFolder"))
                {
                    string numberPart = folderName.Replace("NewFolder", "").Replace("MyFolder", "");
                    if (int.TryParse(numberPart, out int num))
                    {
                        if (num >= folderCounter) folderCounter = num + 1;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFilesAndFolders();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                string newFileName = $"MyFile{fileCounter}.txt";
                string newFilePath = Path.Combine(currentFolder, newFileName);

                File.WriteAllText(newFilePath, $"This is my new file number {fileCounter}");
                MessageBox.Show($"File added: {newFileName}");

                fileCounter++;
                LoadFilesAndFolders();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string newFolderName = $"MyFolder{folderCounter}";
                string newFolderPath = Path.Combine(currentFolder, newFolderName);

                Directory.CreateDirectory(newFolderPath);
                MessageBox.Show($"Folder added: {newFolderName}");

                folderCounter++;
                LoadFilesAndFolders();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void btnChangeDrive_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            if (currentFolder == @"C:\")
            {
                foreach (DriveInfo drive in allDrives)
                {
                    if (drive.IsReady && drive.Name != @"C:\")
                    {
                        currentFolder = drive.Name;
                        break;
                    }
                }
            }
            else
            {
                currentFolder = @"C:\";
            }

            fileCounter = 1;
            folderCounter = 1;

            lblPathValue.Text = currentFolder;
            LoadFilesAndFolders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter file or folder name to delete:",
                    "Delete",
                    "");

                if (string.IsNullOrEmpty(itemName))
                {
                    return;
                }

                string fullPath = Path.Combine(currentFolder, itemName);

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                    MessageBox.Show("File deleted: " + itemName);
                }
                else if (Directory.Exists(fullPath))
                {
                    Directory.Delete(fullPath, true);
                    MessageBox.Show("Folder deleted: " + itemName);
                }
                else
                {
                    MessageBox.Show("File or folder not found: " + itemName);
                    return;
                }

                LoadFilesAndFolders();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                string oldName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter current file or folder name:",
                    "Rename",
                    "");

                if (string.IsNullOrEmpty(oldName))
                {
                    return;
                }

                string newName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter new name:",
                    "Rename",
                    "");

                if (string.IsNullOrEmpty(newName))
                {
                    return;
                }

                string oldPath = Path.Combine(currentFolder, oldName);
                string newPath = Path.Combine(currentFolder, newName);

                if (File.Exists(oldPath))
                {
                    File.Move(oldPath, newPath);
                    MessageBox.Show("File renamed to: " + newName);
                }
                else if (Directory.Exists(oldPath))
                {
                    Directory.Move(oldPath, newPath);
                    MessageBox.Show("Folder renamed to: " + newName);
                }
                else
                {
                    MessageBox.Show("File or folder not found: " + oldName);
                    return;
                }

                LoadFilesAndFolders();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}