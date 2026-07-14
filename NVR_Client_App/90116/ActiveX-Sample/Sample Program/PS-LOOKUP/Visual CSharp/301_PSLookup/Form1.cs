using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleSample_PSLookup
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
        //SearchStatus 0:Off 1:On
        enum SearchStatus {
            SearchOff = 0,
            SearchOn = 1
        };
        SearchStatus gStatus;

        //****************************************************************
        //* Function Name        : Load
        //* Overview             : Load PSAPI and Initialize
        //****************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            //Show the log window
            frmForm2 = new Form2();
            frmForm2.Location = new Point(this.Size.Width, 0);
            frmForm2.Show();

            //----------------------------------------
            //Set properties (ActiveX)
            //----------------------------------------
            // Set non visible
            AxpsLookupCtrl.Visible = false;
            AxpsLookupCtrl.Height = 10;
            AxpsLookupCtrl.Width = 10;

            //Set properties for event
            AxpsLookupCtrl.OnDevLookupEnable = 0;
            Logging("[Property] OnDevLookupEnable:=0");
            AxpsLookupCtrl.OnErrorEnable = 1;

            //----------------------------------------
            //Set parameters (Other controls)
            //----------------------------------------
            listBox1.Items.Clear();
  
        }

        //****************************************************************
        //* Function Name        : FormClosed
        //* Overview             : Destroy main window
        //****************************************************************
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //----------------------------------------
            //Set properties (ActiveX)
            //----------------------------------------
            AxpsLookupCtrl.OnDevLookupEnable = 0;
            Logging("[Property] OnDevLookupEnable:=0");
            AxpsLookupCtrl.OnErrorEnable = 0;
            
            frmForm2.Close();
        }

        //****************************************************************
        //* Function Name        : Search_Click
        //* Overview             : Switching the camera searches
        //****************************************************************
        private void b_Search_Click(object sender, EventArgs e)
        {
            if (gStatus == SearchStatus.SearchOff) {
                AxpsLookupCtrl.OnDevLookupEnable = 1;
                Logging("[Property] OnDevLookupEnable:=1");
                gStatus = SearchStatus.SearchOn;
                b_Search.Text = "&End";
            }
            else {
                this.AxpsLookupCtrl.OnDevLookupEnable = 0;
                Logging("[Property] OnDevLookupEnable:=0");
                gStatus = SearchStatus.SearchOff;
                b_Search.Text = "&Start";
            }
        }

        //****************************************************************
        //* Function Name        : OnDevLookup
        //* Overview             : OnDevLookup listener event
        //****************************************************************
        private void AxpsLookupCtrl_OnDevLookup(object sender, AxpslookupLib._IpslookupctrlEvents_OnDevLookupEvent e)
        {
            String Logs;
            //Output Logs
            Logs = "macAddr : " + e.macAddr + "\r\n" +
                    "ipAddr : " + e.ipAddr + "\r\n" +
                    "ipv6Addr : " + e.ipv6Addr + "\r\n" +
                    "portNo : " + e.portNo + "\r\n" +
                    "camName : " + e.camName + "\r\n" +
                    "modelName : " + e.modelName;
            Logging("[OnDevLookup] " + Logs);

            Logs = Logs.Replace("\r\n", " ");
            listBox1.Items.Add(Logs);
        }

        //****************************************************************
        //* Function Name        : OnError
        //* Overview             : OnError listener event
        //****************************************************************
        private void AxpsLookupCtrl_OnError(object sender, AxpslookupLib._IpslookupctrlEvents_OnErrorEvent e)
        {
            //Output Logs
            Logging("[OnError] errorCode[" + e.errorCode.ToString() + "] description[" + e.description + "]");
        }

        //****************************************************************
        //* Function Name        : Logging
        //* Overview             : Output Logs
        //****************************************************************
        private void Logging(string str)
        {
            if (frmForm2.textLog.Text.CompareTo(string.Empty) != 0) {
                frmForm2.textLog.Text = frmForm2.textLog.Text + "\r\n";
            }
            frmForm2.textLog.Text = frmForm2.textLog.Text + str;
        }

    }
}