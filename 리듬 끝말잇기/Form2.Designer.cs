namespace 리듬_끝말잇기
{
    partial class childWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.beforeAlpha = new System.Windows.Forms.Label();
            this.afterAlpha = new System.Windows.Forms.ComboBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.marquee1 = new 리듬_끝말잇기.Marquee();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("강원교육모두 Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 알파벳";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("강원교육모두 Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(181, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "바꿀 알파벳";
            // 
            // beforeAlpha
            // 
            this.beforeAlpha.Font = new System.Drawing.Font("코트라 도약체 ", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.beforeAlpha.Location = new System.Drawing.Point(0, 87);
            this.beforeAlpha.Name = "beforeAlpha";
            this.beforeAlpha.Size = new System.Drawing.Size(169, 60);
            this.beforeAlpha.TabIndex = 3;
            this.beforeAlpha.Text = "A/A";
            this.beforeAlpha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // afterAlpha
            // 
            this.afterAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.afterAlpha.Font = new System.Drawing.Font("코트라 도약체 ", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.afterAlpha.FormattingEnabled = true;
            this.afterAlpha.IntegralHeight = false;
            this.afterAlpha.Items.AddRange(new object[] {
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
            this.afterAlpha.Location = new System.Drawing.Point(195, 82);
            this.afterAlpha.Name = "afterAlpha";
            this.afterAlpha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.afterAlpha.Size = new System.Drawing.Size(71, 59);
            this.afterAlpha.TabIndex = 4;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(32, 150);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(103, 34);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "변경";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(182, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 34);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // marquee1
            // 
            this.marquee1.Dock = System.Windows.Forms.DockStyle.Top;
            this.marquee1.Interval = 50;
            this.marquee1.Location = new System.Drawing.Point(0, 0);
            this.marquee1.Name = "marquee1";
            this.marquee1.Size = new System.Drawing.Size(317, 49);
            this.marquee1.Speed = 0;
            this.marquee1.TabIndex = 0;
            this.marquee1.Y = 0;
            // 
            // childWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 211);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.afterAlpha);
            this.Controls.Add(this.beforeAlpha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marquee1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "childWindow";
            this.Text = "리듬 끝말잇기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Marquee marquee1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label beforeAlpha;
        private System.Windows.Forms.ComboBox afterAlpha;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}