namespace 리듬_끝말잇기
{
    partial class childWindow2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.marquee1 = new 리듬_끝말잇기.Marquee();
            this.label4 = new System.Windows.Forms.Label();
            this.alphaText = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "곡 제목";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(130, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(175, 21);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "다음 알파벳";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.comboBox1.Location = new System.Drawing.Point(130, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "추가 알파벳";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(130, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox2.Location = new System.Drawing.Point(152, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 20);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedChanged);
            // 
            // marquee1
            // 
            this.marquee1.Interval = 50;
            this.marquee1.Location = new System.Drawing.Point(12, 139);
            this.marquee1.Name = "marquee1";
            this.marquee1.Size = new System.Drawing.Size(190, 49);
            this.marquee1.Speed = 0;
            this.marquee1.TabIndex = 7;
            this.marquee1.Y = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "미리보기";
            // 
            // alphaText
            // 
            this.alphaText.Font = new System.Drawing.Font("코트라 도약체 ", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alphaText.Location = new System.Drawing.Point(208, 129);
            this.alphaText.Name = "alphaText";
            this.alphaText.Size = new System.Drawing.Size(100, 55);
            this.alphaText.TabIndex = 9;
            this.alphaText.Text = "A/A";
            this.alphaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 195);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 36);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "선곡";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(163, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 36);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // childWindow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 240);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.alphaText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.marquee1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "childWindow2";
            this.Text = "리듬 끝말잇기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Marquee marquee1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label alphaText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}