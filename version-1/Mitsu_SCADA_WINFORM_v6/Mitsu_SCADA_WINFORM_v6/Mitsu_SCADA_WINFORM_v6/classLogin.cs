using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mitsu_SCADA_WINFORM_v6
{

    public class classLogin
    {
        // Have not login yet
        // Disable buttons when have not login yet
        public void NotLogin()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            frm.btnMachine1.Enabled = false;
            frm.btnMachine2.Enabled = false;
            frm.btnData.Enabled = false;
        }
        // Login by Admin permit
        public void adminControlElements()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            frm.btnMachine1.Enabled = true;
            frm.btnMachine2.Enabled = true;
            frm.btnData.Enabled = true;
        }
        // Login by mormal user
        public void operatorControlElements()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            frm.btnMachine1.Enabled = false;
            frm.btnMachine2.Enabled = false;
            frm.btnData.Enabled = false;
        }
    }
}
