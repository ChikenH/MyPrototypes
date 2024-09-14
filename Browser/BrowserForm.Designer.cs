namespace MyPrototype.Browser
{
    partial class BrowserForm
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
            this.StartBrowserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBrowserButton
            // 
            this.StartBrowserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(50)))));
            this.StartBrowserButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartBrowserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.StartBrowserButton.Location = new System.Drawing.Point(8, 8);
            this.StartBrowserButton.Name = "StartBrowserButton";
            this.StartBrowserButton.Size = new System.Drawing.Size(128, 32);
            this.StartBrowserButton.TabIndex = 0;
            this.StartBrowserButton.Text = "Process Start";
            this.StartBrowserButton.UseVisualStyleBackColor = false;
            this.StartBrowserButton.Click += new System.EventHandler(this.StartBrowserButton_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(144, 51);
            this.Controls.Add(this.StartBrowserButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrowserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBrowserButton;
    }
}

