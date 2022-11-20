using System.Drawing;
using System.Windows.Forms;

namespace Mitsu_SCADA_WINFORM_v6
{
    class classWatchdog
    {
        static string valOld = "";
        // Whatdog function
        public static void WatchdogStatus(Button btn, string valNow)
        {
            if (valNow != valOld)
            {
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
            }
            valOld = valNow;
        }
    }
}
