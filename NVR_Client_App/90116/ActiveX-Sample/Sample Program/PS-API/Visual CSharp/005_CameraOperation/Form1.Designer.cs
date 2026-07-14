namespace SimpleSample_CamOp
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
            this.buttonGetCamPosition = new System.Windows.Forms.Button();
            this.buttonSetCamPosition1 = new System.Windows.Forms.Button();
            this.buttonSetCamPosition2 = new System.Windows.Forms.Button();
            this.buttonNonOperation = new System.Windows.Forms.Button();
            this.buttonAutoTrack = new System.Windows.Forms.Button();
            this.buttonAutoPan = new System.Windows.Forms.Button();
            this.buttonAutoFocus = new System.Windows.Forms.Button();
            this.buttonSetPreset = new System.Windows.Forms.Button();
            this.buttonCallPreset = new System.Windows.Forms.Button();
            this.buttonDeletePreset = new System.Windows.Forms.Button();
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
            // buttonGetCamPosition
            // 
            this.buttonGetCamPosition.Location = new System.Drawing.Point(12, 516);
            this.buttonGetCamPosition.Name = "buttonGetCamPosition";
            this.buttonGetCamPosition.Size = new System.Drawing.Size(120, 30);
            this.buttonGetCamPosition.TabIndex = 1;
            this.buttonGetCamPosition.Text = "GetCamPosition";
            this.buttonGetCamPosition.UseVisualStyleBackColor = true;
            this.buttonGetCamPosition.Click += new System.EventHandler(this.buttonGetCamPosition_Click);
            // 
            // buttonSetCamPosition1
            // 
            this.buttonSetCamPosition1.Location = new System.Drawing.Point(175, 516);
            this.buttonSetCamPosition1.Name = "buttonSetCamPosition1";
            this.buttonSetCamPosition1.Size = new System.Drawing.Size(120, 30);
            this.buttonSetCamPosition1.TabIndex = 2;
            this.buttonSetCamPosition1.Text = "SetCamPosition 1";
            this.buttonSetCamPosition1.UseVisualStyleBackColor = true;
            this.buttonSetCamPosition1.Click += new System.EventHandler(this.buttonSetCamPosition1_Click);
            // 
            // buttonSetCamPosition2
            // 
            this.buttonSetCamPosition2.Location = new System.Drawing.Point(301, 516);
            this.buttonSetCamPosition2.Name = "buttonSetCamPosition2";
            this.buttonSetCamPosition2.Size = new System.Drawing.Size(120, 30);
            this.buttonSetCamPosition2.TabIndex = 3;
            this.buttonSetCamPosition2.Text = "SetCamPosition 2";
            this.buttonSetCamPosition2.UseVisualStyleBackColor = true;
            this.buttonSetCamPosition2.Click += new System.EventHandler(this.buttonSetCamPosition2_Click);
            // 
            // buttonNonOperation
            // 
            this.buttonNonOperation.Location = new System.Drawing.Point(12, 562);
            this.buttonNonOperation.Name = "buttonNonOperation";
            this.buttonNonOperation.Size = new System.Drawing.Size(120, 30);
            this.buttonNonOperation.TabIndex = 4;
            this.buttonNonOperation.Text = "NonOperation";
            this.buttonNonOperation.UseVisualStyleBackColor = true;
            this.buttonNonOperation.Click += new System.EventHandler(this.buttonNonOperation_Click);
            // 
            // buttonAutoTrack
            // 
            this.buttonAutoTrack.Location = new System.Drawing.Point(175, 562);
            this.buttonAutoTrack.Name = "buttonAutoTrack";
            this.buttonAutoTrack.Size = new System.Drawing.Size(120, 30);
            this.buttonAutoTrack.TabIndex = 5;
            this.buttonAutoTrack.Text = "AutoTrack";
            this.buttonAutoTrack.UseVisualStyleBackColor = true;
            this.buttonAutoTrack.Click += new System.EventHandler(this.buttonAutoTrack_Click);
            // 
            // buttonAutoPan
            // 
            this.buttonAutoPan.Location = new System.Drawing.Point(301, 562);
            this.buttonAutoPan.Name = "buttonAutoPan";
            this.buttonAutoPan.Size = new System.Drawing.Size(120, 30);
            this.buttonAutoPan.TabIndex = 6;
            this.buttonAutoPan.Text = "AutoPan";
            this.buttonAutoPan.UseVisualStyleBackColor = true;
            this.buttonAutoPan.Click += new System.EventHandler(this.buttonAutoPan_Click);
            // 
            // buttonAutoFocus
            // 
            this.buttonAutoFocus.Location = new System.Drawing.Point(427, 562);
            this.buttonAutoFocus.Name = "buttonAutoFocus";
            this.buttonAutoFocus.Size = new System.Drawing.Size(120, 30);
            this.buttonAutoFocus.TabIndex = 7;
            this.buttonAutoFocus.Text = "AutoFocus";
            this.buttonAutoFocus.UseVisualStyleBackColor = true;
            this.buttonAutoFocus.Click += new System.EventHandler(this.buttonAutoFocus_Click);
            // 
            // buttonSetPreset
            // 
            this.buttonSetPreset.Location = new System.Drawing.Point(175, 598);
            this.buttonSetPreset.Name = "buttonSetPreset";
            this.buttonSetPreset.Size = new System.Drawing.Size(120, 30);
            this.buttonSetPreset.TabIndex = 8;
            this.buttonSetPreset.Text = "Set Preset";
            this.buttonSetPreset.UseVisualStyleBackColor = true;
            this.buttonSetPreset.Click += new System.EventHandler(this.buttonSetPreset_Click);
            // 
            // buttonCallPreset
            // 
            this.buttonCallPreset.Location = new System.Drawing.Point(301, 598);
            this.buttonCallPreset.Name = "buttonCallPreset";
            this.buttonCallPreset.Size = new System.Drawing.Size(120, 30);
            this.buttonCallPreset.TabIndex = 9;
            this.buttonCallPreset.Text = "Call Preset";
            this.buttonCallPreset.UseVisualStyleBackColor = true;
            this.buttonCallPreset.Click += new System.EventHandler(this.buttonCallPreset_Click);
            // 
            // buttonDeletePreset
            // 
            this.buttonDeletePreset.Location = new System.Drawing.Point(427, 598);
            this.buttonDeletePreset.Name = "buttonDeletePreset";
            this.buttonDeletePreset.Size = new System.Drawing.Size(120, 30);
            this.buttonDeletePreset.TabIndex = 10;
            this.buttonDeletePreset.Text = "Delete Preset";
            this.buttonDeletePreset.UseVisualStyleBackColor = true;
            this.buttonDeletePreset.Click += new System.EventHandler(this.buttonDeletePreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 646);
            this.Controls.Add(this.buttonDeletePreset);
            this.Controls.Add(this.buttonCallPreset);
            this.Controls.Add(this.buttonSetPreset);
            this.Controls.Add(this.buttonAutoFocus);
            this.Controls.Add(this.buttonAutoPan);
            this.Controls.Add(this.buttonAutoTrack);
            this.Controls.Add(this.buttonNonOperation);
            this.Controls.Add(this.buttonSetCamPosition2);
            this.Controls.Add(this.buttonSetCamPosition1);
            this.Controls.Add(this.buttonGetCamPosition);
            this.Controls.Add(this.axipropsapiCtrl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_CamOp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl1;
        private System.Windows.Forms.Button buttonGetCamPosition;
        private System.Windows.Forms.Button buttonSetCamPosition1;
        private System.Windows.Forms.Button buttonSetCamPosition2;
        private System.Windows.Forms.Button buttonNonOperation;
        private System.Windows.Forms.Button buttonAutoTrack;
        private System.Windows.Forms.Button buttonAutoPan;
        private System.Windows.Forms.Button buttonAutoFocus;
        private System.Windows.Forms.Button buttonSetPreset;
        private System.Windows.Forms.Button buttonCallPreset;
        private System.Windows.Forms.Button buttonDeletePreset;
    }
}

