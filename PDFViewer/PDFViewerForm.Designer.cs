namespace MyPrototype.PDFViewer
{
    partial class PDFViewerForm
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
            this.WebView2Button = new System.Windows.Forms.Button();
            this.ViewerWebView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.ViewerWebView2)).BeginInit();
            this.SuspendLayout();
            // 
            // WebView2Button
            // 
            this.WebView2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.WebView2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebView2Button.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WebView2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(109)))));
            this.WebView2Button.Location = new System.Drawing.Point(8, 8);
            this.WebView2Button.Name = "WebView2Button";
            this.WebView2Button.Size = new System.Drawing.Size(64, 30);
            this.WebView2Button.TabIndex = 2;
            this.WebView2Button.Text = "View";
            this.WebView2Button.UseVisualStyleBackColor = false;
            this.WebView2Button.Click += new System.EventHandler(this.WebView2Button_Click);
            // 
            // ViewerWebView2
            // 
            this.ViewerWebView2.AllowExternalDrop = true;
            this.ViewerWebView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(188)))), ((int)(((byte)(164)))));
            this.ViewerWebView2.CreationProperties = null;
            this.ViewerWebView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.ViewerWebView2.Location = new System.Drawing.Point(8, 46);
            this.ViewerWebView2.Name = "ViewerWebView2";
            this.ViewerWebView2.Size = new System.Drawing.Size(592, 480);
            this.ViewerWebView2.TabIndex = 3;
            this.ViewerWebView2.ZoomFactor = 1D;
            // 
            // PDFViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(616, 601);
            this.Controls.Add(this.ViewerWebView2);
            this.Controls.Add(this.WebView2Button);
            this.MinimizeBox = false;
            this.Name = "PDFViewerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.ViewerWebView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button WebView2Button;
        private Microsoft.Web.WebView2.WinForms.WebView2 ViewerWebView2;
    }
}

