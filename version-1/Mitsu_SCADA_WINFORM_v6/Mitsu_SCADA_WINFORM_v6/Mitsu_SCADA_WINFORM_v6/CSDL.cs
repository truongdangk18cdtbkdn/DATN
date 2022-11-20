using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using OPCAutomation; // Thư viện OPC

namespace Mitsu_SCADA_WINFORM_v6
{
    public partial class CSDL : Form
    {
        public CSDL()
        {
            InitializeComponent();
        }

        // Form load
        private void LoadDB(object sender, EventArgs e)
        {
            ConnectKEPServerEX();
            tbxDBName.Text = Properties.Settings.Default.SQL_DBName; //Load DB name
        }
        //==========================KEPServerEX CONNECT=====================
        static int tagNumber = 22;   
        static int PLCscantime = 500;  
        // Call OPC connections
        public OPCAutomation.OPCServer AnOPCServer;
        public OPCAutomation.OPCServer OPCServer;
        public OPCAutomation.OPCGroups OPCGroup;
        public OPCAutomation.OPCGroup PLC;
        public string Groupname;

        static int arrlength = tagNumber + 1;
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
        //==========================ĐỌC DỮ LIỆU TAG========================
        string typeOfProduct;
        private void DataScan(int ID, int NumItems, ref Array tagID,
            ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i)?.ToString();
                
                if (getTagID == 21)
                {
                    if (tagValue == "True")
                    {
                        // Declare connection to SQL Server
                        SqlConnection sql_conn; 
                        string DB_Name = Properties.Settings.Default.SQL_DBName;
                        string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                                         + DB_Name + ";Integrated Security=True";
                        sql_conn = new SqlConnection(sqlName);
                        sql_conn.Open();
                        // Add SumData
                        string sqlAdd = @"UPDATE SumData SET quantity = quantity + 1 
                            WHERE DAY(SumData.dayTime) = (SELECT TOP(1) DAY(Data.dayTime) FROM Data) 
                            AND MONTH(SumData.dayTime) = (SELECT TOP(1) MONTH(Data.dayTime) FROM Data) 
	                        AND SumData.typeProduct = (SELECT TOP(1) Data.typeProduct FROM Data) ";
                        SqlCommand cmdAdd = new SqlCommand(sqlAdd, sql_conn);
                        cmdAdd.ExecuteNonQuery();
                        // Delete the product seperated
                        string sqlDelete = "delete from dbo.Data where Data.ID = (select top(1) ID from dbo.Data)";
                        SqlCommand cmdDelete = new SqlCommand(sqlDelete, sql_conn);
                        cmdDelete.ExecuteNonQuery();
                        sql_conn.Close();
                        // Write down the done signal to PLC
                        WriteItems.SetValue(1, 22);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                        WriteItems.SetValue(0, 22);                        
                    }
                }
            }

        }
        //==========================GHI DỮ LIỆU TAG=====================
        // Nút nhấn Edit SQL Database Name     
        private void btnEditDataName_Click(object sender, EventArgs e)
        {
            tbxDBName.Enabled = true;
            btnSaveDataName.Enabled = true;
        }
        // Button edit database's name
        private void btnSaveDataName_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SQL_DBName = tbxDBName.Text; //The name of Database    
            Properties.Settings.Default.Save(); // Save to Setting
            tbxDBName.Enabled = false; // Disable text field
            MessageBox.Show("Sửa thành công, Khởi động lại phần mềm để cập nhật!");
        }
        // Button dislaying data onto Datagridview
        private void btnShowData_Click(object sender, EventArgs e)
        { 
            string sqlSelect = "SELECT * FROM dbo.SumData";
            classDatabase.sqlDisplay(sqlSelect, dataGridView1);
            // Naming for columns
            dataGridView1.Columns[0].HeaderText = "Date Time";
            dataGridView1.Columns[1].HeaderText = "Type Of Product";
            dataGridView1.Columns[2].HeaderText = "Quantity";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Tạo các biến string từ date time piker
            string Date_Start = dtpkDateStart.Value.ToString("yyyy-MM-dd");
            string Time_Start = dtpkTimeStart.Value.ToString("HH:mm:ss");
            string Date_End = dtpkDateEnd.Value.ToString("yyyy-MM-dd");
            string Time_End = dtpkTimeEnd.Value.ToString("HH:mm:ss");
            // Mở form xuất báo cáo (form_Report)
            formReport frm = new formReport();
            // Truyền dữ liệu qua form report
            frm.rpDatetime_Start = Date_Start + ' ' + Time_Start;
            frm.rpDatetime_End = Date_End + ' ' + Time_End;
            frm.Show();
        }
        // Find data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // SQL find following DateTime
            string dateStart = dtpkDateStart.Value.ToString("yyyy-MM-dd");
            string timeStart = dtpkTimeStart.Value.ToString("HH:mm:ss");
            string dateEnd = dtpkDateEnd.Value.ToString("yyyy-MM-dd");
            string timeEnd = dtpkTimeEnd.Value.ToString("HH:mm:ss");
            string choice = "2";
            string tableName = "SumData"; // Table name need to query

            if (rdbSortByTime.Checked == true) // If choose finding follow DateTime
            {
                string typeChoice = "dayTime";
                string sqlSelect = "SELECT * FROM " + tableName + " WHERE " + typeChoice +
                    " BETWEEN '" + dateStart + " " + timeStart + "' AND '" + dateEnd + " " + timeEnd + "'" +
                    " ORDER BY " + typeChoice;
                classDatabase.sqlDisplay(sqlSelect, dataGridView1);
            }
            else if (rdbSortByType.Checked == true)
            {
                string typeChoice = "typeProduct";
                string sqlSelect = "SELECT * FROM " + tableName + " WHERE " + typeChoice +
                    " = " + choice +
                    " ORDER BY " + typeChoice;
                classDatabase.sqlDisplay(sqlSelect, dataGridView1);
            } 
        }

        private void btnCheckData_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT * FROM dbo.Data";
            classDatabase.sqlDisplay(sqlSelect, dataGridView1);
            // Naming for columns
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Date Time";
            dataGridView1.Columns[2].HeaderText = "Type Of Product";
        }

        private void timerGetData_Tick(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT TOP(1) * FROM dbo.Data";
            SqlConnection sql_conn; // Declare connection to SQL Server
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, sql_conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                typeOfProduct = reader["typeProduct"].ToString();
            }
            sql_conn.Close();

            WriteItems.SetValue(typeOfProduct, 20);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            
        }
    }
}
