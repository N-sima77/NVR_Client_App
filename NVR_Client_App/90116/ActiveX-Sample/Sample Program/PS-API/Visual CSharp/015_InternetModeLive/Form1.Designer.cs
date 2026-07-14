namespace SimpleSample_InternetModeLive
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
            this.AxiProCtrl = new AxIPROPSAPILib.AxipropsapiCtrl();
            this.b_LiveStart = new System.Windows.Forms.Button();
            this.b_LiveEnd = new System.Windows.Forms.Button();
            this.b_SetInternetMode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AxiProCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // AxiProCtrl
            // 
            this.AxiProCtrl.Enabled = true;
            this.AxiProCtrl.Location = new System.Drawing.Point(12, 12);
            this.AxiProCtrl.Name = "AxiProCtrl";
            this.AxiProCtrl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AxiProCtrl.OcxState")));
            this.AxiProCtrl.Size = new System.Drawing.Size(640, 480);
            this.AxiProCtrl.TabIndex = 0;
            this.AxiProCtrl.OnError += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEventHandler(this.AxiProCtrl_OnError);
            this.AxiProCtrl.OnPlayStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEventHandler(this.AxiProCtrl_OnPlayStatus);
            // 
            // b_LiveStart
            // 
            this.b_LiveStart.Location = new System.Drawing.Point(12, 514);
            this.b_LiveStart.Name = "b_LiveStart";
            this.b_LiveStart.Size = new System.Drawing.Size(100, 30);
            this.b_LiveStart.TabIndex = 1;
            this.b_LiveStart.Text = "Live &Start";
            this.b_LiveStart.UseVisualStyleBackColor = true;
            this.b_LiveStart.Click += new System.EventHandler(this.b_LiveStart_Click);
            // 
            // b_LiveEnd
            // 
            this.b_LiveEnd.Location = new System.Drawing.Point(118, 514);
            this.b_LiveEnd.Name = "b_LiveEnd";
            this.b_LiveEnd.Size = new System.Drawing.Size(100, 30);
            this.b_LiveEnd.TabIndex = 2;
            this.b_LiveEnd.Text = "Live &End";
            this.b_LiveEnd.UseVisualStyleBackColor = true;
            this.b_LiveEnd.Click += new System.EventHandler(this.b_LiveEnd_Click);
            // 
            // b_SetInternetMode
            // 
            this.b_SetInternetMode.Location = new System.Drawing.Point(12, 550);
            this.b_SetInternetMode.Name = "b_SetInternetMode";
            this.b_SetInternetMode.Size = new System.Drawing.Size(100, 30);
            this.b_SetInternetMode.TabIndex = 3;
            this.b_SetInternetMode.Text = "Set Internet&Mode";
            this.b_SetInternetMode.UseVisualStyleBackColor = true;
            this.b_SetInternetMode.Click += new System.EventHandler(this.b_SetInternetMode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 561);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 19);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 596);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_SetInternetMode);
            this.Controls.Add(this.b_LiveEnd);
            this.Controls.Add(this.b_LiveStart);
            this.Controls.Add(this.AxiProCtrl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_InternetModeLive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AxiProCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxIPROPSAPILib.AxipropsapiCtrl AxiProCtrl;
        private System.Windows.Forms.Button b_LiveStart;
        private System.Windows.Forms.Button b_LiveEnd;
        private System.Windows.Forms.Button b_SetInternetMode;
        private System.Windows.Forms.TextBox textBox1;
    }
}

