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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountdownTimerForm));
            this.RemainingTimeText = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PomodoroButton = new System.Windows.Forms.Button();
            this.CustomTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeSetButton = new System.Windows.Forms.Button();
            this.RemainingTimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemainingTimeText
            // 
            this.RemainingTimeText.AutoSize = true;
            this.RemainingTimeText.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.RemainingTimeText.Location = new System.Drawing.Point(19, 26);
            this.RemainingTimeText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RemainingTimeText.Name = "RemainingTimeText";
            this.RemainingTimeText.Size = new System.Drawing.Size(121, 49);
            this.RemainingTimeText.TabIndex = 1;
            this.RemainingTimeText.Text = "--:--";
            this.RemainingTimeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RemainingTimeText.Click += new System.EventHandler(this.RemainingTimeText_Click);
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.No;
            this.StartButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(176, 100);
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
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(203)))), ((int)(((byte)(60)))));
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.ResetButton.Location = new System.Drawing.Point(244, 60);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(64, 30);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(203)))), ((int)(((byte)(60)))));
            this.PauseButton.FlatAppearance.BorderSize = 0;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.PauseButton.Location = new System.Drawing.Point(176, 60);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(5);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(64, 30);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PomodoroButton
            // 
            this.PomodoroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.PomodoroButton.FlatAppearance.BorderSize = 0;
            this.PomodoroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PomodoroButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PomodoroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(229)))));
            this.PomodoroButton.Location = new System.Drawing.Point(176, 26);
            this.PomodoroButton.Margin = new System.Windows.Forms.Padding(5);
            this.PomodoroButton.Name = "PomodoroButton";
            this.PomodoroButton.Size = new System.Drawing.Size(132, 30);
            this.PomodoroButton.TabIndex = 6;
            this.PomodoroButton.Text = "Start-Pomodoro";
            this.PomodoroButton.UseVisualStyleBackColor = false;
            this.PomodoroButton.Click += new System.EventHandler(this.PomodoroButton_Click);
            // 
            // CustomTimePicker
            // 
            this.CustomTimePicker.CustomFormat = "HH:mm";
            this.CustomTimePicker.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CustomTimePicker.Location = new System.Drawing.Point(16, 102);
            this.CustomTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.CustomTimePicker.Name = "CustomTimePicker";
            this.CustomTimePicker.ShowUpDown = true;
            this.CustomTimePicker.Size = new System.Drawing.Size(64, 28);
            this.CustomTimePicker.TabIndex = 7;
            // 
            // TimeSetButton
            // 
            this.TimeSetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(203)))), ((int)(((byte)(60)))));
            this.TimeSetButton.FlatAppearance.BorderSize = 0;
            this.TimeSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeSetButton.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeSetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.TimeSetButton.Location = new System.Drawing.Point(84, 100);
            this.TimeSetButton.Margin = new System.Windows.Forms.Padding(5);
            this.TimeSetButton.Name = "TimeSetButton";
            this.TimeSetButton.Size = new System.Drawing.Size(60, 30);
            this.TimeSetButton.TabIndex = 8;
            this.TimeSetButton.Text = "Set";
            this.TimeSetButton.UseVisualStyleBackColor = false;
            this.TimeSetButton.Click += new System.EventHandler(this.TimeSetButton_Click);
            // 
            // RemainingTimeProgressBar
            // 
            this.RemainingTimeProgressBar.Location = new System.Drawing.Point(16, 74);
            this.RemainingTimeProgressBar.MarqueeAnimationSpeed = 1;
            this.RemainingTimeProgressBar.Name = "RemainingTimeProgressBar";
            this.RemainingTimeProgressBar.Size = new System.Drawing.Size(128, 16);
            this.RemainingTimeProgressBar.Step = 1;
            this.RemainingTimeProgressBar.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.PauseToolStripMenuItem,
            this.StopToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.FileToolStripMenuItem.Text = "File（&F）";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.StartToolStripMenuItem.Text = "Start Pomodoro";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // PauseToolStripMenuItem
            // 
            this.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem";
            this.PauseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.PauseToolStripMenuItem.Text = "Pause";
            this.PauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.StopToolStripMenuItem.Text = "Stop and Reset";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResizeToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ViewToolStripMenuItem.Text = "View（&V）";
            // 
            // ResizeToolStripMenuItem
            // 
            this.ResizeToolStripMenuItem.CheckOnClick = true;
            this.ResizeToolStripMenuItem.Name = "ResizeToolStripMenuItem";
            this.ResizeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ResizeToolStripMenuItem.Text = "Display of Time Setting Area";
            this.ResizeToolStripMenuItem.Click += new System.EventHandler(this.ResizeDisplayToolStripMenuItem_Click);
            // 
            // CountdownTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(320, 138);
            this.Controls.Add(this.RemainingTimeProgressBar);
            this.Controls.Add(this.TimeSetButton);
            this.Controls.Add(this.CustomTimePicker);
            this.Controls.Add(this.PomodoroButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.RemainingTimeText);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("メイリオ", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountdownTimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pomodoro";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CountdownTimerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResizeToolStripMenuItem;
    }
}

