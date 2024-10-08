﻿namespace MyPrototype.SelectMenu
{
    partial class SelectMenuForm
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
            this.RunPomodoroButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.RunPDFViewerButtion = new System.Windows.Forms.Button();
            this.RunBrowserButtion = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunPomodoroButton
            // 
            this.RunPomodoroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.RunPomodoroButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.RunPomodoroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunPomodoroButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RunPomodoroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.RunPomodoroButton.Location = new System.Drawing.Point(0, 0);
            this.RunPomodoroButton.Name = "RunPomodoroButton";
            this.RunPomodoroButton.Size = new System.Drawing.Size(128, 32);
            this.RunPomodoroButton.TabIndex = 0;
            this.RunPomodoroButton.Text = "Pomodoro";
            this.RunPomodoroButton.UseVisualStyleBackColor = false;
            this.RunPomodoroButton.Click += new System.EventHandler(this.RunPomodoroButton_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.RunBrowserButtion);
            this.MenuPanel.Controls.Add(this.RunPDFViewerButtion);
            this.MenuPanel.Controls.Add(this.RunPomodoroButton);
            this.MenuPanel.Location = new System.Drawing.Point(8, 8);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(128, 128);
            this.MenuPanel.TabIndex = 1;
            // 
            // RunPDFViewerButtion
            // 
            this.RunPDFViewerButtion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.RunPDFViewerButtion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.RunPDFViewerButtion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunPDFViewerButtion.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RunPDFViewerButtion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.RunPDFViewerButtion.Location = new System.Drawing.Point(0, 32);
            this.RunPDFViewerButtion.Name = "RunPDFViewerButtion";
            this.RunPDFViewerButtion.Size = new System.Drawing.Size(128, 32);
            this.RunPDFViewerButtion.TabIndex = 1;
            this.RunPDFViewerButtion.Text = "PDF Viewer";
            this.RunPDFViewerButtion.UseVisualStyleBackColor = false;
            this.RunPDFViewerButtion.Click += new System.EventHandler(this.RunPDFViewerButtion_Click);
            // 
            // RunBrowserButtion
            // 
            this.RunBrowserButtion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.RunBrowserButtion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.RunBrowserButtion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunBrowserButtion.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RunBrowserButtion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.RunBrowserButtion.Location = new System.Drawing.Point(0, 64);
            this.RunBrowserButtion.Name = "RunBrowserButtion";
            this.RunBrowserButtion.Size = new System.Drawing.Size(128, 32);
            this.RunBrowserButtion.TabIndex = 2;
            this.RunBrowserButtion.Text = "Browser";
            this.RunBrowserButtion.UseVisualStyleBackColor = false;
            this.RunBrowserButtion.Click += new System.EventHandler(this.RunBrowserButtion_Click);
            // 
            // SelectMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(144, 143);
            this.Controls.Add(this.MenuPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Menu";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunPomodoroButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button RunPDFViewerButtion;
        private System.Windows.Forms.Button RunBrowserButtion;
    }
}

