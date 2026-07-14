namespace SimpleSample_SnapShot
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axipropsapiCtrl1 = new AxIPROPSAPILib.AxipropsapiCtrl();
            this.b_DZoom1 = new System.Windows.Forms.Button();
            this.b_ZoomRight = new System.Windows.Forms.Button();
            this.b_DZoom4 = new System.Windows.Forms.Button();
            this.bSnapShot = new System.Windows.Forms.Button();
            this.b_DZoomLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axipropsapiCtrl1
            // 
            this.axipropsapiCtrl1.Enabled = true;
            this.axipropsapiCtrl1.Location = new System.Drawing.Point(12, 12);
            this.axipropsapiCtrl1.Name = "axipropsapiCtrl1";
            this.axipropsapiCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axipropsapiCtrl1.OcxState")));
            this.axipropsapiCtrl1.Size = new System.Drawing.Size(640, 480);
            this.axipropsapiCtrl1.TabIndex = 0;
            this.axipropsapiCtrl1.OnSearchCB += new System.EventHandler(this.axipropsapiCtrl1_OnSearchCB);
            this.axipropsapiCtrl1.OnError += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEventHandler(this.axipropsapiCtrl1_OnError);
            this.axipropsapiCtrl1.OnDevStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEventHandler(this.axipropsapiCtrl1_OnDevStatus);
            this.axipropsapiCtrl1.OnPlayStatusCB += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEventHandler(this.axipropsapiCtrl1_OnPlayStatusCB);
            this.axipropsapiCtrl1.OnOpStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEventHandler(this.axipropsapiCtrl1_OnOpStatus);
            this.axipropsapiCtrl1.OnImageRefresh += new System.EventHandler(this.axipropsapiCtrl1_OnImageRefresh);
            this.axipropsapiCtrl1.OnAlmStatusCB += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEventHandler(this.axipropsapiCtrl1_OnAlmStatusCB);
            this.axipropsapiCtrl1.OnOpStatusCB += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEventHandler(this.axipropsapiCtrl1_OnOpStatusCB);
            this.axipropsapiCtrl1.OnAlmStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEventHandler(this.axipropsapiCtrl1_OnAlmStatus);
            this.axipropsapiCtrl1.OnFtpStatusCB += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEventHandler(this.axipropsapiCtrl1_OnFtpStatusCB);
            this.axipropsapiCtrl1.OnPlayStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEventHandler(this.axipropsapiCtrl1_OnPlayStatus);
            this.axipropsapiCtrl1.OnRecStatusCB += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEventHandler(this.axipropsapiCtrl1_OnRecStatusCB);
            this.axipropsapiCtrl1.OnSearchExCB += new System.EventHandler(this.axipropsapiCtrl1_OnSearchExCB);
            this.axipropsapiCtrl1.OnRecordStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEventHandler(this.axipropsapiCtrl1_OnRecordStatus);
            this.axipropsapiCtrl1.OnRecStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEventHandler(this.axipropsapiCtrl1_OnRecStatus);
            // 
            // b_DZoom1
            // 
            this.b_DZoom1.Location = new System.Drawing.Point(18, 549);
            this.b_DZoom1.Name = "b_DZoom1";
            this.b_DZoom1.Size = new System.Drawing.Size(120, 30);
            this.b_DZoom1.TabIndex = 1;
            this.b_DZoom1.Text = "Digital Zoom (x1)";
            this.b_DZoom1.UseVisualStyleBackColor = true;
            this.b_DZoom1.Click += new System.EventHandler(this.b_DZoom1_Click);
            // 
            // b_ZoomRight
            // 
            this.b_ZoomRight.Location = new System.Drawing.Point(423, 549);
            this.b_ZoomRight.Name = "b_ZoomRight";
            this.b_ZoomRight.Size = new System.Drawing.Size(120, 30);
            this.b_ZoomRight.TabIndex = 2;
            this.b_ZoomRight.Text = "Move to Right";
            this.b_ZoomRight.UseVisualStyleBackColor = true;
            this.b_ZoomRight.Click += new System.EventHandler(this.b_DZoomRight_Click);
            // 
            // b_DZoom4
            // 
            this.b_DZoom4.Location = new System.Drawing.Point(144, 549);
            this.b_DZoom4.Name = "b_DZoom4";
            this.b_DZoom4.Size = new System.Drawing.Size(120, 30);
            this.b_DZoom4.TabIndex = 3;
            this.b_DZoom4.Text = "Digital Zoom (x4)";
            this.b_DZoom4.UseVisualStyleBackColor = true;
            this.b_DZoom4.Click += new System.EventHandler(this.b_DZoom4_Click);
            // 
            // bSnapShot
            // 
            this.bSnapShot.Location = new System.Drawing.Point(423, 504);
            this.bSnapShot.Name = "bSnapShot";
            this.bSnapShot.Size = new System.Drawing.Size(120, 30);
            this.bSnapShot.TabIndex = 4;
            this.bSnapShot.Text = "Jpeg Snap Shot";
            this.bSnapShot.UseVisualStyleBackColor = true;
            this.bSnapShot.Click += new System.EventHandler(this.bSnapShot_Click);
            // 
            // b_DZoomLeft
            // 
            this.b_DZoomLeft.Location = new System.Drawing.Point(297, 549);
            this.b_DZoomLeft.Name = "b_DZoomLeft";
            this.b_DZoomLeft.Size = new System.Drawing.Size(120, 30);
            this.b_DZoomLeft.TabIndex = 9;
            this.b_DZoomLeft.Text = "Move to Left";
            this.b_DZoomLeft.UseVisualStyleBackColor = true;
            this.b_DZoomLeft.Click += new System.EventHandler(this.b_DZoomLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "fileName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 510);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 19);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "C:\\JpegSnapShot.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 596);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_DZoomLeft);
            this.Controls.Add(this.bSnapShot);
            this.Controls.Add(this.b_DZoom4);
            this.Controls.Add(this.b_ZoomRight);
            this.Controls.Add(this.b_DZoom1);
            this.Controls.Add(this.axipropsapiCtrl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_SnapShot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl1;
        private System.Windows.Forms.Button b_DZoom1;
        private System.Windows.Forms.Button b_ZoomRight;
        private System.Windows.Forms.Button b_DZoom4;
        private System.Windows.Forms.Button bSnapShot;
        private System.Windows.Forms.Button b_DZoomLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

