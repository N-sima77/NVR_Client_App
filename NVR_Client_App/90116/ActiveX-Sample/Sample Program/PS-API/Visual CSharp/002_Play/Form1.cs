using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_Play
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

        int m_PlayStatus;    //PlayStatus 0:Stop 1:Live

        //---------------------------------------------------------------------
        // Function Name        : Load
        // Overview             : Load PSAPI and Initialize
        //---------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //Show the log window
            frmForm2 = new Form2();
            frmForm2.Show();

            //----------------------------------------
            //Set properties
            //----------------------------------------
            //Set properties to connect the device
            axipropsapiCtrl1.IPAddr = "192.168.11.38";
            axipropsapiCtrl1.DeviceType = 6;
            axipropsapiCtrl1.HttpPort = 80;
            axipropsapiCtrl1.UserName = "admin";
            axipropsapiCtrl1.Password = "Admin123";

            //Set properties for display area
            axipropsapiCtrl1.StreamFormat = 3;
            axipropsapiCtrl1.JPEGResolution = 1280;
            axipropsapiCtrl1.MPEG4Resolution = 640;
            axipropsapiCtrl1.H264Resolution = 640;

            //Set properties for event
            axipropsapiCtrl1.OnErrorEnable = 1;
            axipropsapiCtrl1.OnDevStatusEnable = 0;
            axipropsapiCtrl1.OnRecStatusEnable = 0;
            axipropsapiCtrl1.OnPlayStatusEnable = 1;
            axipropsapiCtrl1.OnImageRefreshEnable = 0;
            axipropsapiCtrl1.OnRecordStatusEnable = 0;
            axipropsapiCtrl1.OnOpStatusEnable = 0;
            axipropsapiCtrl1.OnAlmStatusEnable = 0;

            axipropsapiCtrl1.OnRecStatusCBEnable = 0;
            axipropsapiCtrl1.OnSearchCBEnable = 0;
            axipropsapiCtrl1.OnSearchExCBEnable = 0;
            axipropsapiCtrl1.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl1.OnOpStatusCBEnable = 0;
            axipropsapiCtrl1.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl1.OnFtpStatusCBEnable = 0;
        }

        //---------------------------------------------------------------------
        // Function Name        : FormClosed
        // Overview             : Destroy log window
        //---------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //----------------------------------------
            // Disconnect
            //----------------------------------------
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;
            
            
            if(m_PlayStatus == 1)
            {
                iCommand = 0;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Stop):" + iRet.ToString());
                
                if(iRet == 0)
                {
                    //Status:Stop
                    m_PlayStatus = 0;
                }
                
                //Close connection to the device
                axipropsapiCtrl1.Close();
                Logging("[Function] Close");
                
                //ClearImage
                axipropsapiCtrl1.ClearImage();
                Logging("[Function] ClearImage");
            }

            //----------------------------------------
            //Set properties
            //----------------------------------------
            //Set properties for event
            axipropsapiCtrl1.OnErrorEnable = 0;
            axipropsapiCtrl1.OnDevStatusEnable = 0;
            axipropsapiCtrl1.OnRecStatusEnable = 0;
            axipropsapiCtrl1.OnPlayStatusEnable = 0;
            axipropsapiCtrl1.OnImageRefreshEnable = 0;
            axipropsapiCtrl1.OnRecordStatusEnable = 0;
            axipropsapiCtrl1.OnOpStatusEnable = 0;
            axipropsapiCtrl1.OnAlmStatusEnable = 0;

            axipropsapiCtrl1.OnRecStatusCBEnable = 0;
            axipropsapiCtrl1.OnSearchCBEnable = 0;
            axipropsapiCtrl1.OnSearchExCBEnable = 0;
            axipropsapiCtrl1.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl1.OnOpStatusCBEnable = 0;
            axipropsapiCtrl1.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl1.OnFtpStatusCBEnable = 0;

            frmForm2.Close();
        }

        //---------------------------------------------------------------------
        // Function Name        : Logging
        // Overview             : Output Logs
        //---------------------------------------------------------------------
        private void Logging(String str)
        {
            if (frmForm2.textLog.Text != "")
            {
                frmForm2.textLog.Text = frmForm2.textLog.Text + "\r\n";
            }
            frmForm2.textLog.Text = frmForm2.textLog.Text + str;
        }

        //---------------------------------------------------------------------
        // Function Name        : ShowResult
        // Overview             : Output list Search result
        //---------------------------------------------------------------------
        private void ShowResult()
        {
            //Set Search Result to list
        }

        //---------------------------------------------------------------------
        // Function Name        : ShowResultEx
        // Overview             : Output list SearchEx/VMDSearchEx result
        //---------------------------------------------------------------------
        private void ShowResultEx()
        {
            //Set SearchEx Result to list
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonStop_Click
        // Overview             : PlayControl Stop
        //---------------------------------------------------------------------
        private void buttonStop_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 0;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Stop):" + iRet.ToString());

                if(iRet == 0)
                {
                    //Status:Stop
                    m_PlayStatus = 0;
                }

                //Close connection to the device
                axipropsapiCtrl1.Close();
                Logging("[Function] Close");
                
                //ClearImage
                axipropsapiCtrl1.ClearImage();
                Logging("[Function] ClearImage");
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonStopbuttonPause_Click_Click
        // Overview             : PlayControl Pause
        //---------------------------------------------------------------------
        private void buttonPause_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 3;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Pause):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonPlayBack_Click
        // Overview             : PlayControl Playback
        //---------------------------------------------------------------------
        private void buttonPlayBack_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iCommand;
            int iSpeed;
            int iBlockMode;
            string chDate;

            //Check the play status
            if (m_PlayStatus == 0)
            {
                //Connect to the device
                iRet = axipropsapiCtrl1.Open();
                Logging("[Function] Open:" + iRet.ToString());

                if (iRet > -1)
                {
                    //Play
                    iChannel = 2;    // görüntü alınacak kanal numarası
                    chDate = "2026/07/17 08:40:00";
                    iBlockMode = 0;
                    iRet = axipropsapiCtrl1.Play(iChannel, chDate, iBlockMode);
                    Logging("[Function] Play:" + iRet.ToString());
                }

                if(iRet == 0)
                {
                    //Status:Stop
                    m_PlayStatus = 1;
                }
            }
            else if (m_PlayStatus == 1)
            {
                //Control playback
                iCommand = 4;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Playback):" + iRet.ToString());
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonReverse_Click
        // Overview             : PlayControl Backward
        //---------------------------------------------------------------------
        private void buttonReverse_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 5;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Backward):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonNextFrame_Click
        // Overview             : PlayControl Next Frame
        //---------------------------------------------------------------------
        private void buttonNextFrame_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 6;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Next Frame):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonPrevFrame_Click
        // Overview             : PlayControl Previous Frame
        //---------------------------------------------------------------------
        private void buttonPrevFrame_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 7;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Previous Frame):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonFF_Click
        // Overview             : PlayControl Fast Forward
        //---------------------------------------------------------------------
        private void buttonFF_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 8;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Fast Forward):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonRewind_Click
        // Overview             : PlayControl Rewind
        //---------------------------------------------------------------------
        private void buttonRewind_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 9;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Rewind):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonNextRec_Click
        // Overview             : PlayControl Next Record
        //---------------------------------------------------------------------
        private void buttonNextRec_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 10;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Next Record):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonPrevRec_Click
        // Overview             : PlayControl Previous Record
        //---------------------------------------------------------------------
        private void buttonPrevRec_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            //Check the play status
            if (m_PlayStatus == 1)
            {
                iCommand = 11;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Previous Record):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No playback.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : checkBox1_CheckedChanged          Added Ver5.0.1.0
        // Overview             : Set FastPlayMode property
        //---------------------------------------------------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int Mode;
            if (checkBox1.Checked) {
                Mode = 1;       //High rate mode
                axipropsapiCtrl1.FastPlayMode = Mode;
                Logging("[Property] FastPlayMode = High rate mode");
            }
            else {
                Mode = 0;       //Normal mode
                axipropsapiCtrl1.FastPlayMode = Mode;
                Logging("[Property] FastPlayMode = Normal mode");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : OnError
        // Overview             : OnError listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnError(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnDevStatus
        // Overview             : OnDevStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnDevStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEvent e)
        {
            //Output Logs
            Logging("[OnDevStatus] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatu
        // Overview             : OnRecStatu listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecStatu] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatus
        // Overview             : OnPlayStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnPlayStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatus] channel[" + e.channel + "] status[" + e.status + "]");
       }

        //---------------------------------------------------------------------
        // Function Name        : OnRecordStatus
        // Overview             : OnRecordStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecordStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecordStatus] type[" + e.recType + "] timeDate[" + e.timeDate + "] nextRecTime[" + e.nextRecTime + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnImageRefresh
        // Overview             : OnImageRefresh listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnImageRefresh(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnImageRefresh] No argument.");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatus
        // Overview             : OnOpStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnOpStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEvent e)
        {
            //Output Logs
            Logging("[OnOpStatus] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatus
        // Overview             : OnAlmStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnAlmStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatus] channel[" + e.channel + "] type[" + e.alarmtype + "] timeDate[" + e.timeDate + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatusCB
        // Overview             : OnRecStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnRecStatusCB] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchCB
        // Overview             : OnSearchCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnSearchCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchCB] Show Search result.");
            ShowResult();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchExCB
        // Overview             : OnSearchExCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnSearchExCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchExCB] Show SearchEx result.");
            ShowResultEx();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatusCB
        // Overview             : OnPlayStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnPlayStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatusCB] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatusCB
        // Overview             : OnOpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnOpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnOpStatusCB] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatusCB
        // Overview             : OnAlmStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnAlmStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatusCB] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnFtpStatusCB
        // Overview             : OnFtpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnFtpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnFtpStatusCB] status[" + e.status + "]");
        }

    }
}