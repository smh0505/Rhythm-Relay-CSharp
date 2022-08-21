using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 리듬_끝말잇기
{
    public partial class childWindow2 : Form
    {
        private readonly mainWindow parent = null;

        public childWindow2(mainWindow parent)
        {
            InitializeComponent();
            TopMost = true;

            marquee1.Text = "곡제목은 여기에 입력됩니다.";
            marquee1.Speed = 1;
            marquee1.Interval = 1000 / 60;
            marquee1.Y = 10;

            this.parent = parent;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void UpdateAlpha()
        {
            if (checkBox1.Checked)
                alphaText.Text = comboBox1.SelectedItem.ToString() + "/" + comboBox2.SelectedItem.ToString();
            else alphaText.Text = comboBox1.SelectedItem.ToString();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            if (inputBox.Text != "") marquee1.Text = inputBox.Text;
            else marquee1.Text = "곡제목은 여기에 입력됩니다.";
        }

        private void ComboBox_SelectedChanged(object sender, EventArgs e)
        {
            UpdateAlpha();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = checkBox1.Checked;
            UpdateAlpha();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputBox.Text))
            {
                MessageBox.Show("곡 제목이 비어있습니다.\n곡 제목을 입력해주세요.", "리듬 끝말잇기 in C# Ver.1.0", MessageBoxButtons.OK);
            }
            else
            {
                parent.LastTitle = inputBox.Text;
                parent.LastAlpha = alphaText.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
