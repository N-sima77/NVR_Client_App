using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_Overlay
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
            // Added Ver5.0.1.0
            textBox1.Text = "C:\\temp\\test.bmp";
            textBox1.AllowDrop = true;
        }

        //---------------------------------------------------------------------
        // Function Name        : FormClosed
        // Overview             : Destroy log window
        //---------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

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
        // Function Name        : chk_drawTitle_CheckedChanged      Modefied Ver5.0.1.0
        // Overview             : Draw Title
        //---------------------------------------------------------------------
        private void chk_drawTitle_CheckedChanged(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iId;
            int iCommand;
            string strText;
            int ixPosition;
            int iyPosition;
            int iAlign;
            string strFont;
            int iFontSize;
            int iForeColor;
            int iBorderColor;
            int iStyle;
            int iTransmittance;

            strText = "PS-API ActiveX";
            ixPosition = 100;
            iyPosition = 100;
            iAlign = 0;
            strFont = "MS UI Gothic";
            iFontSize = 24;
            iForeColor = 0;
            iBorderColor = 16777215;
            iStyle = 2;
            iTransmittance = 0x7F;

            if (chk_drawTitle.Checked == true)
            {
                //Display Title
                iId = 1;
                iCommand = 1;
                iRet = axipropsapiCtrl1.TitleOperationEx(iId, iCommand, strText, ixPosition, iyPosition, iAlign, strFont, iFontSize, iForeColor, iBorderColor, iStyle, iTransmittance);
                Logging("[Function] TitleOperation (ON):" + iRet.ToString());
            }
            else
            {
                //Not display Title
                iId = 1;
                iCommand = 0;
                iRet = axipropsapiCtrl1.TitleOperationEx(iId, iCommand, strText, ixPosition, iyPosition, iAlign, strFont, iFontSize, iForeColor, iBorderColor, iStyle, iTransmittance);
                Logging("[Function] TitleOperation (OFF):" + iRet.ToString());
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : chk_drawBox_CheckedChanged        Modefied Ver5.0.1.0
        // Overview             : Draw Box
        //---------------------------------------------------------------------
        private void chk_drawBox_CheckedChanged(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iId;
            int iCommand;
            int iColor;
            int iSize;
            int ixTopLeft;
            int iyTopLeft;
            int ixBottomRight;
            int iyBottomRight;
            int iTransmittance;

            iColor = 255;
            iSize = 3;
            ixTopLeft = 200;
            iyTopLeft = 200;
            ixBottomRight = 300;
            iyBottomRight = 300;
            iTransmittance = 0x7F;

            if (chk_drawBox.Checked == true)
            {
                //Display Box
                iId = 1;
                iCommand = 2;
                iRet = axipropsapiCtrl1.BoxOperationEx(iId, iCommand, iColor, iSize, ixTopLeft, iyTopLeft, ixBottomRight, iyBottomRight, iTransmittance);
                Logging("[Function] BoxOperation (ON):" + iRet.ToString());
            }
            else
            {
                //Not display Box
                iId = 1;
                iCommand = 0;
                iRet = axipropsapiCtrl1.BoxOperationEx(iId, iCommand, iColor, iSize, ixTopLeft, iyTopLeft, ixBottomRight, iyBottomRight, iTransmittance);
                Logging("[Function] BoxOperation (OFF):" + iRet.ToString());
            }
        }

        //---------------------------------------------------------------------
        //* Function Name        : chk_BMPDraw_CheckedChanged        Added Ver5.0.1.0
        //* Overview             : Transparent bitmap image processing
        //---------------------------------------------------------------------
        private void chk_BMPDraw_Click(object sender, EventArgs e)
        {
            int Ret, Id, Command, XPos, YPos, MaskColor, Transmittance;
            String FileName;

            Id = 1;         // ID for management
            XPos = 320;     // X position of displayed transparent
            YPos = 240;     // Y position of displayed transparent
            if (chk_BMPDraw.Checked) {
                // Transparent bitmap
                FileName = textBox1.Text;
                Command = 1;            // Bitmap display
                MaskColor = 0xFF00FF;   // Bitmap's masked color
                Transmittance = 0x7f;   // Transmittance
                Ret = axipropsapiCtrl1.BitmapOperationEx(Id, Command, FileName, XPos, YPos, MaskColor, Transmittance);
                Logging("[Function] BitmapOperationEx (ON," + FileName + "):" + Ret.ToString());
            }
            else {
                // Not transparent bitmap
                Command = 0;            // Bitmap non display
                MaskColor = 0x00;       // Bitmap's masked color
                Transmittance = 0x7f;   // Transmittance
                Ret = axipropsapiCtrl1.BitmapOperationEx(Id, Command, String.Empty, 0, 0, MaskColor, Transmittance);
                Logging("[Function] BitmapOperationEx (OFF):" + Ret.ToString());
            }
        }

        //---------------------------------------------------------------------
        //* Function Name        : DragDraop                          Added Ver5.0.1.0
        //* Overview             : Drop a single file to view
        //---------------------------------------------------------------------
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            String[] Files;
            Files = (String[])e.Data.GetData(DataFormats.FileDrop);
            textBox1.Text = Files[0];
        }

        //---------------------------------------------------------------------
        //* Function Name        : DragEnter                         Added Ver5.0.1.0
        //* Overview             : Drag the files and only valid
        //---------------------------------------------------------------------
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
            else {
                e.Effect = DragDropEffects.None;
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