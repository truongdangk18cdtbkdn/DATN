using System;
using System.Windows.Forms;

namespace Mitsu_SCADA_WINFORM_v6
{
    public partial class formPopupWindow : Form
    {
        internal static formPopupWindow formPopup;
        public formPopupWindow()
        {
            InitializeComponent();
            formPopup = this;
        }
        // Function displaying the title
        public void setTitle(string title)
        {
            this.Text = title;
        }
        // Declare 2 varible tagID for 2 buttons ON & OFF
        public int tag_ONID;
        public int tag_OFFID;

        private void btnON_Click(object sender, EventArgs e)
        {
            Machine1.formMain.popup_button_Clicked(tag_ONID);
            this.Close();
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            Machine1.formMain.popup_button_Clicked(tag_OFFID);
            this.Close();
        }
    }
}
