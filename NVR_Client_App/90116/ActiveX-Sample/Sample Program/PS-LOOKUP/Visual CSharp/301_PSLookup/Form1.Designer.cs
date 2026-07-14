namespace SimpleSample_PSLookup
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
            this.AxpsLookupCtrl = new AxpslookupLib.Axpslookupctrl();
            this.b_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.AxpsLookupCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // AxpsLookupCtrl
            // 
            this.AxpsLookupCtrl.Enabled = true;
            this.AxpsLookupCtrl.Location = new System.Drawing.Point(434, 12);
            this.AxpsLookupCtrl.Name = "AxpsLookupCtrl";
            this.AxpsLookupCtrl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AxpsLookupCtrl.OcxState")));
            this.AxpsLookupCtrl.Size = new System.Drawing.Size(192, 192);
            this.AxpsLookupCtrl.TabIndex = 0;
            this.AxpsLookupCtrl.OnDevLookup += new AxpslookupLib._IpslookupctrlEvents_OnDevLookupEventHandler(this.AxpsLookupCtrl_OnDevLookup);
            this.AxpsLookupCtrl.OnError += new AxpslookupLib._IpslookupctrlEvents_OnErrorEventHandler(this.AxpsLookupCtrl_OnError);
            // 
            // b_Search
            // 
            this.b_Search.Location = new System.Drawing.Point(117, 15);
            this.b_Search.Name = "b_Search";
            this.b_Search.Size = new System.Drawing.Size(100, 30);
            this.b_Search.TabIndex = 1;
            this.b_Search.Text = "&Start";
            this.b_Search.UseVisualStyleBackColor = true;
            this.b_Search.Click += new System.EventHandler(this.b_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Cameras";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(14, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 292);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 366);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Search);
            this.Controls.Add(this.AxpsLookupCtrl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_PSLookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AxpsLookupCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxpslookupLib.Axpslookupctrl AxpsLookupCtrl;
        private System.Windows.Forms.Button b_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

