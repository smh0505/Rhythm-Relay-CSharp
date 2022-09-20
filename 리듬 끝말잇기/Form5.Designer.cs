namespace 리듬_끝말잇기
{
    partial class RouletteWindow
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
            this.rouletteList = new System.Windows.Forms.CheckedListBox();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OptionName = new 리듬_끝말잇기.Marquee();
            this.nextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rouletteList
            // 
            this.rouletteList.FormattingEnabled = true;
            this.rouletteList.Location = new System.Drawing.Point(12, 161);
            this.rouletteList.Name = "rouletteList";
            this.rouletteList.Size = new System.Drawing.Size(294, 164);
            this.rouletteList.TabIndex = 0;
            // 
            // keyInput
            // 
            this.keyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyInput.Location = new System.Drawing.Point(12, 368);
            this.keyInput.Name = "keyInput";
            this.keyInput.PasswordChar = '●';
            this.keyInput.Size = new System.Drawing.Size(213, 21);
            this.keyInput.TabIndex = 1;
            this.keyInput.TextChanged += new System.EventHandler(this.KeyInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "https://toon.at/widget/alertbox/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "투네이션 통합 위젯 URL";
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(231, 353);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 36);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "연결";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("강원교육모두 Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "이번 역은";
            // 
            // OptionName
            // 
            this.OptionName.Interval = 50;
            this.OptionName.Location = new System.Drawing.Point(12, 30);
            this.OptionName.Name = "OptionName";
            this.OptionName.Size = new System.Drawing.Size(294, 49);
            this.OptionName.Speed = 0;
            this.OptionName.TabIndex = 6;
            this.OptionName.Y = 0;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(217, 120);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(89, 35);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "다음 역";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("강원교육모두 Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(256, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "입니다.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RouletteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.OptionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.rouletteList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RouletteWindow";
            this.Text = "리듬 끝말잇기";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RouletteWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox rouletteList;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label3;
        private Marquee OptionName;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label4;
    }
}