namespace SimpleSample_VMDSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textEndSecond = new System.Windows.Forms.TextBox();
            this.textEndMinute = new System.Windows.Forms.TextBox();
            this.textEndHour = new System.Windows.Forms.TextBox();
            this.textEndDay = new System.Windows.Forms.TextBox();
            this.textEndMonth = new System.Windows.Forms.TextBox();
            this.textEndYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textStartSecond = new System.Windows.Forms.TextBox();
            this.textStartMinute = new System.Windows.Forms.TextBox();
            this.textStartHour = new System.Windows.Forms.TextBox();
            this.textStartDay = new System.Windows.Forms.TextBox();
            this.textStartMonth = new System.Windows.Forms.TextBox();
            this.textStartYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bVMDSearch_Click = new System.Windows.Forms.Button();
            this.listSearchResult = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.axipropsapiCtrl1.OnSearchCB += new System.EventHandler(this.axipropsapiCtrl1_OnSearchCB);
            this.axipropsapiCtrl1.OnError += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEventHandler(this.axipropsapiCtrl1_OnError);
            this.axipropsapiCtrl1.OnDevStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEventHandler(this.axipropsapiCtrl1_OnDevStatus);
            this.axipropsapiCtrl1.MouseDownEvent += new AxIPROPSAPILib._IipropsapiCtrlEvents_MouseDownEventHandler(this.axipropsapiCtrl1_MouseDownEvent);
            this.axipropsapiCtrl1.OnPlayStatusCB += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEventHandler(this.axipropsapiCtrl1_OnPlayStatusCB);
            this.axipropsapiCtrl1.OnOpStatus += new AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEventHandler(this.axipropsapiCtrl1_OnOpStatus);
            this.axipropsapiCtrl1.MouseUpEvent += new AxIPROPSAPILib._IipropsapiCtrlEvents_MouseUpEventHandler(this.axipropsapiCtrl1_MouseUpEvent);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textEndSecond);
            this.groupBox1.Controls.Add(this.textEndMinute);
            this.groupBox1.Controls.Add(this.textEndHour);
            this.groupBox1.Controls.Add(this.textEndDay);
            this.groupBox1.Controls.Add(this.textEndMonth);
            this.groupBox1.Controls.Add(this.textEndYear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textStartSecond);
            this.groupBox1.Controls.Add(this.textStartMinute);
            this.groupBox1.Controls.Add(this.textStartHour);
            this.groupBox1.Controls.Add(this.textStartDay);
            this.groupBox1.Controls.Add(this.textStartMonth);
            this.groupBox1.Controls.Add(this.textStartYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(344, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SearchCondition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(7, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(7, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "/";
            // 
            // textEndSecond
            // 
            this.textEndSecond.Location = new System.Drawing.Point(331, 87);
            this.textEndSecond.Name = "textEndSecond";
            this.textEndSecond.Size = new System.Drawing.Size(40, 19);
            this.textEndSecond.TabIndex = 17;
            this.textEndSecond.Text = "59";
            // 
            // textEndMinute
            // 
            this.textEndMinute.Location = new System.Drawing.Point(272, 87);
            this.textEndMinute.Name = "textEndMinute";
            this.textEndMinute.Size = new System.Drawing.Size(40, 19);
            this.textEndMinute.TabIndex = 16;
            this.textEndMinute.Text = "59";
            // 
            // textEndHour
            // 
            this.textEndHour.Location = new System.Drawing.Point(213, 87);
            this.textEndHour.Name = "textEndHour";
            this.textEndHour.Size = new System.Drawing.Size(40, 19);
            this.textEndHour.TabIndex = 15;
            this.textEndHour.Text = "23";
            // 
            // textEndDay
            // 
            this.textEndDay.Location = new System.Drawing.Point(153, 87);
            this.textEndDay.Name = "textEndDay";
            this.textEndDay.Size = new System.Drawing.Size(40, 19);
            this.textEndDay.TabIndex = 14;
            this.textEndDay.Text = "01";
            // 
            // textEndMonth
            // 
            this.textEndMonth.Location = new System.Drawing.Point(91, 87);
            this.textEndMonth.Name = "textEndMonth";
            this.textEndMonth.Size = new System.Drawing.Size(40, 19);
            this.textEndMonth.TabIndex = 13;
            this.textEndMonth.Text = "07";
            // 
            // textEndYear
            // 
            this.textEndYear.Location = new System.Drawing.Point(8, 87);
            this.textEndYear.Name = "textEndYear";
            this.textEndYear.Size = new System.Drawing.Size(60, 19);
            this.textEndYear.TabIndex = 12;
            this.textEndYear.Text = "2010";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "End time and Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(7, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(7, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // textStartSecond
            // 
            this.textStartSecond.Location = new System.Drawing.Point(331, 38);
            this.textStartSecond.Name = "textStartSecond";
            this.textStartSecond.Size = new System.Drawing.Size(40, 19);
            this.textStartSecond.TabIndex = 6;
            this.textStartSecond.Text = "00";
            // 
            // textStartMinute
            // 
            this.textStartMinute.Location = new System.Drawing.Point(272, 38);
            this.textStartMinute.Name = "textStartMinute";
            this.textStartMinute.Size = new System.Drawing.Size(40, 19);
            this.textStartMinute.TabIndex = 5;
            this.textStartMinute.Text = "00";
            // 
            // textStartHour
            // 
            this.textStartHour.Location = new System.Drawing.Point(213, 38);
            this.textStartHour.Name = "textStartHour";
            this.textStartHour.Size = new System.Drawing.Size(40, 19);
            this.textStartHour.TabIndex = 4;
            this.textStartHour.Text = "00";
            // 
            // textStartDay
            // 
            this.textStartDay.Location = new System.Drawing.Point(153, 38);
            this.textStartDay.Name = "textStartDay";
            this.textStartDay.Size = new System.Drawing.Size(40, 19);
            this.textStartDay.TabIndex = 3;
            this.textStartDay.Text = "01";
            // 
            // textStartMonth
            // 
            this.textStartMonth.Location = new System.Drawing.Point(91, 38);
            this.textStartMonth.Name = "textStartMonth";
            this.textStartMonth.Size = new System.Drawing.Size(40, 19);
            this.textStartMonth.TabIndex = 2;
            this.textStartMonth.Text = "07";
            // 
            // textStartYear
            // 
            this.textStartYear.Location = new System.Drawing.Point(8, 38);
            this.textStartYear.Name = "textStartYear";
            this.textStartYear.Size = new System.Drawing.Size(60, 19);
            this.textStartYear.TabIndex = 1;
            this.textStartYear.Text = "2010";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start time and Date";
            // 
            // bVMDSearch_Click
            // 
            this.bVMDSearch_Click.Location = new System.Drawing.Point(356, 222);
            this.bVMDSearch_Click.Name = "bVMDSearch_Click";
            this.bVMDSearch_Click.Size = new System.Drawing.Size(150, 30);
            this.bVMDSearch_Click.TabIndex = 24;
            this.bVMDSearch_Click.Text = "VMDSearchEx";
            this.bVMDSearch_Click.UseVisualStyleBackColor = true;
            this.bVMDSearch_Click.Click += new System.EventHandler(this.bVMDSearch_Click_Click);
            // 
            // listSearchResult
            // 
            this.listSearchResult.FormattingEnabled = true;
            this.listSearchResult.ItemHeight = 12;
            this.listSearchResult.Location = new System.Drawing.Point(12, 270);
            this.listSearchResult.Name = "listSearchResult";
            this.listSearchResult.Size = new System.Drawing.Size(754, 196);
            this.listSearchResult.TabIndex = 2;
            this.listSearchResult.DoubleClick += new System.EventHandler(this.listSearchResult_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "SearchCancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "Specify the area for VMD search by [Mouse Drag].";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 486);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bVMDSearch_Click);
            this.Controls.Add(this.listSearchResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axipropsapiCtrl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_VMDSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textStartSecond;
        private System.Windows.Forms.TextBox textStartMinute;
        private System.Windows.Forms.TextBox textStartHour;
        private System.Windows.Forms.TextBox textStartDay;
        private System.Windows.Forms.TextBox textStartMonth;
        private System.Windows.Forms.TextBox textStartYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textEndSecond;
        private System.Windows.Forms.TextBox textEndMinute;
        private System.Windows.Forms.TextBox textEndHour;
        private System.Windows.Forms.TextBox textEndDay;
        private System.Windows.Forms.TextBox textEndMonth;
        private System.Windows.Forms.TextBox textEndYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bVMDSearch_Click;
        private System.Windows.Forms.ListBox listSearchResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}

