using System;
using System.Windows.Forms;

namespace Mitsu_SCADA_WINFORM_v6
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        classLogin objLogin = new classLogin();

        private void form_Login_Load(object sender, EventArgs e)
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            // Disable login function
            if (frm.btnMachine1.Enabled == true) 
            {
                btnLogin.Enabled = false;
                tbxUsername.Enabled = false;
                tbxPassword.Enabled = false;
            }
            else // Enablelogin function
            {
                btnLogin.Enabled = true;
                tbxUsername.Enabled = true;
                tbxPassword.Enabled = true;
            }
        }
        // Declare user name 
        string user1Name = "admin";        
        string user1Password = "123456";   

        string user2Name = "user";        
        string user2Password = "123456";     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login by Admin
            if (tbxUsername.Text == user1Name & tbxPassword.Text == user1Password)
            {
                objLogin.adminControlElements();
                this.Close(); // Close login form
            }
            else if (tbxUsername.Text == user2Name & tbxPassword.Text == user2Password)
            {
                objLogin.operatorControlElements();
                this.Close(); // Close login form
            }
            else
            {
                MessageBox.Show("User or password are wrong!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            tbxUsername.Enabled = true;
            tbxPassword.Enabled = true;
            objLogin.NotLogin(); // Call not login function, disable some buttons
        }
    }
}
