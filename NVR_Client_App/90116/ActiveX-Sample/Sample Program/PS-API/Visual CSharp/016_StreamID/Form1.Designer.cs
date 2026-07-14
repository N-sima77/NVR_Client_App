namespace SimpleSample_StreamID
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
            this.buttonLiveStart = new System.Windows.Forms.Button();
            this.buttonLiveStop = new System.Windows.Forms.Button();
            this.axipropsapiCtrl2 = new AxIPROPSAPILib.AxipropsapiCtrl();
            this.axipropsapiCtrl3 = new AxIPROPSAPILib.AxipropsapiCtrl();
            this.axipropsapiCtrl4 = new AxIPROPSAPILib.AxipropsapiCtrl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl4)).BeginInit();
            this.SuspendLayout();
            // 
            // axipropsapiCtrl1
            // 
            this.axipropsapiCtrl1.Enabled = true;
            this.axipropsapiCtrl1.Location = new System.Drawing.Point(12, 12);
            this.axipropsapiCtrl1.Name = "axipropsapiCtrl1";
            this.axipropsapiCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axipropsapiCtrl1.OcxState")));
            this.axipropsapiCtrl1.Size = new System.Drawing.Size(320, 240);
            this.axipropsapiCtrl1.TabIndex = 0;
            this.axipropsapiCtrl1.TabStop = false;
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
            // buttonLiveStart
            // 
            this.buttonLiveStart.Location = new System.Drawing.Point(12, 513);
            this.buttonLiveStart.Name = "buttonLiveStart";
            this.buttonLiveStart.Size = new System.Drawing.Size(100, 30);
            this.buttonLiveStart.TabIndex = 1;
            this.buttonLiveStart.Text = "Live";
            this.buttonLiveStart.UseVisualStyleBackColor = true;
            this.buttonLiveStart.Click += new System.EventHandler(this.buttonLiveStart_Click);
            // 
            // buttonLiveStop
            // 
            this.buttonLiveStop.Location = new System.Drawing.Point(318, 513);
            this.buttonLiveStop.Name = "buttonLiveStop";
            this.buttonLiveStop.Size = new System.Drawing.Size(100, 30);
            this.buttonLiveStop.TabIndex = 2;
            this.buttonLiveStop.Text = "Stop";
            this.buttonLiveStop.UseVisualStyleBackColor = true;
            this.buttonLiveStop.Click += new System.EventHandler(this.buttonLiveStop_Click);
            // 
            // axipropsapiCtrl2
            // 
            this.axipropsapiCtrl2.Enabled = true;
            this.axipropsapiCtrl2.Location = new System.Drawing.Point(340, 12);
            this.axipropsapiCtrl2.Name = "axipropsapiCtrl2";
            this.axipropsapiCtrl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axipropsapiCtrl2.OcxState")));
            this.axipropsapiCtrl2.Size = new System.Drawing.Size(320, 240);
            this.axipropsapiCtrl2.TabIndex = 4;
            this.axipropsapiCtrl2.TabStop = false;
            // 
            // axipropsapiCtrl3
            // 
            this.axipropsapiCtrl3.Enabled = true;
            this.axipropsapiCtrl3.Location = new System.Drawing.Point(12, 258);
            this.axipropsapiCtrl3.Name = "axipropsapiCtrl3";
            this.axipropsapiCtrl3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axipropsapiCtrl3.OcxState")));
            this.axipropsapiCtrl3.Size = new System.Drawing.Size(320, 240);
            this.axipropsapiCtrl3.TabIndex = 5;
            this.axipropsapiCtrl3.TabStop = false;
            // 
            // axipropsapiCtrl4
            // 
            this.axipropsapiCtrl4.Enabled = true;
            this.axipropsapiCtrl4.Location = new System.Drawing.Point(340, 258);
            this.axipropsapiCtrl4.Name = "axipropsapiCtrl4";
            this.axipropsapiCtrl4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axipropsapiCtrl4.OcxState")));
            this.axipropsapiCtrl4.Size = new System.Drawing.Size(320, 240);
            this.axipropsapiCtrl4.TabIndex = 6;
            this.axipropsapiCtrl4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "UID in use";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "StreamID in use";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 513);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 19);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(593, 542);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 19);
            this.textBox2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Live and Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axipropsapiCtrl4);
            this.Controls.Add(this.axipropsapiCtrl3);
            this.Controls.Add(this.axipropsapiCtrl2);
            this.Controls.Add(this.buttonLiveStop);
            this.Controls.Add(this.buttonLiveStart);
            this.Controls.Add(this.axipropsapiCtrl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_StreamID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl1;
        private System.Windows.Forms.Button buttonLiveStart;
        private System.Windows.Forms.Button buttonLiveStop;
        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl2;
        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl3;
        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}

