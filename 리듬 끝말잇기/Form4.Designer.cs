namespace 리듬_끝말잇기
{
    partial class TimerWindow
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
            this.timerText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pauseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("강원교육모두 Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(56, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "퇴근까지 걸린 시간";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerText
            // 
            this.timerText.Font = new System.Drawing.Font("강원교육모두 Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timerText.Location = new System.Drawing.Point(31, 33);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(200, 40);
            this.timerText.TabIndex = 2;
            this.timerText.Text = "00:00:00";
            this.timerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(38, 76);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(91, 32);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "출근";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(135, 76);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(96, 32);
            this.pauseButton.TabIndex = 11;
            this.pauseButton.Text = "일시정지";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // TimerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 126);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerWindow";
            this.Text = "리듬 끝말잇기";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimerWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pauseButton;
    }
}