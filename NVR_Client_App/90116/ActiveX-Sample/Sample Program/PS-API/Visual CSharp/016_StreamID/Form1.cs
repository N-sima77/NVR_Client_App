using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_StreamID
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
            //Set properties for axipropsapiCtrl1
            //----------------------------------------
            //Set properties to connect the device
            axipropsapiCtrl1.IPAddr = "192.168.0.250";
            axipropsapiCtrl1.DeviceType = 1;
            axipropsapiCtrl1.HttpPort = 80;
            axipropsapiCtrl1.UserName = "ADMIN";
            axipropsapiCtrl1.Password = "admin123";

            //Set properties for display area
            axipropsapiCtrl1.StreamFormat = 3;
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
            //Set properties for axipropsapiCtrl2
            //----------------------------------------
            //Set properties to connect the device
            axipropsapiCtrl2.IPAddr = "192.168.0.250";
            axipropsapiCtrl2.DeviceType = 1;
            axipropsapiCtrl2.HttpPort = 80;
            axipropsapiCtrl2.UserName = "ADMIN";
            axipropsapiCtrl2.Password = "admin123";

            //Set properties for display area
            axipropsapiCtrl2.StreamFormat = 3;
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

            //----------------------------------------
            //Set properties for axipropsapiCtrl3
            //----------------------------------------
            //Set properties to connect the device
            axipropsapiCtrl3.IPAddr = "192.168.0.250";
            axipropsapiCtrl3.DeviceType = 1;
            axipropsapiCtrl3.HttpPort = 80;
            axipropsapiCtrl3.UserName = "ADMIN";
            axipropsapiCtrl3.Password = "admin123";

            //Set properties for display area
            axipropsapiCtrl3.StreamFormat = 3;
            axipropsapiCtrl3.JPEGResolution = 640;
            axipropsapiCtrl3.MPEG4Resolution = 640;
            axipropsapiCtrl3.H264Resolution = 640;

            //Set properties for event
            axipropsapiCtrl3.OnErrorEnable = 1;
            axipropsapiCtrl3.OnDevStatusEnable = 0;
            axipropsapiCtrl3.OnRecStatusEnable = 0;
            axipropsapiCtrl3.OnPlayStatusEnable = 1;
            axipropsapiCtrl3.OnImageRefreshEnable = 0;
            axipropsapiCtrl3.OnRecordStatusEnable = 0;
            axipropsapiCtrl3.OnOpStatusEnable = 0;
            axipropsapiCtrl3.OnAlmStatusEnable = 0;

            axipropsapiCtrl3.OnRecStatusCBEnable = 0;
            axipropsapiCtrl3.OnSearchCBEnable = 0;
            axipropsapiCtrl3.OnSearchExCBEnable = 0;
            axipropsapiCtrl3.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl3.OnOpStatusCBEnable = 0;
            axipropsapiCtrl3.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl3.OnFtpStatusCBEnable = 0;

            //----------------------------------------
            //Set properties for axipropsapiCtrl4
            //----------------------------------------
            //Set properties to connect the device
            axipropsapiCtrl4.IPAddr = "192.168.0.250";
            axipropsapiCtrl4.DeviceType = 1;
            axipropsapiCtrl4.HttpPort = 80;
            axipropsapiCtrl4.UserName = "ADMIN";
            axipropsapiCtrl4.Password = "admin123";

            //Set properties for display area
            axipropsapiCtrl4.StreamFormat = 3;
            axipropsapiCtrl4.JPEGResolution = 640;
            axipropsapiCtrl4.MPEG4Resolution = 640;
            axipropsapiCtrl4.H264Resolution = 640;

            //Set properties for event
            axipropsapiCtrl4.OnErrorEnable = 1;
            axipropsapiCtrl4.OnDevStatusEnable = 0;
            axipropsapiCtrl4.OnRecStatusEnable = 0;
            axipropsapiCtrl4.OnPlayStatusEnable = 1;
            axipropsapiCtrl4.OnImageRefreshEnable = 0;
            axipropsapiCtrl4.OnRecordStatusEnable = 0;
            axipropsapiCtrl4.OnOpStatusEnable = 0;
            axipropsapiCtrl4.OnAlmStatusEnable = 0;

            axipropsapiCtrl4.OnRecStatusCBEnable = 0;
            axipropsapiCtrl4.OnSearchCBEnable = 0;
            axipropsapiCtrl4.OnSearchExCBEnable = 0;
            axipropsapiCtrl4.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl4.OnOpStatusCBEnable = 0;
            axipropsapiCtrl4.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl4.OnFtpStatusCBEnable = 0;

        }

        //---------------------------------------------------------------------
        // Function Name        : FormClosed
        // Overview             : Destroy log window
        //---------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //----------------------------------------
            //Set properties for axipropsapiCtrl1
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
            //Set properties for axipropsapiCtrl2
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

            //----------------------------------------
            //Set properties for axipropsapiCtrl3
            //----------------------------------------
            //Set properties for event
            axipropsapiCtrl3.OnErrorEnable = 0;
            axipropsapiCtrl3.OnDevStatusEnable = 0;
            axipropsapiCtrl3.OnRecStatusEnable = 0;
            axipropsapiCtrl3.OnPlayStatusEnable = 0;
            axipropsapiCtrl3.OnImageRefreshEnable = 0;
            axipropsapiCtrl3.OnRecordStatusEnable = 0;
            axipropsapiCtrl3.OnOpStatusEnable = 0;
            axipropsapiCtrl3.OnAlmStatusEnable = 0;

            axipropsapiCtrl3.OnRecStatusCBEnable = 0;
            axipropsapiCtrl3.OnSearchCBEnable = 0;
            axipropsapiCtrl3.OnSearchExCBEnable = 0;
            axipropsapiCtrl3.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl3.OnOpStatusCBEnable = 0;
            axipropsapiCtrl3.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl3.OnFtpStatusCBEnable = 0;

            //----------------------------------------
            //Set properties for axipropsapiCtrl4
            //----------------------------------------
            //Set properties for event
            axipropsapiCtrl4.OnErrorEnable = 0;
            axipropsapiCtrl4.OnDevStatusEnable = 0;
            axipropsapiCtrl4.OnRecStatusEnable = 0;
            axipropsapiCtrl4.OnPlayStatusEnable = 0;
            axipropsapiCtrl4.OnImageRefreshEnable = 0;
            axipropsapiCtrl4.OnRecordStatusEnable = 0;
            axipropsapiCtrl4.OnOpStatusEnable = 0;
            axipropsapiCtrl4.OnAlmStatusEnable = 0;

            axipropsapiCtrl4.OnRecStatusCBEnable = 0;
            axipropsapiCtrl4.OnSearchCBEnable = 0;
            axipropsapiCtrl4.OnSearchExCBEnable = 0;
            axipropsapiCtrl4.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl4.OnOpStatusCBEnable = 0;
            axipropsapiCtrl4.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl4.OnFtpStatusCBEnable = 0;

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
        // Function Name        : Live
        // Overview             : Start live video play
        //---------------------------------------------------------------------
        private void buttonLiveStart_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel1;
            int iChannel2;
            int iChannel3;
            int iChannel4;
            int iBlockingMode;

            //Connect to the device for axipropsapiCtrl1
            iRet = axipropsapiCtrl1.Open();
            Logging("[Function #1] Open:" + iRet.ToString());

            if(iRet > -1){
                //Connect to the device for axipropsapiCtrl2
                iRet = axipropsapiCtrl2.Connect(axipropsapiCtrl1.UID);
                Logging("[Function #2] Connect:" + iRet.ToString());

                //Connect to the device for axipropsapiCtrl3
                iRet = axipropsapiCtrl3.Connect(axipropsapiCtrl1.UID);
                Logging("[Function #3] Connect:" + iRet.ToString());

                //Connect to the device for axipropsapiCtrl4
                iRet = axipropsapiCtrl4.Connect(axipropsapiCtrl1.UID);
                Logging("[Function #4] Connect:" + iRet.ToString());

                // Get UID information
                iRet = axipropsapiCtrl1.GetUIDInfo();
                Logging("[Function #1] GetUIDInfo:" + iRet.ToString());

                textBox1.Text = axipropsapiCtrl1.UIDInfoUse.ToString();

                // Get StreamID information
                iRet = axipropsapiCtrl1.GetSIDInfo();
                Logging("[Function #1] GetSIDInfo:" + iRet.ToString());

                if (axipropsapiCtrl1.SIDInfoMode != 1)
                {
                    MessageBox.Show("The device doesn't support Stream ID.", "SimpleSample_StreamID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    axipropsapiCtrl1.SIDMode = 1;
                    Logging("[Function #1] SIDMode ON");

                    axipropsapiCtrl2.SIDMode = 1;
                    Logging("[Function #2] SIDMode ON");

                    axipropsapiCtrl3.SIDMode = 1;
                    Logging("[Function #3] SIDMode ON");
                    
                    axipropsapiCtrl4.SIDMode = 1;
                    Logging("[Function #4] SIDMode ON");
                }

                //Start Live
                iChannel1 = 1;
                iChannel2 = 2;
                iChannel3 = 3;
                iChannel4 = 4;

                iBlockingMode = 0;
                
                iRet = axipropsapiCtrl1.PlayLive(iChannel1, iBlockingMode);
                Logging("[Function #1] Live(Start):" + iRet.ToString());

                iRet = axipropsapiCtrl2.PlayLive(iChannel2, iBlockingMode);
                Logging("[Function #2] Live(Start):" + iRet.ToString());

                iRet = axipropsapiCtrl3.PlayLive(iChannel3, iBlockingMode);
                Logging("[Function #3] Live(Start):" + iRet.ToString());

                iRet = axipropsapiCtrl4.PlayLive(iChannel4, iBlockingMode);
                Logging("[Function #4] Live(Start):" + iRet.ToString());

                if (iRet == 0)
                {
                    m_PlayStatus = 1;
                }
                else
                {
                    axipropsapiCtrl4.Disconnect();
                    Logging("[Function #4] Disconnect");

                    axipropsapiCtrl3.Disconnect();
                    Logging("[Function #3] Disconnect");

                    axipropsapiCtrl2.Disconnect();
                    Logging("[Function #2] Disconnect");
                    
                    axipropsapiCtrl1.Close();
                    Logging("[Function #1] Close");

                    // Get UID information
                    iRet = axipropsapiCtrl1.GetUIDInfo();
                    Logging("[Function #1] GetUIDInfo:" + iRet.ToString());

                    textBox1.Text = axipropsapiCtrl1.UIDInfoUse.ToString();
                }

                // Get StreamID information
                iRet = axipropsapiCtrl1.GetSIDInfo();
                Logging("[Function #1] GetSIDInfo:" + iRet.ToString());

                textBox2.Text = axipropsapiCtrl1.SIDInfoUse.ToString();
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : Live and Playback
        // Overview             : Start live video play
        //---------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel1;
            int iChannel2;
            int iChannel3;
            int iChannel4;
            int iBlockingMode;

            //Connect to the device for axipropsapiCtrl1
            iRet = axipropsapiCtrl1.Open();
            Logging("[Function #1] Open:" + iRet.ToString());

            if (iRet > -1)
            {
                //Connect to the device for axipropsapiCtrl2
                iRet = axipropsapiCtrl2.Connect(axipropsapiCtrl1.UID);
                Logging("[Function #2] Connect:" + iRet.ToString());

                //Connect to the device for axipropsapiCtrl3
                iRet = axipropsapiCtrl3.Connect(axipropsapiCtrl1.UID);
                Logging("[Function #3] Connect:" + iRet.ToString());

                //Connect to the device for axipropsapiCtrl4
                iRet = axipropsapiCtrl4.Connect(axipropsapiCtrl1.UID);
                Logging("[Function #4] Connect:" + iRet.ToString());

                // Get UID information
                iRet = axipropsapiCtrl1.GetUIDInfo();
                Logging("[Function #1] GetUIDInfo:" + iRet.ToString());

                textBox1.Text = axipropsapiCtrl1.UIDInfoUse.ToString();

                // Get StreamID information
                iRet = axipropsapiCtrl1.GetSIDInfo();
                Logging("[Function #1] GetSIDInfo:" + iRet.ToString());

                if (axipropsapiCtrl1.SIDInfoMode != 1)
                {
                    MessageBox.Show("The device doesn't support Stream ID.", "SimpleSample_StreamID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    axipropsapiCtrl1.SIDMode = axipropsapiCtrl1.SIDInfoMode;
                    Logging("[Function #1] SIDMode ON");

                    axipropsapiCtrl2.SIDMode = axipropsapiCtrl1.SIDInfoMode;
                    Logging("[Function #2] SIDMode ON");

                    axipropsapiCtrl3.SIDMode = axipropsapiCtrl1.SIDInfoMode;
                    Logging("[Function #3] SIDMode ON");

                    axipropsapiCtrl4.SIDMode = axipropsapiCtrl1.SIDInfoMode;
                    Logging("[Function #4] SIDMode ON");
                }

                //Start Live
                iChannel1 = 1;
                iChannel2 = 2;
                iChannel3 = 3;
                iChannel4 = 4;

                iBlockingMode = 0;

                iRet = axipropsapiCtrl1.PlayLive(iChannel1, iBlockingMode);
                Logging("[Function #1] Live(Start):" + iRet.ToString());

                iRet = axipropsapiCtrl2.PlayLive(iChannel2, iBlockingMode);
                Logging("[Function #2] Live(Start):" + iRet.ToString());

                iRet = axipropsapiCtrl3.Play(iChannel3, "2012/05/01 12:00:00", iBlockingMode);
                Logging("[Function #3] Play(Start):" + iRet.ToString());

                iRet = axipropsapiCtrl4.Play(iChannel4, "2012/05/01 12:00:00", iBlockingMode);
                Logging("[Function #4] Play(Start):" + iRet.ToString());

                if (iRet == 0)
                {
                    m_PlayStatus = 2;
                }
                else
                {
                    axipropsapiCtrl4.Disconnect();
                    Logging("[Function #4] Disconnect");

                    axipropsapiCtrl3.Disconnect();
                    Logging("[Function #3] Disconnect");

                    axipropsapiCtrl2.Disconnect();
                    Logging("[Function #2] Disconnect");

                    axipropsapiCtrl1.Close();
                    Logging("[Function #1] Close");

                    // Get UID information
                    iRet = axipropsapiCtrl1.GetUIDInfo();
                    Logging("[Function #1] GetUIDInfo:" + iRet.ToString());

                    textBox1.Text = axipropsapiCtrl1.UIDInfoUse.ToString();
                }

                // Get StreamID information
                iRet = axipropsapiCtrl1.GetSIDInfo();
                Logging("[Function #1] GetSIDInfo:" + iRet.ToString());

                textBox2.Text = axipropsapiCtrl1.SIDInfoUse.ToString();
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
            int iSpeed;
            int iBlockMode;

            if (m_PlayStatus == 0)
            {
                Logging("[Message] No live.");
            }
            // Live Only mode
            else if (m_PlayStatus == 1)
            {
                //Stop Live
                iSpeed = 0;
                iBlockMode = 0;

                iRet = axipropsapiCtrl1.PlayControl(1, iSpeed, iBlockMode);
                Logging("[Function #1] PlayControl(Stop):" + iRet.ToString());

                iRet = axipropsapiCtrl2.PlayControl(1, iSpeed, iBlockMode);
                Logging("[Function #2] PlayControl(Stop):" + iRet.ToString());

                iRet = axipropsapiCtrl3.PlayControl(1, iSpeed, iBlockMode);
                Logging("[Function #3] PlayControl(Stop):" + iRet.ToString());

                iRet = axipropsapiCtrl4.PlayControl(1, iSpeed, iBlockMode);
                Logging("[Function #4] PlayControl(Stop):" + iRet.ToString());

                //Change status
                m_PlayStatus = 0;
            }
            // Live and Playback mode
            else if (m_PlayStatus == 2)
            {
                //Stop Live
                iSpeed = 0;
                iBlockMode = 0;

                iRet = axipropsapiCtrl1.PlayControl(1, iSpeed, iBlockMode);
                Logging("[Function #1] PlayControl(Stop):" + iRet.ToString());

                iRet = axipropsapiCtrl2.PlayControl(1, iSpeed, iBlockMode);
                Logging("[Function #2] PlayControl(Stop):" + iRet.ToString());

                iRet = axipropsapiCtrl3.PlayControl(0, iSpeed, iBlockMode);
                Logging("[Function #3] PlayControl(Stop):" + iRet.ToString());

                iRet = axipropsapiCtrl4.PlayControl(0, iSpeed, iBlockMode);
                Logging("[Function #4] PlayControl(Stop):" + iRet.ToString());

                //Change status
                m_PlayStatus = 0;
            }

            if (axipropsapiCtrl1.UID >= 0)
            {
                //Close connection to the device
                axipropsapiCtrl4.Disconnect();
                Logging("[Function #4] Disconnect");

                axipropsapiCtrl3.Disconnect();
                Logging("[Function #3] Disconnect");

                axipropsapiCtrl2.Disconnect();
                Logging("[Function #2] Disconnect");

                axipropsapiCtrl1.Close();
                Logging("[Function #1] Close");

                //ClearImage
                axipropsapiCtrl1.ClearImage();
                Logging("[Function #1] ClearImage");

                axipropsapiCtrl2.ClearImage();
                Logging("[Function #2] ClearImage");

                axipropsapiCtrl3.ClearImage();
                Logging("[Function #3] ClearImage");

                axipropsapiCtrl4.ClearImage();
                Logging("[Function #4] ClearImage");

                // Get UID information
                iRet = axipropsapiCtrl1.GetUIDInfo();
                Logging("[Function #1] GetUIDInfo:" + iRet.ToString());

                textBox1.Text = axipropsapiCtrl1.UIDInfoUse.ToString();
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : OnError
        // Overview             : OnError listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnError(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError #1] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnDevStatus
        // Overview             : OnDevStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnDevStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEvent e)
        {
            //Output Logs
            Logging("[OnDevStatus #1] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatu
        // Overview             : OnRecStatu listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecStatus #1] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatus
        // Overview             : OnPlayStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnPlayStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatus #1] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecordStatus
        // Overview             : OnRecordStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecordStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecordStatus #1] type[" + e.recType + "] timeDate[" + e.timeDate + "] nextRecTime[" + e.nextRecTime + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnImageRefresh
        // Overview             : OnImageRefresh listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnImageRefresh(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnImageRefresh #1] No argument.");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatus
        // Overview             : OnOpStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnOpStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEvent e)
        {
            //Output Logs
            Logging("[OnOpStatus #1] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatus
        // Overview             : OnAlmStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnAlmStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatus #1] channel[" + e.channel + "] type[" + e.alarmtype + "] timeDate[" + e.timeDate + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatusCB
        // Overview             : OnRecStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnRecStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnRecStatusCB #1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchCB
        // Overview             : OnSearchCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnSearchCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchCB #1] Show Search result.");
            ShowResult();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchExCB
        // Overview             : OnSearchExCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnSearchExCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchExCB #1] Show SearchEx result.");
            ShowResultEx();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatusCB
        // Overview             : OnPlayStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnPlayStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatusCB #1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatusCB
        // Overview             : OnOpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnOpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnOpStatusCB #1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatusCB
        // Overview             : OnAlmStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnAlmStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatusCB #1] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnFtpStatusCB
        // Overview             : OnFtpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl1_OnFtpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnFtpStatusCB #1] status[" + e.status + "]");
        }
        //---------------------------------------------------------------------
        // Function Name        : OnError
        // Overview             : OnError listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnError(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError #2] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnDevStatus
        // Overview             : OnDevStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnDevStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEvent e)
        {
            //Output Logs
            Logging("[OnDevStatus #2] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatu
        // Overview             : OnRecStatu listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnRecStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecStatus #2] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatus
        // Overview             : OnPlayStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnPlayStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatus #2] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecordStatus
        // Overview             : OnRecordStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnRecordStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecordStatus #2] type[" + e.recType + "] timeDate[" + e.timeDate + "] nextRecTime[" + e.nextRecTime + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnImageRefresh
        // Overview             : OnImageRefresh listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnImageRefresh(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnImageRefresh #2] No argument.");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatus
        // Overview             : OnOpStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnOpStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEvent e)
        {
            //Output Logs
            Logging("[OnOpStatus #2] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatus
        // Overview             : OnAlmStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnAlmStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatus #2] channel[" + e.channel + "] type[" + e.alarmtype + "] timeDate[" + e.timeDate + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatusCB
        // Overview             : OnRecStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnRecStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnRecStatusCB #2] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchCB
        // Overview             : OnSearchCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnSearchCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchCB #2] Show Search result.");
            ShowResult();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchExCB
        // Overview             : OnSearchExCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnSearchExCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchExCB #2] Show SearchEx result.");
            ShowResultEx();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatusCB
        // Overview             : OnPlayStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnPlayStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatusCB #2] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatusCB
        // Overview             : OnOpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnOpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnOpStatusCB #2] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatusCB
        // Overview             : OnAlmStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnAlmStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatusCB #2] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnFtpStatusCB
        // Overview             : OnFtpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl2_OnFtpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnFtpStatusCB #2] status[" + e.status + "]");
        }
        //---------------------------------------------------------------------
        // Function Name        : OnError
        // Overview             : OnError listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnError(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError #3] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnDevStatus
        // Overview             : OnDevStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnDevStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEvent e)
        {
            //Output Logs
            Logging("[OnDevStatus #3] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatu
        // Overview             : OnRecStatu listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnRecStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecStatus #3] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatus
        // Overview             : OnPlayStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnPlayStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatus #3] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecordStatus
        // Overview             : OnRecordStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnRecordStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecordStatus #3] type[" + e.recType + "] timeDate[" + e.timeDate + "] nextRecTime[" + e.nextRecTime + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnImageRefresh
        // Overview             : OnImageRefresh listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnImageRefresh(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnImageRefresh #3] No argument.");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatus
        // Overview             : OnOpStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnOpStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEvent e)
        {
            //Output Logs
            Logging("[OnOpStatus #3] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatus
        // Overview             : OnAlmStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnAlmStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatus #3] channel[" + e.channel + "] type[" + e.alarmtype + "] timeDate[" + e.timeDate + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatusCB
        // Overview             : OnRecStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnRecStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnRecStatusCB #3] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchCB
        // Overview             : OnSearchCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnSearchCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchCB #3] Show Search result.");
            ShowResult();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchExCB
        // Overview             : OnSearchExCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnSearchExCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchExCB #3] Show SearchEx result.");
            ShowResultEx();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatusCB
        // Overview             : OnPlayStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnPlayStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatusCB #3] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatusCB
        // Overview             : OnOpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnOpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnOpStatusCB #3] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatusCB
        // Overview             : OnAlmStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnAlmStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatusCB #3] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnFtpStatusCB
        // Overview             : OnFtpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl3_OnFtpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnFtpStatusCB #3] status[" + e.status + "]");
        }
        //---------------------------------------------------------------------
        // Function Name        : OnError
        // Overview             : OnError listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnError(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError #4] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnDevStatus
        // Overview             : OnDevStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnDevStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEvent e)
        {
            //Output Logs
            Logging("[OnDevStatus #4] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatu
        // Overview             : OnRecStatu listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnRecStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecStatus #4] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatus
        // Overview             : OnPlayStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnPlayStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatus #4] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecordStatus
        // Overview             : OnRecordStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnRecordStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEvent e)
        {
            //Output Logs
            Logging("[OnRecordStatus #4] type[" + e.recType + "] timeDate[" + e.timeDate + "] nextRecTime[" + e.nextRecTime + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnImageRefresh
        // Overview             : OnImageRefresh listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnImageRefresh(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnImageRefresh #4] No argument.");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatus
        // Overview             : OnOpStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnOpStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEvent e)
        {
            //Output Logs
            Logging("[OnOpStatus #4] channel[" + e.channel + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatus
        // Overview             : OnAlmStatus listener event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnAlmStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatus #4] channel[" + e.channel + "] type[" + e.alarmtype + "] timeDate[" + e.timeDate + "] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnRecStatusCB
        // Overview             : OnRecStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnRecStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnRecStatusCB #4] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchCB
        // Overview             : OnSearchCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnSearchCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchCB #4] Show Search result.");
            ShowResult();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnSearchExCB
        // Overview             : OnSearchExCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnSearchExCB(object sender, EventArgs e)
        {
            //Output Logs
            Logging("[OnSearchExCB #4] Show SearchEx result.");
            ShowResultEx();
        }

        //---------------------------------------------------------------------
        // Function Name        : OnPlayStatusCB
        // Overview             : OnPlayStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnPlayStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatusCB #4] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnOpStatusCB
        // Overview             : OnOpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnOpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnOpStatusCB #4] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnAlmStatusCB
        // Overview             : OnAlmStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnAlmStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnAlmStatusCB #4] status[" + e.status + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : OnFtpStatusCB
        // Overview             : OnFtpStatusCB callback event
        //---------------------------------------------------------------------
        private void axipropsapiCtrl4_OnFtpStatusCB(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEvent e)
        {
            //Output Logs
            Logging("[OnFtpStatusCB #4] status[" + e.status + "]");
        }
    }
}