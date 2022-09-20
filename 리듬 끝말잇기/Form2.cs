using System;
using System.Windows.Forms;

namespace 리듬_끝말잇기
{
    public partial class childWindow : Form
    {
        private readonly mainWindow parent = null;

        public childWindow(mainWindow window)
        {
            InitializeComponent();
            TopMost = true;

            marquee1.Speed = 1;
            marquee1.Interval = 1000 / 60;
            marquee1.Y = 10;

            parent = window;
            afterAlpha.SelectedIndex = 0;
        }

        public string SongTitle
        {
            get { return marquee1.Text; }
            set { marquee1.Text = value; }
        }

        public string Curr_Alpha
        {
            get { return beforeAlpha.Text; }
            set { beforeAlpha.Text = value; }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            parent.LastAlpha = afterAlpha.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
