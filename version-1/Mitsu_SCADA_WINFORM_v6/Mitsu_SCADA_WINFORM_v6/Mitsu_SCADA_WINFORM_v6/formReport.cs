using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitsu_SCADA_WINFORM_v6
{
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
        }
        public string rpDatetime_Start;
        public string rpDatetime_End;
        public string rptomorrow;
        private void formReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSqlReport.parameter_data' table. You can move, or remove it, as needed.
            //            this.parameter_dataTableAdapter.Fill(this.dsSqlReport.parameter_data);
            // ++++++Cho full màn hình khi nhấn nút báo cáo (form_Report)++++++
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // ++++++TÌM KIẾM THEO NGÀY THÁNG++++++
            {
                // Quy đổi giá trị thời gian sang dạng "datetime"
                DateTime DateStart = Convert.ToDateTime(rpDatetime_Start);
                DateTime DateEnd = Convert.ToDateTime(rpDatetime_End);
                // Đưa câu lệnh query sang Dataset
                this.DataTableAdapter.Fill(this.Report.Data, DateStart, DateEnd);
                this.reportViewer1.RefreshReport(); // Hiển thị báo cáo
            }
            // Làm full màn hình in                               
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();


            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}