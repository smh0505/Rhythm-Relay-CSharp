namespace 리듬_끝말잇기
{
    partial class mainWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spinBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.countText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.forceAddButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EyeCatchText = new System.Windows.Forms.Label();
            this.letterText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.marquee2 = new 리듬_끝말잇기.Marquee2();
            this.marquee1 = new 리듬_끝말잇기.Marquee();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Enabled = false;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(256, 271);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "시작 곡 수";
            // 
            // spinBox
            // 
            this.spinBox.Location = new System.Drawing.Point(168, 7);
            this.spinBox.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.spinBox.Name = "spinBox";
            this.spinBox.ReadOnly = true;
            this.spinBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spinBox.Size = new System.Drawing.Size(60, 21);
            this.spinBox.TabIndex = 2;
            this.spinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinBox.ValueChanged += new System.EventHandler(this.SpinBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "곡";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.spinBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 40);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.countText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(260, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 90);
            this.panel2.TabIndex = 6;
            // 
            // countText
            // 
            this.countText.Font = new System.Drawing.Font("강원교육모두 Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countText.Location = new System.Drawing.Point(32, 35);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(200, 40);
            this.countText.TabIndex = 3;
            this.countText.Text = "10곡 남음";
            this.countText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("강원교육모두 Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(64, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "퇴근까지 앞으로";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.checkBox);
            this.panel3.Controls.Add(this.comboBox);
            this.panel3.Controls.Add(this.inputBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 62);
            this.panel3.TabIndex = 7;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Enabled = false;
            this.checkBox.Location = new System.Drawing.Point(98, 35);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 4;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // comboBox
            // 
            this.comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Enabled = false;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.ItemHeight = 12;
            this.comboBox.Items.AddRange(new object[] {
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
            this.comboBox.Location = new System.Drawing.Point(119, 32);
            this.comboBox.MaxDropDownItems = 6;
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(134, 20);
            this.comboBox.TabIndex = 3;
            // 
            // inputBox
            // 
            this.inputBox.Enabled = false;
            this.inputBox.Location = new System.Drawing.Point(98, 5);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(155, 21);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "알파벳 룰렛";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "곡 제목";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("코트라 도약체 ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(4, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 34);
            this.label7.TabIndex = 8;
            this.label7.Text = "리듬 끝말잇기 시즌2";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 53);
            this.panel4.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(131, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 37);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "선곡";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.listBox);
            this.panel5.Location = new System.Drawing.Point(0, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 275);
            this.panel5.TabIndex = 12;
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(3, 47);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(122, 37);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "선곡 수정";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // forceAddButton
            // 
            this.forceAddButton.Enabled = false;
            this.forceAddButton.Location = new System.Drawing.Point(131, 47);
            this.forceAddButton.Name = "forceAddButton";
            this.forceAddButton.Size = new System.Drawing.Size(120, 37);
            this.forceAddButton.TabIndex = 14;
            this.forceAddButton.Text = "강제 선곡";
            this.forceAddButton.UseVisualStyleBackColor = true;
            this.forceAddButton.Click += new System.EventHandler(this.ForceAddButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Enabled = false;
            this.plusButton.Location = new System.Drawing.Point(3, 90);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(122, 37);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "1곡 추가";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Enabled = false;
            this.minusButton.Location = new System.Drawing.Point(131, 90);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(120, 37);
            this.minusButton.TabIndex = 16;
            this.minusButton.Text = "1곡 제거";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.EyeCatchText);
            this.panel6.Controls.Add(this.letterText);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.marquee1);
            this.panel6.Location = new System.Drawing.Point(261, 89);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 119);
            this.panel6.TabIndex = 18;
            // 
            // EyeCatchText
            // 
            this.EyeCatchText.Font = new System.Drawing.Font("코트라 도약체 ", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EyeCatchText.Location = new System.Drawing.Point(-2, -2);
            this.EyeCatchText.Name = "EyeCatchText";
            this.EyeCatchText.Size = new System.Drawing.Size(264, 119);
            this.EyeCatchText.TabIndex = 20;
            this.EyeCatchText.Text = "리듬\r\n끝말잇기";
            this.EyeCatchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letterText
            // 
            this.letterText.Font = new System.Drawing.Font("코트라 도약체 ", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.letterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.letterText.Location = new System.Drawing.Point(161, 61);
            this.letterText.Name = "letterText";
            this.letterText.Size = new System.Drawing.Size(97, 51);
            this.letterText.TabIndex = 19;
            this.letterText.Text = "A/A";
            this.letterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.letterText.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("코트라 도약체 ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(4, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "다음 이니셜";
            this.label8.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.minusButton);
            this.panel7.Controls.Add(this.editButton);
            this.panel7.Controls.Add(this.plusButton);
            this.panel7.Controls.Add(this.forceAddButton);
            this.panel7.Controls.Add(this.addButton);
            this.panel7.Location = new System.Drawing.Point(0, 424);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 135);
            this.panel7.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(261, 211);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(264, 44);
            this.panel8.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("강원교육모두 Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(1, -2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "플레이한 목록";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.marquee2);
            this.panel9.Location = new System.Drawing.Point(260, 254);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(264, 368);
            this.panel9.TabIndex = 21;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(5, 564);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(182, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(193, 588);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(60, 21);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // marquee2
            // 
            this.marquee2.Interval = 100;
            this.marquee2.Items = null;
            this.marquee2.Location = new System.Drawing.Point(-2, -2);
            this.marquee2.Name = "marquee2";
            this.marquee2.Size = new System.Drawing.Size(264, 368);
            this.marquee2.Speed = 0;
            this.marquee2.TabIndex = 0;
            // 
            // marquee1
            // 
            this.marquee1.Interval = 50;
            this.marquee1.Location = new System.Drawing.Point(-2, -2);
            this.marquee1.Name = "marquee1";
            this.marquee1.Size = new System.Drawing.Size(264, 73);
            this.marquee1.Speed = 0;
            this.marquee1.TabIndex = 17;
            this.marquee1.Y = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "음량";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 621);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.Text = "리듬 끝말잇기 in C# Ver.1.2";
            ((System.ComponentModel.ISupportInitialize)(this.spinBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label countText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button forceAddButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private Marquee marquee1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label letterText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EyeCatchText;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private Marquee2 marquee2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
    }
}

