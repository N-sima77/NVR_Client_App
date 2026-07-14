namespace SimpleSample_Rec
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
            this.buttonRecStart = new System.Windows.Forms.Button();
            this.buttonRecStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axipropsapiCtrl1
            // 
            this.axipropsapiCtrl1.Enabled = true;
            this.axipropsapiCtrl1.Location = new System.Drawing.Point(12, 48);
            this.axipropsapiCtrl1.Name = "axipropsapiCtrl1";
            this.axipropsapiCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axipropsapiCtrl1.OcxState")));
            this.axipropsapiCtrl1.Size = new System.Drawing.Size(192, 192);
            this.axipropsapiCtrl1.TabIndex = 0;
            this.axipropsapiCtrl1.Visible = false;
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
            // buttonRecStart
            // 
            this.buttonRecStart.Location = new System.Drawing.Point(12, 12);
            this.buttonRecStart.Name = "buttonRecStart";
            this.buttonRecStart.Size = new System.Drawing.Size(100, 30);
            this.buttonRecStart.TabIndex = 1;
            this.buttonRecStart.Text = "Rec Start";
            this.buttonRecStart.UseVisualStyleBackColor = true;
            this.buttonRecStart.Click += new System.EventHandler(this.buttonRecStart_Click);
            // 
            // buttonRecStop
            // 
            this.buttonRecStop.Location = new System.Drawing.Point(140, 12);
            this.buttonRecStop.Name = "buttonRecStop";
            this.buttonRecStop.Size = new System.Drawing.Size(100, 30);
            this.buttonRecStop.TabIndex = 2;
            this.buttonRecStop.Text = "Rec Stop";
            this.buttonRecStop.UseVisualStyleBackColor = true;
            this.buttonRecStop.Click += new System.EventHandler(this.buttonRecStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 66);
            this.Controls.Add(this.buttonRecStop);
            this.Controls.Add(this.buttonRecStart);
            this.Controls.Add(this.axipropsapiCtrl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_Rec";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl1;
        private System.Windows.Forms.Button buttonRecStart;
        private System.Windows.Forms.Button buttonRecStop;
    }
}

