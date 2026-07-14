using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_InternetModeLive
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
        //LiveStatus 0:Off 1:On
        enum LiveStatus
        {
            Start = 0,
            Live = 1
        };
        LiveStatus gPlayStatus;

        //****************************************************************
        //* Function Name        : Load
        //* Overview             : Load PSAPI & Initialize
        //****************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Please confirm beforehand that the internet mode of a target device is turned ON.", "Simple_Sample_InternetModeLive", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Show the log window
            frmForm2 = new Form2();
            frmForm2.Location = new Point(this.Size.Width, 0);
            frmForm2.Show();

            gPlayStatus = LiveStatus.Start;

            //----------------------------------------
            //Set properties (ActiveX)
            //----------------------------------------
            //Set visible(VGA)
            AxiProCtrl.Visible = true;
            AxiProCtrl.Height = 480;
            AxiProCtrl.Width = 640;

            //Set properties to connect the device
            AxiProCtrl.IPAddr = "192.168.0.10";
            AxiProCtrl.DeviceType = 2;
            AxiProCtrl.HttpPort = 80;
            AxiProCtrl.UserName = "admin";
            AxiProCtrl.Password = "admin12345";

            //Set properties for event
            AxiProCtrl.OnErrorEnable = 1;
            AxiProCtrl.OnDevStatusEnable = 0;
            AxiProCtrl.OnRecStatusEnable = 0;
            AxiProCtrl.OnPlayStatusEnable = 1;
            AxiProCtrl.OnImageRefreshEnable = 0;
            AxiProCtrl.OnRecordStatusEnable = 0;
            AxiProCtrl.OnOpStatusEnable = 0;
            AxiProCtrl.OnAlmStatusEnable = 0;
            AxiProCtrl.OnRecStatusCBEnable = 0;
            AxiProCtrl.OnSearchCBEnable = 0;
            AxiProCtrl.OnSearchExCBEnable = 0;
            AxiProCtrl.OnPlayStatusCBEnable = 0;
            AxiProCtrl.OnOpStatusCBEnable = 0;
            AxiProCtrl.OnAlmStatusCBEnable = 0;
            AxiProCtrl.OnFtpStatusCBEnable = 0;
            AxiProCtrl.MouseDownEnable = 0;

            //Set initial status
            AxiProCtrl.StreamFormat = 3;       //H.264

            //----------------------------------------
            //Set parameters (TextBox)
            //----------------------------------------
            textBox1.Text = "1";

            long lRet = 0;
            lRet = AxiProCtrl.Open();
            Logging("[Function] Open:" + lRet.ToString());

        }

        //****************************************************************
        //* Function Name        : FormClosed
        //* Overview             : Destroy main window
        //****************************************************************
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //----------------------------------------
            //Set properties
            //----------------------------------------
            //Close connecntion to the device
            AxiProCtrl.Close();
            Logging("[Function] Close");

            //Set properties for event
            AxiProCtrl.OnErrorEnable = 0;
            AxiProCtrl.OnDevStatusEnable = 0;
            AxiProCtrl.OnRecStatusEnable = 0;
            AxiProCtrl.OnPlayStatusEnable = 0;
            AxiProCtrl.OnImageRefreshEnable = 0;
            AxiProCtrl.OnRecordStatusEnable = 0;
            AxiProCtrl.OnOpStatusEnable = 0;
            AxiProCtrl.OnAlmStatusEnable = 0;
            AxiProCtrl.OnRecStatusCBEnable = 0;
            AxiProCtrl.OnSearchCBEnable = 0;
            AxiProCtrl.OnSearchExCBEnable = 0;
            AxiProCtrl.OnPlayStatusCBEnable = 0;
            AxiProCtrl.OnOpStatusCBEnable = 0;
            AxiProCtrl.OnAlmStatusCBEnable = 0;
            AxiProCtrl.OnFtpStatusCBEnable = 0;
            AxiProCtrl.MouseDownEnable = 0;
            frmForm2.Close();

        }

        //****************************************************************
        //* Function Name        : StartLive
        //* Overview             : Start live video play
        //****************************************************************
        private void b_LiveStart_Click(object sender, EventArgs e)
        {
            int Ret, Channel, Blockmode;

            //Check the play status
            if (gPlayStatus == LiveStatus.Start) {
                //Start Live
                Channel = 1;        //Network Camera
                Blockmode = 0;      //Blocking
                Ret = AxiProCtrl.PlayLive(Channel, Blockmode);
                Logging("[Function] PlayLive(Start):" + Ret.ToString());
                if (Ret == 0) {
                    gPlayStatus = LiveStatus.Live;
                }
                else {
                    AxiProCtrl.Close();
                }
            }
            else {
                Logging("[Message] In the live.");
            }
        }

        //****************************************************************
        //* Function Name        : StopLive
        //* Overview             : Stop live video play
        //****************************************************************
        private void b_LiveEnd_Click(object sender, EventArgs e)
        {
            int Ret, Command, Speed, Blockmode;

            //Check the play status
            if (gPlayStatus == LiveStatus.Live) {
                //Stop Live
                Command = 1;         //Stop live
                Speed = 1;           //Step 1
                Blockmode = 0;       //Blocking
                Ret = AxiProCtrl.PlayControl(Command, Speed, Blockmode);
                Logging("[Function] PlayLive(Stop):" + Ret.ToString());
                //Clear Image;
                AxiProCtrl.ClearImage();

                gPlayStatus = LiveStatus.Start;
            }
            else {
                Logging("[Message] No live.");
            }
        }

        //****************************************************************
        //* Function Name        : SetInternetModeChange
        //* Overview             : InternetMode Change
        //****************************************************************
        private void b_SetInternetMode_Click(object sender, EventArgs e)
        {
            int Ret, Channel, Command;

            if (gPlayStatus == LiveStatus.Start) {
                Channel = 1;        //Network camera
                if (!int.TryParse(textBox1.Text, out Command)) return;
                if (Command != 0 && Command != 1) return;
                Ret = AxiProCtrl.SetInternetModeCam(Channel, Command, AxiProCtrl.StreamFormat, AxiProCtrl.StreamNumber);
                Logging("[Function] SetInternetModeCam(SetMode=" + Command.ToString() + "):" + Ret.ToString());
                AxiProCtrl.InternetMode = Command;
                Logging("[Property] InternetMode:" + AxiProCtrl.InternetMode.ToString());
            }
            else {
                Logging("[Message] in the live.");
            }
        }

        //****************************************************************
        //* Function Name        : OnError
        //* Overview             : OnError listener event
        //****************************************************************
        private void AxiProCtrl_OnError(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //****************************************************************
        //* Function Name        : OnPlayStatus
        //* Overview             : OnPlayStatus listener event
        //****************************************************************
        private void AxiProCtrl_OnPlayStatus(object sender, AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent e)
        {
            //Output Logs
            Logging("[OnPlayStatus] channel[" + e.channel.ToString() + "] status[" + e.status.ToString() + "]");
        }

        //****************************************************************
        //* Function Name        : Logging
        //* Overview             : Output Logs
        //****************************************************************
        private void Logging(string str)
        {
            if (frmForm2.textLog.Text.CompareTo(string.Empty) != 0)
            {
                frmForm2.textLog.Text = frmForm2.textLog.Text + "\r\n";
            }
            frmForm2.textLog.Text = frmForm2.textLog.Text + str;
        }
    }
}