using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace Mitsu_SCADA_WINFORM_v6
{
    class classDatabase
    {
        // Write data down to PLC (2 column)
        public static void cmd_SQLWrite(string sqltable_name,
                                        string collum1, string data1,   // DateTime
                                        string collum2, string data2)   // Type of product
        {
            SqlConnection sql_conn; // Declare connection to SQL Server
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            string sql = " INSERT INTO " + sqltable_name + " ("
                + collum1 + ","
                + collum2 + ")"
                + " VALUES "
                + "("
                + "@" + collum1 + ","
                + "@" + collum2 + ")";
            using (SqlCommand cmd = new SqlCommand(sql, sql_conn))
            {
                cmd.Parameters.AddWithValue(collum1, data1);
                cmd.Parameters.AddWithValue(collum2, data2);
                cmd.ExecuteNonQuery();
            }
            sql_conn.Close();
        }
        // Delete data in SumData table
        public static void cmd_SQLDelete(string sqltable_name) 
        {
            SqlConnection sql_conn; // Declare connection to SQL Server
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            string sql = "DELETE TOP(1) FROM " + sqltable_name;
        }
        // Dislay on datagridview
        public static void sqlDisplay(string sqlSelect, DataGridView dtgr)
        {
            SqlConnection sql_conn; // Declare connection to SQL Server
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, sql_conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgr.DataSource = dt;
            dtgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sql_conn.Close();
        }
    }
}
