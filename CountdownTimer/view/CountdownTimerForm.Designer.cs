namespace MyPrototype.CountdownTimer.view
{
    partial class CountdownTimerForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.RemainingTimeText = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PomodoroButton = new System.Windows.Forms.Button();
            this.CustomTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeSetButton = new System.Windows.Forms.Button();
            this.RemainingTimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // RemainingTimeText
            // 
            this.RemainingTimeText.AutoSize = true;
            this.RemainingTimeText.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(81)))), ((int)(((byte)(129)))));
            this.RemainingTimeText.Location = new System.Drawing.Point(19, 16);
            this.RemainingTimeText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RemainingTimeText.Name = "RemainingTimeText";
            this.RemainingTimeText.Size = new System.Drawing.Size(121, 49);
            this.RemainingTimeText.TabIndex = 1;
            this.RemainingTimeText.Text = "--:--";
            this.RemainingTimeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.No;
            this.StartButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(176, 90);
            this.StartButton.Margin = new System.Windows.Forms.Padding(5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(128, 32);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Synchronous Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(117)))), ((int)(((byte)(165)))));
            this.ResetButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(229)))));
            this.ResetButton.Location = new System.Drawing.Point(240, 48);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(64, 32);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(117)))), ((int)(((byte)(165)))));
            this.PauseButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(229)))));
            this.PauseButton.Location = new System.Drawing.Point(176, 48);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(5);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(64, 32);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PomodoroButton
            // 
            this.PomodoroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(81)))), ((int)(((byte)(129)))));
            this.PomodoroButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PomodoroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(229)))));
            this.PomodoroButton.Location = new System.Drawing.Point(176, 16);
            this.PomodoroButton.Margin = new System.Windows.Forms.Padding(5);
            this.PomodoroButton.Name = "PomodoroButton";
            this.PomodoroButton.Size = new System.Drawing.Size(128, 32);
            this.PomodoroButton.TabIndex = 6;
            this.PomodoroButton.Text = "Start-Pomodoro";
            this.PomodoroButton.UseVisualStyleBackColor = false;
            this.PomodoroButton.Click += new System.EventHandler(this.PomodoroButton_Click);
            // 
            // CustomTimePicker
            // 
            this.CustomTimePicker.CustomFormat = "mm:ss";
            this.CustomTimePicker.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CustomTimePicker.Location = new System.Drawing.Point(16, 92);
            this.CustomTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.CustomTimePicker.Name = "CustomTimePicker";
            this.CustomTimePicker.ShowUpDown = true;
            this.CustomTimePicker.Size = new System.Drawing.Size(64, 28);
            this.CustomTimePicker.TabIndex = 7;
            // 
            // TimeSetButton
            // 
            this.TimeSetButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeSetButton.Location = new System.Drawing.Point(80, 90);
            this.TimeSetButton.Margin = new System.Windows.Forms.Padding(5);
            this.TimeSetButton.Name = "TimeSetButton";
            this.TimeSetButton.Size = new System.Drawing.Size(64, 32);
            this.TimeSetButton.TabIndex = 8;
            this.TimeSetButton.Text = "Set";
            this.TimeSetButton.UseVisualStyleBackColor = true;
            this.TimeSetButton.Click += new System.EventHandler(this.TimeSetButton_Click);
            // 
            // RemainingTimeProgressBar
            // 
            this.RemainingTimeProgressBar.Location = new System.Drawing.Point(16, 64);
            this.RemainingTimeProgressBar.MarqueeAnimationSpeed = 1;
            this.RemainingTimeProgressBar.Name = "RemainingTimeProgressBar";
            this.RemainingTimeProgressBar.Size = new System.Drawing.Size(128, 16);
            this.RemainingTimeProgressBar.Step = 1;
            this.RemainingTimeProgressBar.TabIndex = 9;
            // 
            // CountdownTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(320, 128);
            this.Controls.Add(this.RemainingTimeProgressBar);
            this.Controls.Add(this.TimeSetButton);
            this.Controls.Add(this.CustomTimePicker);
            this.Controls.Add(this.PomodoroButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.RemainingTimeText);
            this.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "CountdownTimerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CountdownTimer";
            this.Load += new System.EventHandler(this.CountdownTimerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RemainingTimeText;
        private System.Windows.Forms.Button PomodoroButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DateTimePicker CustomTimePicker;
        private System.Windows.Forms.Button TimeSetButton;
        private System.Windows.Forms.ProgressBar RemainingTimeProgressBar;
    }
}

