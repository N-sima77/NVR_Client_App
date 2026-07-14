using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_CamOp
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
            axipropsapiCtrl1.IPAddr = "192.168.0.10";
            axipropsapiCtrl1.DeviceType = 2;
            axipropsapiCtrl1.HttpPort = 80;
            axipropsapiCtrl1.UserName = "admin";
            axipropsapiCtrl1.Password = "12345";

            //Set properties for display area
            axipropsapiCtrl1.StreamFormat = 1;
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
            axipropsapiCtrl1.OnOpStatusEnable = 1;
            axipropsapiCtrl1.OnAlmStatusEnable = 0;

            axipropsapiCtrl1.OnRecStatusCBEnable = 0;
            axipropsapiCtrl1.OnSearchCBEnable = 0;
            axipropsapiCtrl1.OnSearchExCBEnable = 0;
            axipropsapiCtrl1.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl1.OnOpStatusCBEnable = 0;
            axipropsapiCtrl1.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl1.OnFtpStatusCBEnable = 0;

            //----------------------------------------
            //Connect to the device
            //----------------------------------------
            int iRet;
            int iChannel;
            int iBlockMode;

            iRet = axipropsapiCtrl1.Open();
            Logging("[Function] Open:" + iRet.ToString());

            if (iRet > -1)
            {
                iChannel = 1;
                iBlockMode = 1;
                iRet = axipropsapiCtrl1.PlayLive(iChannel, iBlockMode);
                Logging("[Function] PlayLive(Start):" + (iRet));

                if (iRet == 0)
                {
                    m_PlayStatus = 1;
                }
                else
                {
                    axipropsapiCtrl1.Close();
                    Logging("[Function] Close");
                }
            }
        }
        
        //---------------------------------------------------------------------
        // Function Name        : FormClosed
        // Overview             : Destroy log window
        //---------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            if(m_PlayStatus == 1)
            {
                iCommand = 1;
                iSpeed = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockMode);
                Logging("[Function] PlayControl(Stop):" + (iRet));

                axipropsapiCtrl1.Close();
                Logging("[Function] Close");

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
        // Function Name        : buttonGetCamPosition_Click
        // Overview             : Get position of camera
        //---------------------------------------------------------------------
        private void buttonGetCamPosition_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;

            if (m_PlayStatus == 1)
            {
                //GetCameraPosition
                iChannel = 1;
                iRet = axipropsapiCtrl1.GetCameraPosition(iChannel);
                Logging("[Function] GetCameraPosition:" + iRet.ToString());

                //Get camera position value
                iPan = axipropsapiCtrl1.CameraPosPan;
                iTilt = axipropsapiCtrl1.CameraPosTilt;
                iZoom = axipropsapiCtrl1.CameraPosZoom;
                iFocus = axipropsapiCtrl1.CameraPosFocus;
                Logging("[Function] Pan[" + iPan + "] Tilt[" + iTilt + "] Zoom[" + iZoom + "] Focus[" + iFocus + "]");
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonSetCamPosition1_Click
        // Overview             : The camera is moved to the specified position
        //---------------------------------------------------------------------
        private void buttonSetCamPosition1_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;

            if (m_PlayStatus == 1)
            {
                //SetCameraPosition
                iChannel = 1;
                iPan = 0;
                iTilt = 0;
                iZoom = 10;
                iFocus = 14;
                iRet = axipropsapiCtrl1.SetCameraPosition(iChannel, iPan, iTilt, iZoom, iFocus);
                Logging("[Function] SetCameraPosition:" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonSetCamPosition2_Click
        // Overview             : The camera is moved to the specified position
        //---------------------------------------------------------------------
        private void buttonSetCamPosition2_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;

            if (m_PlayStatus == 1)
            {
                //SetCameraPosition
                iChannel = 1;
                iPan = 1800;
                iTilt = 600;
                iZoom = 20;
                iFocus = 28;
                iRet = axipropsapiCtrl1.SetCameraPosition(iChannel, iPan, iTilt, iZoom, iFocus);
                Logging("[Function] SetCameraPosition:" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonNonOperation_Click
        // Overview             : Call CameraOperation (NonOperation)
        //---------------------------------------------------------------------
        private void buttonNonOperation_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iCommand;
            int iData;
            int iBlockMode;

            if (m_PlayStatus == 1)
            {
                //CameraOperation
                iChannel = 1;
                iCommand = 0;
                iData = 0;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.CameraOperation(iChannel, iCommand, iData, iBlockMode);
                Logging("[Function] CameraOperation:" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonAutoTrack_Click
        // Overview             : Call CameraOperation (AutoTrack)
        //---------------------------------------------------------------------
        private void buttonAutoTrack_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iCommand;
            int iData;
            int iBlockMode;

            if (m_PlayStatus == 1)
            {
                //CameraOperation
                iChannel = 1;
                iCommand = 1;
                iData = 0;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.CameraOperation(iChannel, iCommand, iData, iBlockMode);
                Logging("[Function] CameraOperation:" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonAutoPan_Click
        // Overview             : Call CameraOperation (AutoPan)
        //---------------------------------------------------------------------
        private void buttonAutoPan_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iCommand;
            int iData;
            int iBlockMode;

            if (m_PlayStatus == 1)
            {
                //CameraOperation
                iChannel = 1;
                iCommand = 2;
                iData = 0;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.CameraOperation(iChannel, iCommand, iData, iBlockMode);
                Logging("[Function] CameraOperation:" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonAutoFocus_Click
        // Overview             : Call CameraOperation (AutoFocus)
        //---------------------------------------------------------------------
        private void buttonAutoFocus_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iCommand;
            int iData;
            int iBlockMode;

            if (m_PlayStatus == 1)
            {
                //CameraOperation
                iChannel = 1;
                iCommand = 3;
                iData = 0;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.CameraOperation(iChannel, iCommand, iData, iBlockMode);
                Logging("[Function] CameraOperation:" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonSetPreset_Click
        // Overview             : Call CameraOperation (Set Preset)
        //---------------------------------------------------------------------
        private void buttonSetPreset_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iCommand;
            int iData;
            int iBlockMode;

            if (m_PlayStatus == 1)
            {
                //CameraOperation
                iChannel = 1;
                iCommand = 4;
                iData = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.CameraOperation(iChannel, iCommand, iData, iBlockMode);
                Logging("[Function] CameraOperation:" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonCallPreset_Click
        // Overview             : Call CameraOperation (Call Preset)
        //---------------------------------------------------------------------
        private void buttonCallPreset_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iCommand;
            int iData;
            int iBlockMode;

            if (m_PlayStatus == 1)
            {
                //CameraOperation
                iChannel = 1;
                iCommand = 5;
                iData = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.CameraOperation(iChannel, iCommand, iData, iBlockMode);
                Logging("[Function] CameraOperation:" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonDeletePreset_Click
        // Overview             : Call CameraOperation (Delete Preset)
        //---------------------------------------------------------------------
        private void buttonDeletePreset_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iCommand;
            int iData;
            int iBlockMode;

            if (m_PlayStatus == 1)
            {
                //CameraOperation
                iChannel = 1;
                iCommand = 6;
                iData = 1;
                iBlockMode = 0;
                iRet = axipropsapiCtrl1.CameraOperation(iChannel, iCommand, iData, iBlockMode);
                //Output Logs
                Logging("[Function] CameraOperation:" + iRet.ToString());
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