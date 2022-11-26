using System;
using System.Windows.Forms;
using OPCAutomation;

namespace Mitsu_SCADA_WINFORM_v6
{
    public partial class Machine1 : Form
    {
        //int temperature = 0;
        internal static Machine1 formMain;
        public Machine1()
        {
            InitializeComponent();
            formMain = this; // Make reference to formMain
        }
        private void Machine1_Load(object sender, EventArgs e)
        {
            ConnectKEPServerEX();
        }
        //========================== Define objects of classes ==================
        classStatusDisplay statusDisplay = new classStatusDisplay();
        classLogin fnLogin = new classLogin();
        //==========================KEPServerEX CONNECT=====================
        static int tagNumber = 22;      // Number of tags in this project
        static int PLCscantime = 500;  // Setting the time cycle to scan PLC
        // Call connections to PLC
        public OPCAutomation.OPCServer AnOPCServer;
        public OPCAutomation.OPCServer OPCServer;
        public OPCAutomation.OPCGroups OPCGroup;
        public OPCAutomation.OPCGroup PLC;
        public string Groupname;

        static int arrlength = tagNumber + 1; // +1 because we not use arr[0]
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
        //========================== Read data from tags =====================
        private void DataScan(int ID, int NumItems, ref Array tagID,
            ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                // Identify tagID and tagValue being sent to App
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i)?.ToString();
                // Get tag value
                if (getTagID == 10)
                {
                    statusDisplay.sttTwoStatus(symStart, tagValue);
                }
                if (getTagID == 11)
                {
                    statusDisplay.sttTwoStatus(symStop, tagValue);
                }
                if (getTagID == 12)
                {
                    statusDisplay.sttTwoStatus(symServo1, tagValue);
                    statusDisplay.sttTwoStatus(symContainer1, tagValue); 
                }
                if (getTagID == 13)
                {
                    statusDisplay.sttTwoStatus(symServo2, tagValue);
                    statusDisplay.sttTwoStatus(symContainer2, tagValue);
                }
                if (getTagID == 14)
                {
                    statusDisplay.sttTwoStatus(symConveyor, tagValue);
                }
                if (getTagID == 15)
                {
                    statusDisplay.sttTwoStatus(symLight1, tagValue);
                    statusDisplay.sttTwoStatus(symLight2, tagValue);
                    statusDisplay.sttTwoStatus(symLight3, tagValue);
                }
                if (getTagID == 16)
                {
                    labTimeONLights.Text = tagValue;
                }
                if (getTagID == 17)
                {
                    labTimeOFFLights.Text = tagValue;
                }
                if (getTagID == 18)
                {
                    statusDisplay.sttTwoStatus(sensor1, tagValue);
                }
                if (getTagID == 19)
                {
                    statusDisplay.sttTwoStatus(sensor2, tagValue);
                }
            }
        }
        //============== Write data to tags ===================
        
        //============== Transact data from popup window =============
        public void popup_button_Clicked(int tagID)
        {
            WriteItems.SetValue(1, tagID);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, tagID);
        }

        private void symLight1_Click(object sender, EventArgs e)
        {
            formPopupWindow frmPopup = new formPopupWindow();
            frmPopup.tag_ONID = 4;   // ID tag Run
            frmPopup.tag_OFFID = 5;  // ID tag Stop
            frmPopup.Show();
            formPopupWindow.formPopup.setTitle("Lights Control");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(1, 1);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, 1);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(1, 2);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, 2);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void symServo1_Click(object sender, EventArgs e)
        {
            formPopupWindow frmpopup = new formPopupWindow();
            frmpopup.tag_ONID = 6;   // ID tag Run
            frmpopup.tag_OFFID = 7;  // ID tag Stop
            frmpopup.Show();
            formPopupWindow.formPopup.setTitle("Servo 1 Control");
        }

        private void symServo2_Click(object sender, EventArgs e)
        {
            formPopupWindow frmpopup = new formPopupWindow();
            frmpopup.tag_ONID = 8;   // ID tag Run
            frmpopup.tag_OFFID = 9;  // ID tag Stop
            frmpopup.Show();
            formPopupWindow.formPopup.setTitle("Servo 2 Control");
        }

        private void btnSaveLightTurnOnTime_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(tbxLightTurnOnTime.Text, 16);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            MessageBox.Show("Set Light turned ON time!");
        }

        private void btnSaveLightTurnOffTime_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(tbxLightTurnOffTime.Text, 17);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            MessageBox.Show("Set Light turned OFF time!");
        }
    }
}
