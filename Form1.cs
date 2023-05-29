using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinSaveStartupPhotos
{
    public partial class Form1 : Form
    {
        private string PathUser { get; set; }
        private string PathChange { get; set; }
        private string UserName { get; set; }
        private string FileStartupPhoto { get; set; }
        private string FileUserPhoto { get; set; }

        private string PathStartupPhotos { get; set; }
        public Form1()
        {
            InitializeComponent();
            SavePhotos savePhotos = new SavePhotos();

            UserName = Environment.UserName;
            PathUser = Path.GetFullPath("C:\\Users\\" + UserName);
            PathChange = PathUser;
            textBoxSave.Text = PathUser;

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SavePhotos();
        }
        private void textBoxSave_Click(object sender, EventArgs e)
        {
            SavePhotos();
        }
        private void SavePhotos()
        {
            UserName = Environment.UserName;
            PathStartupPhotos = Path.GetFullPath("C:\\Users\\" + UserName + "\\AppData\\Local\\Packages"
                + "\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\" +
                 "LocalState\\Assets");
            PathUser = Path.GetFullPath("C:\\Users\\" + UserName);
            //copiar los archivos
            try
            {
                string[] fileList = Directory.GetFiles(PathStartupPhotos);
                foreach (string file in fileList)
                {
                    FileStartupPhoto = Path.GetFileName(file.ToString());
                    FileUserPhoto = Path.GetFileName(FileStartupPhoto + ".jpg");
                    File.Copy(Path.Combine(PathStartupPhotos, FileStartupPhoto), Path.Combine(PathChange, FileUserPhoto), true);
                }
                MessageBox.Show("images copied successfully", "Information");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSave.Text = folderBrowserDialog.SelectedPath;
                PathChange = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            textBoxSave.Text = PathUser;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }
    }
}