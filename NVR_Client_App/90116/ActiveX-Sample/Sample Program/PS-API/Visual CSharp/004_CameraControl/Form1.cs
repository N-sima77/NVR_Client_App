using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_CamCtrl
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

        int m_PlayStatus = 0;    //LiveStatus 0:Stop 1:Live

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

            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;
            int iCommand;
            int iSpeed;
            int iBlockMode;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 0;
                iTilt = 0;
                iZoom = 0;
                iFocus = 0;
                iIris = 0;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CameraControl(Stop):" + (iRet));

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
        // Function Name        : buttonLeft_Click
        // Overview             : CameraControl Pan
        //---------------------------------------------------------------------
        private void buttonLeft_Click(object sender, EventArgs e)
        {
        
            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;
            
            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = -128;
                iTilt = 0;
                iZoom = 0;
                iFocus = 0;
                iIris = 0;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Left):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonRight_Click
        // Overview             : CameraControl Pan
        //---------------------------------------------------------------------
        private void buttonRight_Click(object sender, EventArgs e)
        {

            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 128;
                iTilt = 0;
                iZoom = 0;
                iFocus = 0;
                iIris = 0;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Right):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonUp_Click
        // Overview             : CameraControl Tilt
        //---------------------------------------------------------------------
        private void buttonUp_Click(object sender, EventArgs e)
        {
            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 0;
                iTilt = -128;
                iZoom = 0;
                iFocus = 0;
                iIris = 0;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Up):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonDown_Click
        // Overview             : CameraControl Tilt
        //---------------------------------------------------------------------
        private void buttonDown_Click(object sender, EventArgs e)
        {

            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 0;
                iTilt = 128;
                iZoom = 0;
                iFocus = 0;
                iIris = 0;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Down):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonTele_Click
        // Overview             : CameraControl Zoom
        //---------------------------------------------------------------------
        private void buttonTele_Click(object sender, EventArgs e)
        {

            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 0;
                iTilt = 0;
                iZoom = 1;
                iFocus = 0;
                iIris = 0;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Tele):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonWide_Click
        // Overview             : CameraControl Zoom
        //---------------------------------------------------------------------
        private void buttonWide_Click(object sender, EventArgs e)
        {

            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 0;
                iTilt = 0;
                iZoom = -1;
                iFocus = 0;
                iIris = 0;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Wide):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonOpen_Click
        // Overview             : CameraControl Iris
        //---------------------------------------------------------------------
        private void buttonOpen_Click(object sender, EventArgs e)
        {

            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 0;
                iTilt = 0;
                iZoom = 0;
                iFocus = 0;
                iIris = 1;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Open):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonClose_Click
        // Overview             : CameraControl Iris
        //---------------------------------------------------------------------
        private void buttonClose_Click(object sender, EventArgs e)
        {

            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 0;
                iTilt = 0;
                iZoom = 0;
                iFocus = 0;
                iIris = 2;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Close):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonStop_Click
        // Overview             : CameraControl Stop
        //---------------------------------------------------------------------
        private void buttonStop_Click(object sender, EventArgs e)
        {

            int iRet;
            int iChannel; 
            int iPan;
            int iTilt;
            int iZoom;
            int iFocus;
            int iIris;

            if(m_PlayStatus == 1)
            {
                iChannel = 1;
                iPan = 0;
                iTilt = 0;
                iZoom = 0;
                iFocus = 0;
                iIris = 0;
                iRet = axipropsapiCtrl1.CameraControl(iChannel, iPan, iTilt, iZoom, iFocus, iIris);
                Logging("[Function] CamControl(Stop):" + iRet.ToString());
            }
            else
            {
                Logging("[Message] No live.");
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : checkBox1_CheckedChanged
        // Overview             : Click Centering mode
        //---------------------------------------------------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                axipropsapiCtrl1.MouseDownEnable = 1;
            }
            else
            {
                axipropsapiCtrl1.MouseDownEnable = 0;
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

        //---------------------------------------------------------------------
        // Function Name        : MouseDown
        // Overview             : MouseDown event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_MouseDown(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_MouseDownEvent e)
        {
            //Define variables
            int iRet;
            int iChannel;
            int iControlSizeX;
            int iControlSizeY;

            if (m_PlayStatus == 1)
            {
                //CameraCentering
                iChannel = 1;
                iControlSizeX = 640;
                iControlSizeY = 480;
                iRet = axipropsapiCtrl1.CameraCentering(iChannel, e.x, e.y, iControlSizeX, iControlSizeY);
                Logging("[Function] Click centering:" + iRet.ToString() + " Position[X:" + e.x + " Y:" + e.y + "]");
            }
        }
    }
}