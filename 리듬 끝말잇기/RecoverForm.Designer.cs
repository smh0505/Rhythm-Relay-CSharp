namespace 리듬_끝말잇기
{
    partial class RecoverForm
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.timeCheckbox = new System.Windows.Forms.CheckBox();
            this.rouletteCheckbox = new System.Windows.Forms.CheckBox();
            this.songCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recoverButton = new System.Windows.Forms.Button();
            this.leftSongCountCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.Location = new System.Drawing.Point(12, 146);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(99, 27);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "파일 찾기";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton);
            // 
            // timeCheckbox
            // 
            this.timeCheckbox.AutoSize = true;
            this.timeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheckbox.Location = new System.Drawing.Point(12, 41);
            this.timeCheckbox.Name = "timeCheckbox";
            this.timeCheckbox.Size = new System.Drawing.Size(50, 19);
            this.timeCheckbox.TabIndex = 1;
            this.timeCheckbox.Text = "시간";
            this.timeCheckbox.UseVisualStyleBackColor = true;
            // 
            // rouletteCheckbox
            // 
            this.rouletteCheckbox.AutoSize = true;
            this.rouletteCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rouletteCheckbox.Location = new System.Drawing.Point(12, 66);
            this.rouletteCheckbox.Name = "rouletteCheckbox";
            this.rouletteCheckbox.Size = new System.Drawing.Size(50, 19);
            this.rouletteCheckbox.TabIndex = 2;
            this.rouletteCheckbox.Text = "룰렛";
            this.rouletteCheckbox.UseVisualStyleBackColor = true;
            // 
            // songCheckbox
            // 
            this.songCheckbox.AutoSize = true;
            this.songCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songCheckbox.Location = new System.Drawing.Point(12, 91);
            this.songCheckbox.Name = "songCheckbox";
            this.songCheckbox.Size = new System.Drawing.Size(89, 19);
            this.songCheckbox.TabIndex = 3;
            this.songCheckbox.Text = "플레이한 곡";
            this.songCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "선택한 파일 없음";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recoverButton
            // 
            this.recoverButton.Enabled = false;
            this.recoverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverButton.Location = new System.Drawing.Point(120, 146);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Size = new System.Drawing.Size(99, 27);
            this.recoverButton.TabIndex = 0;
            this.recoverButton.Text = "복구하기";
            this.recoverButton.UseVisualStyleBackColor = true;
            this.recoverButton.Click += new System.EventHandler(this.RecoverButton);
            // 
            // leftSongCountCheckbox
            // 
            this.leftSongCountCheckbox.AutoSize = true;
            this.leftSongCountCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftSongCountCheckbox.Location = new System.Drawing.Point(12, 116);
            this.leftSongCountCheckbox.Name = "leftSongCountCheckbox";
            this.leftSongCountCheckbox.Size = new System.Drawing.Size(80, 19);
            this.leftSongCountCheckbox.TabIndex = 3;
            this.leftSongCountCheckbox.Text = "남은 곡 수";
            this.leftSongCountCheckbox.UseVisualStyleBackColor = true;
            // 
            // RecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftSongCountCheckbox);
            this.Controls.Add(this.songCheckbox);
            this.Controls.Add(this.rouletteCheckbox);
            this.Controls.Add(this.timeCheckbox);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.openFileButton);
            this.Name = "RecoverForm";
            this.Text = "RecoverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.CheckBox timeCheckbox;
        private System.Windows.Forms.CheckBox rouletteCheckbox;
        private System.Windows.Forms.CheckBox songCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recoverButton;
        private System.Windows.Forms.CheckBox leftSongCountCheckbox;
    }
}