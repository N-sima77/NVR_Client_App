namespace SimpleSample_Play
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
            this.buttonPrevFrame = new System.Windows.Forms.Button();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlayBack = new System.Windows.Forms.Button();
            this.buttonFF = new System.Windows.Forms.Button();
            this.buttonNextFrame = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPrevRec = new System.Windows.Forms.Button();
            this.buttonNextRec = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            // buttonPrevFrame
            // 
            this.buttonPrevFrame.Location = new System.Drawing.Point(118, 549);
            this.buttonPrevFrame.Name = "buttonPrevFrame";
            this.buttonPrevFrame.Size = new System.Drawing.Size(100, 30);
            this.buttonPrevFrame.TabIndex = 8;
            this.buttonPrevFrame.Text = "<|| PrevFrame";
            this.buttonPrevFrame.UseVisualStyleBackColor = true;
            this.buttonPrevFrame.Click += new System.EventHandler(this.buttonPrevFrame_Click);
            // 
            // buttonRewind
            // 
            this.buttonRewind.Location = new System.Drawing.Point(12, 513);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(100, 30);
            this.buttonRewind.TabIndex = 1;
            this.buttonRewind.Text = "<< Rewind";
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(118, 513);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(100, 30);
            this.buttonReverse.TabIndex = 2;
            this.buttonReverse.Text = "< Backward";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(330, 513);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(100, 30);
            this.buttonPause.TabIndex = 4;
            this.buttonPause.Text = "|| Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlayBack
            // 
            this.buttonPlayBack.Location = new System.Drawing.Point(436, 513);
            this.buttonPlayBack.Name = "buttonPlayBack";
            this.buttonPlayBack.Size = new System.Drawing.Size(100, 30);
            this.buttonPlayBack.TabIndex = 5;
            this.buttonPlayBack.Text = "> Playback";
            this.buttonPlayBack.UseVisualStyleBackColor = true;
            this.buttonPlayBack.Click += new System.EventHandler(this.buttonPlayBack_Click);
            // 
            // buttonFF
            // 
            this.buttonFF.Location = new System.Drawing.Point(542, 513);
            this.buttonFF.Name = "buttonFF";
            this.buttonFF.Size = new System.Drawing.Size(100, 30);
            this.buttonFF.TabIndex = 6;
            this.buttonFF.Text = ">> Fast Fwd";
            this.buttonFF.UseVisualStyleBackColor = true;
            this.buttonFF.Click += new System.EventHandler(this.buttonFF_Click);
            // 
            // buttonNextFrame
            // 
            this.buttonNextFrame.Location = new System.Drawing.Point(436, 549);
            this.buttonNextFrame.Name = "buttonNextFrame";
            this.buttonNextFrame.Size = new System.Drawing.Size(100, 30);
            this.buttonNextFrame.TabIndex = 9;
            this.buttonNextFrame.Text = "||> NextFrame";
            this.buttonNextFrame.UseVisualStyleBackColor = true;
            this.buttonNextFrame.Click += new System.EventHandler(this.buttonNextFrame_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(224, 513);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 30);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "[] Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPrevRec
            // 
            this.buttonPrevRec.Location = new System.Drawing.Point(12, 549);
            this.buttonPrevRec.Name = "buttonPrevRec";
            this.buttonPrevRec.Size = new System.Drawing.Size(100, 30);
            this.buttonPrevRec.TabIndex = 7;
            this.buttonPrevRec.Text = "|<< PrevRecord";
            this.buttonPrevRec.UseVisualStyleBackColor = true;
            this.buttonPrevRec.Click += new System.EventHandler(this.buttonPrevRec_Click);
            // 
            // buttonNextRec
            // 
            this.buttonNextRec.Location = new System.Drawing.Point(542, 549);
            this.buttonNextRec.Name = "buttonNextRec";
            this.buttonNextRec.Size = new System.Drawing.Size(100, 30);
            this.buttonNextRec.TabIndex = 10;
            this.buttonNextRec.Text = ">>| NextRecord";
            this.buttonNextRec.UseVisualStyleBackColor = true;
            this.buttonNextRec.Click += new System.EventHandler(this.buttonNextRec_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 588);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Fast and smooth playback";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 616);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonNextRec);
            this.Controls.Add(this.buttonPrevRec);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonNextFrame);
            this.Controls.Add(this.buttonFF);
            this.Controls.Add(this.buttonPlayBack);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonRewind);
            this.Controls.Add(this.buttonPrevFrame);
            this.Controls.Add(this.axipropsapiCtrl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_Play";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl1;
        private System.Windows.Forms.Button buttonPrevFrame;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPlayBack;
        private System.Windows.Forms.Button buttonFF;
        private System.Windows.Forms.Button buttonNextFrame;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPrevRec;
        private System.Windows.Forms.Button buttonNextRec;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

