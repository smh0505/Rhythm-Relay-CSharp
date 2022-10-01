using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 리듬_끝말잇기
{
    public partial class RecoverForm : Form
    {
        private readonly mainWindow parent = null;
        string selectedFile;
        public RecoverForm(mainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
            TopMost = true;
        }

        private void OpenFileButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = System.AppContext.BaseDirectory,
                Filter = "log files (*.log)|*.log",
                CheckFileExists = true,
                CheckPathExists = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text = Path.GetFileName(openFileDialog.FileName);
                recoverButton.Enabled = true;
                selectedFile = openFileDialog.FileName;
            }
        }

        private void RecoverButton(object sender, EventArgs e)
        {
            Recoverer recoverer = new Recoverer();
            recoverer.Recover(selectedFile);
            parent.Recover(recoverer, timeCheckbox.Checked, rouletteCheckbox.Checked, songCheckbox.Checked, leftSongCountCheckbox.Checked);
            Close();
        }
    }
}