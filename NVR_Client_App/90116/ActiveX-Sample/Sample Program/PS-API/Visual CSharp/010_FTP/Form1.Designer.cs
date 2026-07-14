namespace SimpleSample_Search
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textDataType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDirection = new System.Windows.Forms.CheckBox();
            this.checkTermivmd = new System.Windows.Forms.CheckBox();
            this.checkScreen = new System.Windows.Forms.CheckBox();
            this.checkRemoval = new System.Windows.Forms.CheckBox();
            this.checkLoitering = new System.Windows.Forms.CheckBox();
            this.checkMotion = new System.Windows.Forms.CheckBox();
            this.checkVMD = new System.Windows.Forms.CheckBox();
            this.checkVideoLossAlarm = new System.Windows.Forms.CheckBox();
            this.checkSDBackup = new System.Windows.Forms.CheckBox();
            this.checkCameraSiteAlarm = new System.Windows.Forms.CheckBox();
            this.checkCommandAlarm = new System.Windows.Forms.CheckBox();
            this.checkTerminal = new System.Windows.Forms.CheckBox();
            this.checkSchedule = new System.Windows.Forms.CheckBox();
            this.checkManual = new System.Windows.Forms.CheckBox();
            this.checkEmergency = new System.Windows.Forms.CheckBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.axipropsapiCtrl1 = new AxIPROPSAPILib.AxipropsapiCtrl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textFileName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textDataType);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.groupBox2);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 416);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition";
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(16, 386);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(440, 19);
            this.textFileName.TabIndex = 20;
            this.textFileName.Text = "C:\\DownloadData";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "File name";
            // 
            // textDataType
            // 
            this.textDataType.Location = new System.Drawing.Point(16, 142);
            this.textDataType.Name = "textDataType";
            this.textDataType.Size = new System.Drawing.Size(91, 19);
            this.textDataType.TabIndex = 18;
            this.textDataType.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "Data type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDirection);
            this.groupBox2.Controls.Add(this.checkTermivmd);
            this.groupBox2.Controls.Add(this.checkScreen);
            this.groupBox2.Controls.Add(this.checkRemoval);
            this.groupBox2.Controls.Add(this.checkLoitering);
            this.groupBox2.Controls.Add(this.checkMotion);
            this.groupBox2.Controls.Add(this.checkVMD);
            this.groupBox2.Controls.Add(this.checkVideoLossAlarm);
            this.groupBox2.Controls.Add(this.checkSDBackup);
            this.groupBox2.Controls.Add(this.checkCameraSiteAlarm);
            this.groupBox2.Controls.Add(this.checkCommandAlarm);
            this.groupBox2.Controls.Add(this.checkTerminal);
            this.groupBox2.Controls.Add(this.checkSchedule);
            this.groupBox2.Controls.Add(this.checkManual);
            this.groupBox2.Controls.Add(this.checkEmergency);
            this.groupBox2.Location = new System.Drawing.Point(16, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 184);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event type";
            // 
            // checkDirection
            // 
            this.checkDirection.AutoSize = true;
            this.checkDirection.Location = new System.Drawing.Point(277, 153);
            this.checkDirection.Name = "checkDirection";
            this.checkDirection.Size = new System.Drawing.Size(114, 16);
            this.checkDirection.TabIndex = 14;
            this.checkDirection.Text = "direction (i-VMD)";
            this.checkDirection.UseVisualStyleBackColor = true;
            // 
            // checkTermivmd
            // 
            this.checkTermivmd.AutoSize = true;
            this.checkTermivmd.Location = new System.Drawing.Point(141, 153);
            this.checkTermivmd.Name = "checkTermivmd";
            this.checkTermivmd.Size = new System.Drawing.Size(111, 16);
            this.checkTermivmd.TabIndex = 13;
            this.checkTermivmd.Text = "terminal (i-VMD)";
            this.checkTermivmd.UseVisualStyleBackColor = true;
            // 
            // checkScreen
            // 
            this.checkScreen.AutoSize = true;
            this.checkScreen.Location = new System.Drawing.Point(20, 147);
            this.checkScreen.Name = "checkScreen";
            this.checkScreen.Size = new System.Drawing.Size(98, 28);
            this.checkScreen.TabIndex = 12;
            this.checkScreen.Text = "screen change\r\n(i-VMD)";
            this.checkScreen.UseVisualStyleBackColor = true;
            // 
            // checkRemoval
            // 
            this.checkRemoval.AutoSize = true;
            this.checkRemoval.Location = new System.Drawing.Point(277, 121);
            this.checkRemoval.Name = "checkRemoval";
            this.checkRemoval.Size = new System.Drawing.Size(110, 16);
            this.checkRemoval.TabIndex = 11;
            this.checkRemoval.Text = "removal (i-VMD)";
            this.checkRemoval.UseVisualStyleBackColor = true;
            // 
            // checkLoitering
            // 
            this.checkLoitering.AutoSize = true;
            this.checkLoitering.Location = new System.Drawing.Point(141, 121);
            this.checkLoitering.Name = "checkLoitering";
            this.checkLoitering.Size = new System.Drawing.Size(111, 16);
            this.checkLoitering.TabIndex = 10;
            this.checkLoitering.Text = "loitering (i-VMD)";
            this.checkLoitering.UseVisualStyleBackColor = true;
            // 
            // checkMotion
            // 
            this.checkMotion.AutoSize = true;
            this.checkMotion.Location = new System.Drawing.Point(20, 121);
            this.checkMotion.Name = "checkMotion";
            this.checkMotion.Size = new System.Drawing.Size(104, 16);
            this.checkMotion.TabIndex = 9;
            this.checkMotion.Text = "motion (i-VMD)";
            this.checkMotion.UseVisualStyleBackColor = true;
            // 
            // checkVMD
            // 
            this.checkVMD.AutoSize = true;
            this.checkVMD.Location = new System.Drawing.Point(278, 90);
            this.checkVMD.Name = "checkVMD";
            this.checkVMD.Size = new System.Drawing.Size(81, 16);
            this.checkVMD.TabIndex = 8;
            this.checkVMD.Text = "VMD alarm";
            this.checkVMD.UseVisualStyleBackColor = true;
            // 
            // checkVideoLossAlarm
            // 
            this.checkVideoLossAlarm.AutoSize = true;
            this.checkVideoLossAlarm.Location = new System.Drawing.Point(141, 90);
            this.checkVideoLossAlarm.Name = "checkVideoLossAlarm";
            this.checkVideoLossAlarm.Size = new System.Drawing.Size(108, 16);
            this.checkVideoLossAlarm.TabIndex = 7;
            this.checkVideoLossAlarm.Text = "video loss alarm";
            this.checkVideoLossAlarm.UseVisualStyleBackColor = true;
            // 
            // checkSDBackup
            // 
            this.checkSDBackup.AutoSize = true;
            this.checkSDBackup.Location = new System.Drawing.Point(20, 90);
            this.checkSDBackup.Name = "checkSDBackup";
            this.checkSDBackup.Size = new System.Drawing.Size(79, 16);
            this.checkSDBackup.TabIndex = 6;
            this.checkSDBackup.Text = "SD backup";
            this.checkSDBackup.UseVisualStyleBackColor = true;
            // 
            // checkCameraSiteAlarm
            // 
            this.checkCameraSiteAlarm.AutoSize = true;
            this.checkCameraSiteAlarm.Location = new System.Drawing.Point(278, 60);
            this.checkCameraSiteAlarm.Name = "checkCameraSiteAlarm";
            this.checkCameraSiteAlarm.Size = new System.Drawing.Size(116, 16);
            this.checkCameraSiteAlarm.TabIndex = 5;
            this.checkCameraSiteAlarm.Text = "camera site alarm";
            this.checkCameraSiteAlarm.UseVisualStyleBackColor = true;
            // 
            // checkCommandAlarm
            // 
            this.checkCommandAlarm.AutoSize = true;
            this.checkCommandAlarm.Location = new System.Drawing.Point(141, 60);
            this.checkCommandAlarm.Name = "checkCommandAlarm";
            this.checkCommandAlarm.Size = new System.Drawing.Size(104, 16);
            this.checkCommandAlarm.TabIndex = 4;
            this.checkCommandAlarm.Text = "command alarm";
            this.checkCommandAlarm.UseVisualStyleBackColor = true;
            // 
            // checkTerminal
            // 
            this.checkTerminal.AutoSize = true;
            this.checkTerminal.Location = new System.Drawing.Point(20, 60);
            this.checkTerminal.Name = "checkTerminal";
            this.checkTerminal.Size = new System.Drawing.Size(65, 16);
            this.checkTerminal.TabIndex = 3;
            this.checkTerminal.Text = "terminal";
            this.checkTerminal.UseVisualStyleBackColor = true;
            // 
            // checkSchedule
            // 
            this.checkSchedule.AutoSize = true;
            this.checkSchedule.Location = new System.Drawing.Point(278, 30);
            this.checkSchedule.Name = "checkSchedule";
            this.checkSchedule.Size = new System.Drawing.Size(69, 16);
            this.checkSchedule.TabIndex = 2;
            this.checkSchedule.Text = "schedule";
            this.checkSchedule.UseVisualStyleBackColor = true;
            // 
            // checkManual
            // 
            this.checkManual.AutoSize = true;
            this.checkManual.Location = new System.Drawing.Point(141, 30);
            this.checkManual.Name = "checkManual";
            this.checkManual.Size = new System.Drawing.Size(60, 16);
            this.checkManual.TabIndex = 1;
            this.checkManual.Text = "manual";
            this.checkManual.UseVisualStyleBackColor = true;
            // 
            // checkEmergency
            // 
            this.checkEmergency.AutoSize = true;
            this.checkEmergency.Location = new System.Drawing.Point(20, 30);
            this.checkEmergency.Name = "checkEmergency";
            this.checkEmergency.Size = new System.Drawing.Size(79, 16);
            this.checkEmergency.TabIndex = 0;
            this.checkEmergency.Text = "emergency";
            this.checkEmergency.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(7, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(7, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "/";
            // 
            // textEndSecond
            // 
            this.textEndSecond.Location = new System.Drawing.Point(406, 89);
            this.textEndSecond.Name = "textEndSecond";
            this.textEndSecond.Size = new System.Drawing.Size(50, 19);
            this.textEndSecond.TabIndex = 17;
            this.textEndSecond.Text = "00";
            // 
            // textEndMinute
            // 
            this.textEndMinute.Location = new System.Drawing.Point(339, 89);
            this.textEndMinute.Name = "textEndMinute";
            this.textEndMinute.Size = new System.Drawing.Size(50, 19);
            this.textEndMinute.TabIndex = 16;
            this.textEndMinute.Text = "01";
            // 
            // textEndHour
            // 
            this.textEndHour.Location = new System.Drawing.Point(270, 89);
            this.textEndHour.Name = "textEndHour";
            this.textEndHour.Size = new System.Drawing.Size(50, 19);
            this.textEndHour.TabIndex = 15;
            this.textEndHour.Text = "10";
            // 
            // textEndDay
            // 
            this.textEndDay.Location = new System.Drawing.Point(201, 89);
            this.textEndDay.Name = "textEndDay";
            this.textEndDay.Size = new System.Drawing.Size(50, 19);
            this.textEndDay.TabIndex = 14;
            this.textEndDay.Text = "01";
            // 
            // textEndMonth
            // 
            this.textEndMonth.Location = new System.Drawing.Point(128, 89);
            this.textEndMonth.Name = "textEndMonth";
            this.textEndMonth.Size = new System.Drawing.Size(50, 19);
            this.textEndMonth.TabIndex = 13;
            this.textEndMonth.Text = "07";
            // 
            // textEndYear
            // 
            this.textEndYear.Location = new System.Drawing.Point(16, 89);
            this.textEndYear.Name = "textEndYear";
            this.textEndYear.Size = new System.Drawing.Size(91, 19);
            this.textEndYear.TabIndex = 12;
            this.textEndYear.Text = "2010";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "End time and Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(7, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(7, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // textStartSecond
            // 
            this.textStartSecond.Location = new System.Drawing.Point(406, 41);
            this.textStartSecond.Name = "textStartSecond";
            this.textStartSecond.Size = new System.Drawing.Size(50, 19);
            this.textStartSecond.TabIndex = 6;
            this.textStartSecond.Text = "00";
            // 
            // textStartMinute
            // 
            this.textStartMinute.Location = new System.Drawing.Point(339, 41);
            this.textStartMinute.Name = "textStartMinute";
            this.textStartMinute.Size = new System.Drawing.Size(50, 19);
            this.textStartMinute.TabIndex = 5;
            this.textStartMinute.Text = "59";
            // 
            // textStartHour
            // 
            this.textStartHour.Location = new System.Drawing.Point(270, 41);
            this.textStartHour.Name = "textStartHour";
            this.textStartHour.Size = new System.Drawing.Size(50, 19);
            this.textStartHour.TabIndex = 4;
            this.textStartHour.Text = "09";
            // 
            // textStartDay
            // 
            this.textStartDay.Location = new System.Drawing.Point(201, 41);
            this.textStartDay.Name = "textStartDay";
            this.textStartDay.Size = new System.Drawing.Size(50, 19);
            this.textStartDay.TabIndex = 3;
            this.textStartDay.Text = "01";
            // 
            // textStartMonth
            // 
            this.textStartMonth.Location = new System.Drawing.Point(128, 41);
            this.textStartMonth.Name = "textStartMonth";
            this.textStartMonth.Size = new System.Drawing.Size(50, 19);
            this.textStartMonth.TabIndex = 2;
            this.textStartMonth.Text = "07";
            // 
            // textStartYear
            // 
            this.textStartYear.Location = new System.Drawing.Point(16, 41);
            this.textStartYear.Name = "textStartYear";
            this.textStartYear.Size = new System.Drawing.Size(91, 19);
            this.textStartYear.TabIndex = 1;
            this.textStartYear.Text = "2010";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start time and Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "FTP download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axipropsapiCtrl1
            // 
            this.axipropsapiCtrl1.Enabled = true;
            this.axipropsapiCtrl1.Location = new System.Drawing.Point(12, 444);
            this.axipropsapiCtrl1.Name = "axipropsapiCtrl1";
            this.axipropsapiCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axipropsapiCtrl1.OcxState")));
            this.axipropsapiCtrl1.Size = new System.Drawing.Size(160, 32);
            this.axipropsapiCtrl1.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 486);
            this.Controls.Add(this.axipropsapiCtrl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleSample_FTP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axipropsapiCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkCommandAlarm;
        private System.Windows.Forms.CheckBox checkTerminal;
        private System.Windows.Forms.CheckBox checkSchedule;
        private System.Windows.Forms.CheckBox checkManual;
        private System.Windows.Forms.CheckBox checkEmergency;
        private System.Windows.Forms.CheckBox checkVideoLossAlarm;
        private System.Windows.Forms.CheckBox checkSDBackup;
        private System.Windows.Forms.CheckBox checkCameraSiteAlarm;
        private System.Windows.Forms.CheckBox checkDirection;
        private System.Windows.Forms.CheckBox checkTermivmd;
        private System.Windows.Forms.CheckBox checkScreen;
        private System.Windows.Forms.CheckBox checkRemoval;
        private System.Windows.Forms.CheckBox checkLoitering;
        private System.Windows.Forms.CheckBox checkMotion;
        private System.Windows.Forms.CheckBox checkVMD;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textDataType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private AxIPROPSAPILib.AxipropsapiCtrl axipropsapiCtrl1;
    }
}

