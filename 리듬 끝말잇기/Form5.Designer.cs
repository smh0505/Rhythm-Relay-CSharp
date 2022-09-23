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
            this.rouletteList = new System.Windows.Forms.CheckedListBox();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OptionName = new 리듬_끝말잇기.Marquee();
            this.nextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timerText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rouletteList
            // 
            this.rouletteList.FormattingEnabled = true;
            this.rouletteList.Location = new System.Drawing.Point(12, 237);
            this.rouletteList.Name = "rouletteList";
            this.rouletteList.Size = new System.Drawing.Size(294, 164);
            this.rouletteList.TabIndex = 0;
            // 
            // keyInput
            // 
            this.keyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyInput.Location = new System.Drawing.Point(12, 444);
            this.keyInput.Name = "keyInput";
            this.keyInput.PasswordChar = '●';
            this.keyInput.Size = new System.Drawing.Size(213, 21);
            this.keyInput.TabIndex = 1;
            this.keyInput.TextChanged += new System.EventHandler(this.KeyInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "https://toon.at/widget/alertbox/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "투네이션 통합 위젯 URL";
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(231, 429);
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
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "이번 역은";
            // 
            // OptionName
            // 
            this.OptionName.Interval = 50;
            this.OptionName.Location = new System.Drawing.Point(12, 106);
            this.OptionName.Name = "OptionName";
            this.OptionName.Size = new System.Drawing.Size(294, 49);
            this.OptionName.Speed = 0;
            this.OptionName.TabIndex = 6;
            this.OptionName.Y = 0;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(217, 196);
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
            this.label4.Location = new System.Drawing.Point(256, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "입니다.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(109, 196);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(102, 35);
            this.pauseButton.TabIndex = 15;
            this.pauseButton.Text = "일시정지";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 196);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(91, 35);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "출근";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timerText
            // 
            this.timerText.Font = new System.Drawing.Font("강원교육모두 Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timerText.Location = new System.Drawing.Point(58, 37);
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
            this.label5.Location = new System.Drawing.Point(83, 13);
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
            // RouletteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 478);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}