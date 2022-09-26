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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.countText = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EyeCatchText = new System.Windows.Forms.Label();
            this.letterText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.songNameMarquee = new 리듬_끝말잇기.Marquee();
            this.songsUsedList = new 리듬_끝말잇기.Marquee2();
            this.OptionName = new 리듬_끝말잇기.Marquee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("강원교육모두 Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "이번 역은";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("강원교육모두 Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(172, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "입니다.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timerText
            // 
            this.timerText.Font = new System.Drawing.Font("강원교육모두 Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timerText.Location = new System.Drawing.Point(13, 32);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(200, 40);
            this.timerText.TabIndex = 13;
            this.timerText.Text = "00:00:00";
            this.timerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("강원교육모두 Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(35, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "퇴근까지 걸린 시간";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // countText
            // 
            this.countText.Font = new System.Drawing.Font("강원교육모두 Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countText.Location = new System.Drawing.Point(12, 96);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(200, 40);
            this.countText.TabIndex = 17;
            this.countText.Text = "10곡 남음";
            this.countText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("강원교육모두 Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countLabel.Location = new System.Drawing.Point(44, 72);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(134, 24);
            this.countLabel.TabIndex = 16;
            this.countLabel.Text = "퇴근까지 앞으로";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.countText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.countLabel);
            this.panel1.Controls.Add(this.timerText);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 149);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.OptionName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 103);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 50);
            this.panel3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("강원교육모두 Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(5, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "플레이한 목록";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.songsUsedList);
            this.panel4.Location = new System.Drawing.Point(227, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 309);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.EyeCatchText);
            this.panel5.Controls.Add(this.letterText);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.songNameMarquee);
            this.panel5.Location = new System.Drawing.Point(0, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 107);
            this.panel5.TabIndex = 22;
            // 
            // EyeCatchText
            // 
            this.EyeCatchText.Font = new System.Drawing.Font("코트라 도약체 ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EyeCatchText.Location = new System.Drawing.Point(0, 0);
            this.EyeCatchText.Name = "EyeCatchText";
            this.EyeCatchText.Size = new System.Drawing.Size(226, 106);
            this.EyeCatchText.TabIndex = 23;
            this.EyeCatchText.Text = "리듬\r\n끝말잇기";
            this.EyeCatchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letterText
            // 
            this.letterText.Font = new System.Drawing.Font("코트라 도약체 ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.letterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.letterText.Location = new System.Drawing.Point(135, 56);
            this.letterText.Name = "letterText";
            this.letterText.Size = new System.Drawing.Size(88, 45);
            this.letterText.TabIndex = 20;
            this.letterText.Text = "A/A";
            this.letterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.letterText.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("코트라 도약체 ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(3, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "다음 이니셜";
            this.label8.Visible = false;
            // 
            // songNameMarquee
            // 
            this.songNameMarquee.Interval = 50;
            this.songNameMarquee.Location = new System.Drawing.Point(3, 3);
            this.songNameMarquee.Name = "songNameMarquee";
            this.songNameMarquee.Size = new System.Drawing.Size(220, 70);
            this.songNameMarquee.Speed = 0;
            this.songNameMarquee.TabIndex = 18;
            this.songNameMarquee.Y = 0;
            // 
            // songsUsedList
            // 
            this.songsUsedList.Interval = 100;
            this.songsUsedList.Items = null;
            this.songsUsedList.Location = new System.Drawing.Point(1, 3);
            this.songsUsedList.Name = "songsUsedList";
            this.songsUsedList.Size = new System.Drawing.Size(261, 301);
            this.songsUsedList.Speed = 0;
            this.songsUsedList.TabIndex = 1;
            // 
            // OptionName
            // 
            this.OptionName.Interval = 50;
            this.OptionName.Location = new System.Drawing.Point(3, 24);
            this.OptionName.Name = "OptionName";
            this.OptionName.Size = new System.Drawing.Size(219, 49);
            this.OptionName.Speed = 0;
            this.OptionName.TabIndex = 6;
            this.OptionName.Y = 0;
            // 
            // RouletteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 359);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RouletteWindow";
            this.Text = "리듬 끝말잇기";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RouletteWindow_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Marquee OptionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label countText;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private Marquee2 songsUsedList;
        private System.Windows.Forms.Panel panel5;
        private Marquee songNameMarquee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label letterText;
        private System.Windows.Forms.Label EyeCatchText;
    }
}