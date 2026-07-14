using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_Search
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

        int m_PlayStatus = 0;      //PlayStatus 0:Stop 1:Live

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
            axipropsapiCtrl1.OnSearchExCBEnable = 1;
            axipropsapiCtrl1.OnPlayStatusCBEnable = 0;
            axipropsapiCtrl1.OnOpStatusCBEnable = 0;
            axipropsapiCtrl1.OnAlmStatusCBEnable = 0;
            axipropsapiCtrl1.OnFtpStatusCBEnable = 0;
            //----------------------------------------
            //Connect to the device
            //----------------------------------------
            int iRet;
            
            iRet = axipropsapiCtrl1.Open();
            Logging("[Function] Open:" + iRet.ToString());
        }

        //---------------------------------------------------------------------
        // Function Name        : FormClosed
        // Overview             : Destroy log window
        //---------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //----------------------------------------
            //Disconnect to the device
            //----------------------------------------
            Call_PlayStop();
            
            axipropsapiCtrl1.Close();
            Logging("[Function] Close");

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
            //Define variables
            string sSearchResult;
            string[] sSearchResultList;

            listSearchResult.Items.Clear();

            sSearchResult = axipropsapiCtrl1.SearchResult;
            sSearchResultList = sSearchResult.Replace("\r\n", "\n").Split('\n');

            foreach (string sTemp in sSearchResultList)
            {
                if (sTemp != "")
                {
	                listSearchResult.Items.Add(sTemp);
	            }
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : ShowResultEx
        // Overview             : Output list SearchEx/VMDSearchEx result
        //---------------------------------------------------------------------
        private void ShowResultEx()
        {
            //Set SearchEx Result to list
            //Define variables
            string sSearchResultEx;
            string[] sSearchResultExList;

            listSearchResult.Items.Clear();

            sSearchResultEx = axipropsapiCtrl1.SearchResultEx;
            sSearchResultExList = sSearchResultEx.Replace("\r\n", "\n").Split('\n');

            foreach (string sTemp in sSearchResultExList)
            {
                if(sTemp != "")
                {
	                listSearchResult.Items.Add(sTemp);
	            }
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : Call_PlayStop
        // Overview             : 
        //---------------------------------------------------------------------
        private void Call_PlayStop()
        {
            //Define variables
            int iRet;
            int iCommand;
            int iSpeed;
            int iBlockingmode;

            if (m_PlayStatus == 1)
            {
                //Stop Playback
                iCommand = 0;
                iSpeed = 0;
                iBlockingmode = 0;
                iRet = axipropsapiCtrl1.PlayControl(iCommand, iSpeed, iBlockingmode);
                Logging("[Function] Play(Stop):" + iRet.ToString());

                axipropsapiCtrl1.ClearImage();
                Logging("[Function] ClearImage");

                //Change status
                m_PlayStatus = 0;
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonSearchSync_Click
        // Overview             : Start SearchEx of blocking mode
        //---------------------------------------------------------------------
        private void buttonSearchSync_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            string sStartTD;
            string sEndTD;
            int iType;
            int iBlockingmode;

            Call_PlayStop();

            iChannel = 1;

            sStartTD = textStartYear.Text + "/" + textStartMonth.Text + "/" + textStartDay.Text + " "
                     + textStartHour.Text + ":" + textStartMinute.Text + ":" + textStartSecond.Text;

            sEndTD = textEndYear.Text + "/" + textEndMonth.Text + "/" + textEndDay.Text + " "
                   + textEndHour.Text + ":" + textEndMinute.Text + ":" + textEndSecond.Text;

            iType = 0;
            if (checkEmergency.Checked == true)
            {
                iType += 0x01;
            }
            if (checkManual.Checked == true)
            {
                iType += 0x02;
            }
            if (checkSchedule.Checked == true)
            {
                iType += 0x04;
            }
            if (checkTerminal.Checked == true)
            {
                iType += 0x08;
            }
            if (checkCommandAlarm.Checked == true)
            {
                iType += 0x10;
            }
            if (checkCameraSiteAlarm.Checked == true)
            {
                iType += 0x20;
            }
            if (checkSDBackup.Checked == true)
            {
                iType += 0x40;
            }
            if (checkVideoLossAlarm.Checked == true)
            {
                iType += 0x80;
            }
            if (checkVMD.Checked == true)
            {
                iType += 0x0100;
            }
            if (checkMotion.Checked == true)
            {
                iType += 0x0200;
            }
            if (checkLoitering.Checked == true)
            {
                iType += 0x0400;
            }
            if (checkRemoval.Checked == true)
            {
                iType += 0x0800;
            }
            if (checkScreen.Checked == true)
            {
                iType += 0x1000;
            }
            if (checkTermivmd.Checked == true)
            {
                iType += 0x2000;
            }
            if (checkDirection.Checked == true)
            {
                iType += 0x4000;
            }

           iBlockingmode = 0;

            iRet = axipropsapiCtrl1.SearchEx(iChannel, sStartTD, sEndTD, iType, iBlockingmode);
            Logging("[Function] SearchEx:" + iRet.ToString() + "(Channel[" + iChannel.ToString()
                                                             + "] Start[" + sStartTD 
                                                             + "] End[" + sEndTD
                                                             + "] Type[" + iType.ToString() 
                                                             + "] Mode[" + iBlockingmode.ToString() + "]");

            if (iRet == 0)
            {
                ShowResultEx();
            }
        }

        //---------------------------------------------------------------------
        // Function Name        : buttonSearchASync_Click
        // Overview             : Start SearchEx of non-blocking mode
        //---------------------------------------------------------------------
        private void buttonSearchASync_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            int iChannel;
            string sStartTD;
            string sEndTD;
            int iType;
            int iBlockingmode;

            Call_PlayStop();

            iChannel = 1;

            sStartTD = textStartYear.Text + "/" + textStartMonth.Text + "/" + textStartDay.Text + " "
                     + textStartHour.Text + ":" + textStartMinute.Text + ":" + textStartSecond.Text;

            sEndTD = textEndYear.Text + "/" + textEndMonth.Text + "/" + textEndDay.Text + " "
                   + textEndHour.Text + ":" + textEndMinute.Text + ":" + textEndSecond.Text;

            iType = 0;
            if (checkEmergency.Checked == true)
            {
                iType += 0x01;
            }
            if (checkManual.Checked == true)
            {
                iType += 0x02;
            }
            if (checkSchedule.Checked == true)
            {
                iType += 0x04;
            }
            if (checkTerminal.Checked == true)
            {
                iType += 0x08;
            }
            if (checkCommandAlarm.Checked == true)
            {
                iType += 0x10;
            }
            if (checkCameraSiteAlarm.Checked == true)
            {
                iType += 0x20;
            }
            if (checkSDBackup.Checked == true)
            {
                iType += 0x40;
            }
            if (checkVideoLossAlarm.Checked == true)
            {
                iType += 0x80;
            }
            if (checkVMD.Checked == true)
            {
                iType += 0x0100;
            }
            if (checkMotion.Checked == true)
            {
                iType += 0x0200;
            }
            if (checkLoitering.Checked == true)
            {
                iType += 0x0400;
            }
            if (checkRemoval.Checked == true)
            {
                iType += 0x0800;
            }
            if (checkScreen.Checked == true)
            {
                iType += 0x1000;
            }
            if (checkTermivmd.Checked == true)
            {
                iType += 0x2000;
            }
            if (checkDirection.Checked == true)
            {
                iType += 0x4000;
            }

            iBlockingmode = 1;

            iRet = axipropsapiCtrl1.SearchEx(iChannel, sStartTD, sEndTD, iType, iBlockingmode);
            Logging("[Function] SearchEx:" + iRet.ToString() + "(Channel[" + iChannel.ToString()
                                                             + "] Start[" + sStartTD 
                                                             + "] End[" + sEndTD
                                                             + "] Type[" + iType.ToString() 
                                                             + "] Mode[" + iBlockingmode.ToString() + "]");
        }

        //---------------------------------------------------------------------
        // Function Name        : button1_Click
        // Overview             : Search cancel
        //---------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            //Define variables
            int iRet;

            //Search Cancel
            iRet = axipropsapiCtrl1.SearchCancel();
            Logging("[Function] SearchCancel:" + iRet.ToString());
        }

        //---------------------------------------------------------------------
        // Function Name        : listSearchResult_DoubleClick
        // Overview             : play for search result
        //---------------------------------------------------------------------
        private void listSearchResult_DoubleClick(object sender, EventArgs e)
        {
            //Define variables
            int iRet;
            string sSelectedItem;
            string sStartTime;
            string[] sTemp;

            Call_PlayStop();

            //Get listbox data
            sSelectedItem = listSearchResult.Text;
            if (sSelectedItem != "")
            {
                sTemp = sSelectedItem.Split(',');
                sStartTime = sTemp[1];
                if (sTemp[0] != null)
                {
                    iRet = axipropsapiCtrl1.Play(int.Parse(sTemp[0]), sTemp[1], 0);
                    Logging("[Function] Play:" + iRet.ToString());

                    if (iRet == 0)
                    {
                        m_PlayStatus = 1;
                    }
                }
            }
            else
            {
                Logging("[Message] There is no result record.");
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