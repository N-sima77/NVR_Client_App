using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_LiveMulti
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

        int m_PlayStatus;     //LiveStatus 0:Stop 1:Live

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
            //Set properties for Control 1
            //----------------------------------------
            //Set properties to connect the device
            axipropsapiCtrl1.IPAddr = "192.168.0.250";
            axipropsapiCtrl1.DeviceType = 1;
            axipropsapiCtrl1.HttpPort = 80;
            axipropsapiCtrl1.UserName = "ADMIN";
            axipropsapiCtrl1.Password = "12345";

            //Set properties for display area
            axipropsapiCtrl1.StreamFormat = 0;
            axipropsapiCtrl1.JPEGResolution = 640;
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

            //----------------------------------------
            //Set properties for Control 2
            //----------------------------------------
            //Set properties to connect the device
            axipropsapiCtrl2.IPAddr = "192.168.0.250";
            axipropsapiCtrl2.DeviceType = 1;
            axipropsapiCtrl2.HttpPort = 80;
            axipropsapiCtrl2.UserName = "ADMIN";
            axipropsapiCtrl2.Password = "12345";

            //Set properties for display area
            axipropsapiCtrl2.StreamFormat = 0;
            axipropsapiCtrl2.JPEGResolution = 640;
            axipropsapiCtrl2.MPEG4Resolution = 640;
            axipropsapiCtrl2.H264Resolution = 640;

            //Set properties for event
            axipropsapiCtrl2.OnErrorEnable = 1;
            axipropsapiCtrl2.OnDevStatusEnable = 0;
            axipropsapiCtrl2.OnRecStatusEnable = 0;
            axipropsapiCtrl2.OnPlayStatusEnable = 1;
            axipropsapiCtrl2.OnImageRefreshEnable = 0;
            axipropsapiCtrl2.OnRecordStatusEnable = 0;
            axipropsapiCtrl2.OnOpStatusEnable = 0;
            axipropsapiCtrl2.OnAlmStatusEnable = 0;

            axipropsapiCtrl2.OnRecStatusCBEnable = 0;
            axipropsapiCtrl2.OnSearchCBEnable = 0;
            axipropsapiCtrl2.OnSearchExCBEnable = 0;
            axipropsapiCtrl2.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl2.OnOpStatusCBEnable = 0;
            axipropsapiCtrl2.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl2.OnFtpStatusCBEnable = 0;
        }

        //---------------------------------------------------------------------
        // Function Name        : FormClosed
        // Overview             : Destroy log window
        //---------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //----------------------------------------
            //Set properties for Control 1
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

            //----------------------------------------
            //Set properties for Control 1
            //----------------------------------------
            //Set properties for event
            axipropsapiCtrl2.OnErrorEnable = 0;
            axipropsapiCtrl2.OnDevStatusEnable = 0;
            axipropsapiCtrl2.OnRecStatusEnable = 0;
            axipropsapiCtrl2.OnPlayStatusEnable = 0;
            axipropsapiCtrl2.OnImageRefreshEnable = 0;
            axipropsapiCtrl2.OnRecordStatusEnable = 0;
            axipropsapiCtrl2.OnOpStatusEnable = 0;
            axipropsapiCtrl2.OnAlmStatusEnable = 0;

            axipropsapiCtrl2.OnRecStatusCBEnable = 0;
            axipropsapiCtrl2.OnSearchCBEnable = 0;
            axipropsapiCtrl2.OnSearchExCBEnable = 0;
            axipropsapiCtrl2.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl2.OnOpStatusCBEnable = 0;
            axipropsapiCtrl2.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl2.OnFtpStatusCBEnable = 0;

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
        // Function Name        : StartLive
        // Overview             : Start live video play
        //---------------------------------------------------------------------
        private void buttonLiveStart_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iBlockingMode;

            //----------------------------------------
            //Control 1
            //----------------------------------------
            iRet = axipropsapiCtrl1.Open();
            Logging("[Function 1] Open:" + iRet.ToString());

            if (iRet > -1)
            {
                //Start Live
                iChannel = 1;
                iBlockingMode = 0;
                iRet = axipropsapiCtrl1.PlayLive(iChannel, iBlockingMode);
                Logging("[Function 1] PlayLive1(Start):" + iRet.ToString());

                if( iRet != 0)
                {
                    //Close connection to the device
                    axipropsapiCtrl1.Close();
                    Logging("[Function] Close");
                }
                else
                {
                    //----------------------------------------
                    //Control 2
                    //----------------------------------------
                    iRet = axipropsapiCtrl2.Connect(axipropsapiCtrl1.UID);
                    Logging("[Function 2] Connect:" + iRet.ToString());
                    
                    if (iRet > -1)
                    {
                        //Start Live
                        iChannel = 2;
                        iBlockingMode = 0;
                        iRet = axipropsapiCtrl2.PlayLive(iChannel, iBlockingMode);
                        Logging("[Function 2] PlayLive1(Start):" + iRet.ToString());

                        if( iRet != 0)
                        {
                            //Close connection to the device
                            axipropsapiCtrl1.Disconnect();
                            Logging("[Function 2] Disconnect");
                        }
                    }
                    
                    //Status:Live
                    m_PlayStatus = 1;
                }
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : StopLive
        // Overview             : Stop live video play
        //---------------------------------------------------------------------
        private void buttonLiveStop_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            if(m_PlayStatus == 1)
            {
                //Stop Live
                iCommand = 1;
                iSpeed = 0;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function 1] PlayLive1(Stop):" + iRet.ToString());

                //Stop Live
                iCommand = 1;
                iSpeed = 0;
                iBlockMode = 0;
                iRet = axipropsapiCtrl2.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function 2] PlayLive1(Stop):" + iRet.ToString());

                //Close connection to the device
                axipropsapiCtrl2.Disconnect();
                Logging("[Function 2] Disconnect");
                axipropsapiCtrl1.Close();
                Logging("[Function 1] Close");

                //ClearImage
                axipropsapiCtrl1.ClearImage();
                Logging("[Function 1] ClearImage");
                axipropsapiCtrl2.ClearImage();
                Logging("[Function 2] ClearImage");

                //Change status
                m_PlayStatus = 0;
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : OnError
        // Overview             : OnError listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnError(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError 1] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnDevStatus
        // Overview             : OnDevStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnDevStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEvent e)
        {
            //Output Logs
            Logging("[OnDevStatus 1] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatu
        // Overview             : OnRecStatu listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecStatu 1] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatus
        // Overview             : OnPlayStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnPlayStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatus 1] channel[" + e.channel + "] status[" + e.status + "]");
       }

        //---------------------------------------------------------------------
        // Function Name        : OnRecordStatus
        // Overview             : OnRecordStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecordStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecordStatus 1] type[" + e.recType + "] timeDate[" + e.timeDate + "] nextRecTime[" + e.nextRecTime + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnImageRefresh
        // Overview             : OnImageRefresh listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnImageRefresh(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnImageRefresh 1] No argument.");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatus
        // Overview             : OnOpStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnOpStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEvent e)
        {
            //Output Logs
            Logging("[OnOpStatus 1] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatus
        // Overview             : OnAlmStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnAlmStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatus 1] channel[" + e.channel + "] type[" + e.alarmtype + "] timeDate[" + e.timeDate + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatusCB
        // Overview             : OnRecStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnRecStatusCB 1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchCB
        // Overview             : OnSearchCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnSearchCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchCB 1] Show Search result.");
            ShowResult();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchExCB
        // Overview             : OnSearchExCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnSearchExCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchExCB 1] Show SearchEx result.");
            ShowResultEx();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatusCB
        // Overview             : OnPlayStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnPlayStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatusCB 1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatusCB
        // Overview             : OnOpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnOpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnOpStatusCB 1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatusCB
        // Overview             : OnAlmStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnAlmStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatusCB 1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnFtpStatusCB
        // Overview             : OnFtpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnFtpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnFtpStatusCB 1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnError
        // Overview             : OnError listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnError(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError 2] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnDevStatus
        // Overview             : OnDevStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnDevStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEvent e)
        {
            //Output Logs
            Logging("[OnDevStatus 2] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatu
        // Overview             : OnRecStatu listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnRecStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecStatu 2] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatus
        // Overview             : OnPlayStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnPlayStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatus 2] channel[" + e.channel + "] status[" + e.status + "]");
       }

        //---------------------------------------------------------------------
        // Function Name        : OnRecordStatus
        // Overview             : OnRecordStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnRecordStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecordStatus 2] type[" + e.recType + "] timeDate[" + e.timeDate + "] nextRecTime[" + e.nextRecTime + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnImageRefresh
        // Overview             : OnImageRefresh listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnImageRefresh(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnImageRefresh 2] No argument.");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatus
        // Overview             : OnOpStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnOpStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEvent e)
        {
            //Output Logs
            Logging("[OnOpStatus 2] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatus
        // Overview             : OnAlmStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnAlmStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatus 2] channel[" + e.channel + "] type[" + e.alarmtype + "] timeDate[" + e.timeDate + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatusCB
        // Overview             : OnRecStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnRecStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnRecStatusCB 2] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchCB
        // Overview             : OnSearchCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnSearchCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchCB 2] Show Search result.");
            ShowResult();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchExCB
        // Overview             : OnSearchExCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnSearchExCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchExCB 2] Show SearchEx result.");
            ShowResultEx();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatusCB
        // Overview             : OnPlayStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnPlayStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatusCB 2] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatusCB
        // Overview             : OnOpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnOpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnOpStatusCB 2] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatusCB
        // Overview             : OnAlmStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnAlmStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatusCB 2] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnFtpStatusCB
        // Overview             : OnFtpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnFtpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnFtpStatusCB 2] status[" + e.status + "]");
        }
    }
}