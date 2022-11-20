namespace Mitsu_SCADA_WINFORM_v6
{
    partial class CSDL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbSQLServer = new System.Windows.Forms.GroupBox();
            this.btnSaveDataName = new System.Windows.Forms.Button();
            this.btnEditDataName = new System.Windows.Forms.Button();
            this.tbxDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.grbSortByTime = new System.Windows.Forms.GroupBox();
            this.rdbSortByType = new System.Windows.Forms.RadioButton();
            this.rdbSortByTime = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpkTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpkDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpkTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpkDateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCheckData = new System.Windows.Forms.Button();
            this.timerGetData = new System.Windows.Forms.Timer(this.components);
            this.grbSQLServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbSortByTime.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSQLServer
            // 
            this.grbSQLServer.BackColor = System.Drawing.Color.Gray;
            this.grbSQLServer.Controls.Add(this.btnSaveDataName);
            this.grbSQLServer.Controls.Add(this.btnEditDataName);
            this.grbSQLServer.Controls.Add(this.tbxDBName);
            this.grbSQLServer.Controls.Add(this.label1);
            this.grbSQLServer.Location = new System.Drawing.Point(12, 12);
            this.grbSQLServer.Name = "grbSQLServer";
            this.grbSQLServer.Size = new System.Drawing.Size(366, 125);
            this.grbSQLServer.TabIndex = 0;
            this.grbSQLServer.TabStop = false;
            this.grbSQLServer.Text = "SQL Server";
            // 
            // btnSaveDataName
            // 
            this.btnSaveDataName.Enabled = false;
            this.btnSaveDataName.ForeColor = System.Drawing.Color.Green;
            this.btnSaveDataName.Location = new System.Drawing.Point(130, 80);
            this.btnSaveDataName.Name = "btnSaveDataName";
            this.btnSaveDataName.Size = new System.Drawing.Size(86, 31);
            this.btnSaveDataName.TabIndex = 3;
            this.btnSaveDataName.Text = "Save";
            this.btnSaveDataName.UseVisualStyleBackColor = true;
            this.btnSaveDataName.Click += new System.EventHandler(this.btnSaveDataName_Click);
            // 
            // btnEditDataName
            // 
            this.btnEditDataName.Location = new System.Drawing.Point(38, 80);
            this.btnEditDataName.Name = "btnEditDataName";
            this.btnEditDataName.Size = new System.Drawing.Size(86, 31);
            this.btnEditDataName.TabIndex = 2;
            this.btnEditDataName.Text = "Edit";
            this.btnEditDataName.UseVisualStyleBackColor = true;
            this.btnEditDataName.Click += new System.EventHandler(this.btnEditDataName_Click);
            // 
            // tbxDBName
            // 
            this.tbxDBName.Enabled = false;
            this.tbxDBName.Location = new System.Drawing.Point(38, 50);
            this.tbxDBName.Name = "tbxDBName";
            this.tbxDBName.Size = new System.Drawing.Size(259, 24);
            this.tbxDBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Name:";
            // 
            // btnShowData
            // 
            this.btnShowData.BackColor = System.Drawing.Color.Green;
            this.btnShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowData.Location = new System.Drawing.Point(50, 143);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(124, 42);
            this.btnShowData.TabIndex = 4;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = false;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1511, 558);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(1278, 77);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(130, 60);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Export a Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grbSortByTime
            // 
            this.grbSortByTime.Controls.Add(this.rdbSortByType);
            this.grbSortByTime.Controls.Add(this.rdbSortByTime);
            this.grbSortByTime.Location = new System.Drawing.Point(414, 12);
            this.grbSortByTime.Name = "grbSortByTime";
            this.grbSortByTime.Size = new System.Drawing.Size(241, 125);
            this.grbSortByTime.TabIndex = 11;
            this.grbSortByTime.TabStop = false;
            this.grbSortByTime.Text = "Sort By:";
            // 
            // rdbSortByType
            // 
            this.rdbSortByType.AutoSize = true;
            this.rdbSortByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSortByType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbSortByType.Location = new System.Drawing.Point(27, 70);
            this.rdbSortByType.Name = "rdbSortByType";
            this.rdbSortByType.Size = new System.Drawing.Size(184, 29);
            this.rdbSortByType.TabIndex = 1;
            this.rdbSortByType.Text = "Type of product";
            this.rdbSortByType.UseVisualStyleBackColor = true;
            // 
            // rdbSortByTime
            // 
            this.rdbSortByTime.AutoSize = true;
            this.rdbSortByTime.Checked = true;
            this.rdbSortByTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSortByTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbSortByTime.Location = new System.Drawing.Point(27, 29);
            this.rdbSortByTime.Name = "rdbSortByTime";
            this.rdbSortByTime.Size = new System.Drawing.Size(81, 29);
            this.rdbSortByTime.TabIndex = 0;
            this.rdbSortByTime.TabStop = true;
            this.rdbSortByTime.Text = "Time";
            this.rdbSortByTime.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpkTimeEnd);
            this.groupBox2.Controls.Add(this.dtpkDateEnd);
            this.groupBox2.Controls.Add(this.dtpkTimeStart);
            this.groupBox2.Controls.Add(this.dtpkDateStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(710, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 125);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finding follow time";
            // 
            // dtpkTimeEnd
            // 
            this.dtpkTimeEnd.CustomFormat = "HH:mm:ss";
            this.dtpkTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTimeEnd.Location = new System.Drawing.Point(175, 75);
            this.dtpkTimeEnd.Name = "dtpkTimeEnd";
            this.dtpkTimeEnd.ShowUpDown = true;
            this.dtpkTimeEnd.Size = new System.Drawing.Size(95, 24);
            this.dtpkTimeEnd.TabIndex = 6;
            // 
            // dtpkDateEnd
            // 
            this.dtpkDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateEnd.Location = new System.Drawing.Point(74, 75);
            this.dtpkDateEnd.Name = "dtpkDateEnd";
            this.dtpkDateEnd.Size = new System.Drawing.Size(95, 24);
            this.dtpkDateEnd.TabIndex = 5;
            // 
            // dtpkTimeStart
            // 
            this.dtpkTimeStart.CustomFormat = "HH:mm:ss";
            this.dtpkTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTimeStart.Location = new System.Drawing.Point(175, 24);
            this.dtpkTimeStart.Name = "dtpkTimeStart";
            this.dtpkTimeStart.ShowUpDown = true;
            this.dtpkTimeStart.Size = new System.Drawing.Size(95, 24);
            this.dtpkTimeStart.TabIndex = 4;
            // 
            // dtpkDateStart
            // 
            this.dtpkDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateStart.Location = new System.Drawing.Point(74, 24);
            this.dtpkDateStart.Name = "dtpkDateStart";
            this.dtpkDateStart.Size = new System.Drawing.Size(95, 24);
            this.dtpkDateStart.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "End:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Begin:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1044, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 60);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Find Data";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCheckData
            // 
            this.btnCheckData.BackColor = System.Drawing.Color.Green;
            this.btnCheckData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckData.Location = new System.Drawing.Point(210, 144);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(124, 42);
            this.btnCheckData.TabIndex = 14;
            this.btnCheckData.Text = "Check Data";
            this.btnCheckData.UseVisualStyleBackColor = false;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // timerGetData
            // 
            this.timerGetData.Enabled = true;
            this.timerGetData.Interval = 500;
            this.timerGetData.Tick += new System.EventHandler(this.timerGetData_Tick);
            // 
            // CSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1584, 847);
            this.Controls.Add(this.btnCheckData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.grbSortByTime);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbSQLServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "CSDL";
            this.Text = "Data Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoadDB);
            this.grbSQLServer.ResumeLayout(false);
            this.grbSQLServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbSortByTime.ResumeLayout(false);
            this.grbSortByTime.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSQLServer;
        private System.Windows.Forms.Button btnSaveDataName;
        private System.Windows.Forms.Button btnEditDataName;
        private System.Windows.Forms.TextBox tbxDBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox grbSortByTime;
        private System.Windows.Forms.RadioButton rdbSortByTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpkTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpkDateEnd;
        private System.Windows.Forms.DateTimePicker dtpkTimeStart;
        private System.Windows.Forms.DateTimePicker dtpkDateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdbSortByType;
        private System.Windows.Forms.Button btnCheckData;
        private System.Windows.Forms.Timer timerGetData;
    }
}