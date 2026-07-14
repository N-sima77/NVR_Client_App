using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_PanasonicAlarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        // Define variables
        //---------------------------------------------------------------------
        private Form2 frmForm2;

        //---------------------------------------------------------------------
        // Function Name        : Load
        // Overview             : Load PSAPI and Initialize
        //---------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            frmForm2 = new Form2();
            frmForm2.StartPosition = FormStartPosition.Manual;

            frmForm2.Left = 600;
            frmForm2.Top = 50;
            frmForm2.Show();

            this.axpsalarmrcvctrl1.Visible = false;

            //Initialize the control position
            this.Left = 5;
            this.Top = 50;

            //Turn on OnError event receiving
            this.axpsalarmrcvctrl1.OnErrorEnable = 1;

            //Set properties for image format
            this.axpsalarmrcvctrl1.AlarmRcvPort = 1818;
            this.textBox1.Text = this.axpsalarmrcvctrl1.AlarmRcvPort.ToString();

            Logging("AlarmRcvPort : " + this.axpsalarmrcvctrl1.AlarmRcvPort.ToString());
        }

        //---------------------------------------------------------------------
        // Function Name        : FormClosed
        // Overview             : Destroy log window
        //---------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmForm2.Close();
        }
    
        //---------------------------------------------------------------------
        // Function Name        : Logging
        // Overview             : Output Logs
        //---------------------------------------------------------------------
        private void Logging(String str)
        {
            frmForm2.textLog.Text = str + "\r\n" + frmForm2.textLog.Text;
        }

        //---------------------------------------------------------------------
        // Function Name        : Start
        // Overview             : Start Receive Panasonic Alarm
        //---------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            //Turn on OnAlarm event receiving
            this.axpsalarmrcvctrl1.AlarmRcvPort = int.Parse(textBox1.Text);
            this.axpsalarmrcvctrl1.OnAlarmRcvEnable = 1;

            Logging("AlarmRcvPort : " + this.axpsalarmrcvctrl1.AlarmRcvPort.ToString());
            Logging("onAlarmRcvEnable : 1 (On)");
        }

        //---------------------------------------------------------------------
        // Function Name        : Stop
        // Overview             : Stop Receive Panasonic Alarm
        //---------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            //Turn off OnAlarm event receiving
            this.axpsalarmrcvctrl1.OnAlarmRcvEnable = 0;

            Logging("onAlarmRcvEnable : 0 (Off)");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlarmRcv
        // Overview             : Alarm Receive event
        //---------------------------------------------------------------------
        private void OnAlarmRcv(object sender, AxPSALARMRCVLib._IpsalarmrcvctrlEvents_OnAlarmRcvEvent e)
        {
            String strLog;
            strLog = "[OnAlarmRcv]timeDate : " + e.timeDate.ToString() + "\r\n"
                        + "ipaddr : " + e.ipaddr.ToString() + "\r\n"
                        + "channel : " + e.channel.ToString() + "\r\n"
                        + "alarmType : " + e.alarmType.ToString() + "\r\n"
                        + "messageID : " + e.messageID.ToString() + "\r\n"
                        + "messageText : " + e.messageText.ToString() + "\r\n";


            Logging(strLog);

            String strAlarm;
            strAlarm = "timeDate[" + e.timeDate.ToString() + "]  " + "\r\n"
                        + "ipaddr[" + e.ipaddr.ToString() + "]  " + "\r\n"
                        + "channel[" + e.channel.ToString() + "]  " + "\r\n"
                        + "alarmType[" + e.alarmType.ToString() + "]  " + "\r\n"
                        + "messageID[" + e.messageID.ToString() + "]  " + "\r\n"
                        + "messageText[" + e.messageText.ToString() + "]  " + "\r\n"
                        + "information" + "\r\n"
                        + "----------------" + "\r\n"
                        + e.information.ToString() + "\r\n";

            if(this.listBox1.Items.Count >= 1000){
                this.listBox1.Items.RemoveAt (0);
            }

            //Add received Panasonic Alarm to list
            this.listBox1.Items.Add(strAlarm);
        }

        //---------------------------------------------------------------------
        // Function Name        : OnError
        // Overview             : Error Receive event
        //---------------------------------------------------------------------
        private void OnError(object sender, AxPSALARMRCVLib._IpsalarmrcvctrlEvents_OnErrorEvent e)
        {
            //Output Error log
            Logging("[OnError]  errorcode:" + e.errorCode.ToString() + "   errorMsg:" + e.description);
        }

        //---------------------------------------------------------------------
        // Function Name        : OnDblClick
        // Overview             : Click the alarm list
        //---------------------------------------------------------------------
        private void OnDblClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.listBox1.SelectedItem.ToString());
        }
    }
}