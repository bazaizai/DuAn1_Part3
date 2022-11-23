using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Utilities
{
    internal class Vldate
    {
        public static bool Null(string Msg) => string.IsNullOrEmpty(Msg.Trim());
        public static bool Number(string Msg) => int.TryParse(Msg.Trim(), out int x);
        public static bool Decimal(string Msg) => decimal.TryParse(Msg.Trim(), out decimal x);
        public static bool KnullCBBGrb(GroupBox groupBox) 
        {
            foreach (RJComboBox cbb in groupBox.Controls.OfType<RJComboBox>())
            {
                MessageBox.Show(cbb.Text);
                if (Null(cbb.Text)) return false;
               
            }
            return true;
        }
        public static bool KnullTXTGrb(GroupBox groupBox, RJTextBox Textbox)
        {
            foreach (RJTextBox txt in groupBox.Controls.OfType<RJTextBox>())
            {
                if (txt != Textbox && Null(txt.Texts)) return false;
            }
            return true;
        }
        public static bool CRdo(GroupBox groupBox)
        {
            foreach (var rdo in groupBox.Controls.OfType<RJRadioButton>())
            {
                if (rdo.Checked)
                    return true;
            }
            return false;
        }
        public static bool SDT(string txt) => txt.Length == 10 && txt.StartsWith('0') && Number(txt);
        public static bool CheckTuoi(DateTimePicker date) => DateTime.Now.Year - date.Value.Year >= 18;
        public static bool CheckMK(string Txt) => Txt.Any(char.IsUpper) && Txt.Length >= 8;
        
    }
}
