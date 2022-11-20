using System;
using System.Windows.Forms;
using OPCAutomation;

namespace Mitsu_SCADA_WINFORM_v6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            objLogin.NotLogin(); // Call NotLogin function
            ConnectKEPServerEX();  
        }
        //========================== WATCHDOG PLC connection status ================================
        string WatchdogValue = "0"; // to save value of tag Watchdog from OPC server
        private void timerWatchdog_Tick(object sender, EventArgs e)
        {
            classWatchdog.WatchdogStatus(btnConnect, WatchdogValue);
        }
        //========================== Define objects of classes ==================
        classStatusDisplay statusDisplay = new classStatusDisplay();
        classLogin objLogin = new classLogin();
        //==========================KEPServerEX CONNECT=====================
        static int tagNumber = 22;      // Number of tags in this project
        static int PLCscantime = 500;  // Setting the time cycle to scan PLC
        // Call connections to PLC
        public OPCAutomation.OPCServer AnOPCServer;
        public OPCAutomation.OPCServer OPCServer;
        public OPCAutomation.OPCGroups OPCGroup;
        public OPCAutomation.OPCGroup PLC;
        public string Groupname;

        static int arrlength = tagNumber + 1;   // +1 because we not use arr[0]
        Array OPtags = KEPServerEX.tagread(arrlength);
        Array tagID = KEPServerEX.tagID(arrlength);
        Array WriteItems = Array.CreateInstance(typeof(object), arrlength);
        Array tagHandles = Array.CreateInstance(typeof(Int32), arrlength);
        Array OPCError = Array.CreateInstance(typeof(Int32), arrlength);
        Array dataType = Array.CreateInstance(typeof(Int16), arrlength);
        Array AccessPaths = Array.CreateInstance(typeof(string), arrlength);

        private void ConnectKEPServerEX()
        {
            string IOServer = "Kepware.KEPServerEX.V6";
            string IOGroup = "OPCGroup1";
            OPCServer = new OPCAutomation.OPCServer();
            OPCServer.Connect(IOServer, "");
            PLC = OPCServer.OPCGroups.Add(IOGroup);
            PLC.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(DataScan);
            PLC.UpdateRate = PLCscantime;
            PLC.IsSubscribed = PLC.IsActive;
            PLC.OPCItems.DefaultIsActive = true;
            PLC.OPCItems.AddItems(tagNumber, ref OPtags, ref tagID,
                out tagHandles, out OPCError, dataType, AccessPaths);
        }
        //========================== Read data from tags ========================
        private void DataScan(int ID, int NumItems, ref Array tagID,
            ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                // Identify tagID and tagValue being sent to App
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i)?.ToString();
                // Get tag value
                if (getTagID == 3)
                {
                    WatchdogValue = tagValue;
                }
            }
        }
        //=================================================================
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            CSDL formCSDL = new CSDL();
            formCSDL.TopLevel = false;
            mainPanel.Controls.Add(formCSDL);
            formCSDL.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formCSDL.Dock = DockStyle.Fill;
            formCSDL.Show();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            OPCServer.Disconnect();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectKEPServerEX();
        }

        private void btnLoginLogout_Click_1(object sender, EventArgs e)
        {
            formLogin loginForm = new formLogin();
            loginForm.Show();
        }

        private void btnMachine2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Machine2 gr2 = new Machine2();
            gr2.TopLevel = false;
            mainPanel.Controls.Add(gr2);
            gr2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gr2.Dock = DockStyle.Fill;
            gr2.Show();
        }

        private void btnMachine1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Machine1 gr1 = new Machine1();
            gr1.TopLevel = false;
            mainPanel.Controls.Add(gr1);
            gr1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gr1.Dock = DockStyle.Fill;
            gr1.Show();
        }
    }
}
