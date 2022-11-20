using SymbolFactoryDotNet; 
using System.Drawing;
using System.Windows.Forms;

namespace Mitsu_SCADA_WINFORM_v6
{
    class classStatusDisplay
    {
        // Display 2 status Group
        public void sttTwoStatus(StandardControl st, string value)
        {
            if (value == "True")
            {
                st.DiscreteValue1 = true;
            }
            else
            {
                st.DiscreteValue1 = false;
            }
        }
        // Display button Group
        public void sttButton(Button btn, string value, string backcolor, string forecolor)
        {
            if (value == "True")
            {
                btn.BackColor = ColorTranslator.FromHtml(backcolor);
                btn.ForeColor = ColorTranslator.FromHtml(forecolor);
            }
            else
            {
                btn.BackColor = default(Color);
                btn.ForeColor = default(Color);
            }
        }
    }
}
