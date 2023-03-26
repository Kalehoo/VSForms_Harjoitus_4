using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_4_PDF_NETFRAME_472
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string version = "Version 0.0.0.1";
            string author = "Lauri Liukkonen";
            string versionLabel = $"{version} by {author}";
            version_Label.Text = versionLabel;

        }

        private void calcuclate_Button_Click(object sender, EventArgs e)
        {
            // (f) haetaan tiedot konvertoitavaksi (e) fetching data to convert
            string tuntipalkka_toConvert = tuntipalkka_Box.Text;
            string tunnit_toConvert = tunnit_Box.Text;
            string tunnit150_toConvert = tunnit150_Box.Text;
            string tunnit200_toConvert = tunnit200_Box.Text;

            // (f) konvertoidaan data (e) converting data

            double tuntipalkka_Convert = Convert.ToDouble(tuntipalkka_toConvert);
            double tunnit_Convert = Convert.ToDouble(tunnit_toConvert);
            double tunnit150_Convert = Convert.ToDouble(tunnit150_toConvert);
            double tunnit200_Convert = Convert.ToDouble(tunnit200_toConvert);

            // (f) lasketaan data (e) calcuclating data

            // (f) Palkat (e) Wages

            double tunnit_Overall = tuntipalkka_Convert * tunnit_Convert;
            double tunnit150_Overall = tunnit150_Convert * (tuntipalkka_Convert * 1.5);
            double tunnit200_Overall = tunnit200_Convert * (tuntipalkka_Convert * 2);

            // (f) Tunnit (e) Hours

            double tunnit_Count_Overall = tunnit_Convert + tunnit150_Convert + tunnit200_Convert;
            double yt_tunnit_Count_Overall = tunnit150_Convert + tunnit200_Convert;
            double yt_tunnit_Value_Overall = tunnit150_Overall + tunnit200_Overall;

            double overall_Result_value = tunnit_Overall + tunnit150_Overall + tunnit200_Overall;

            // (f) Tulosprintti (e) Printing results

            string output_Tunnit_Overall = $"{tunnit_Count_Overall} tuntia.";
            string output_YT_Tunnit_Overall = $"{yt_tunnit_Count_Overall} tuntia.";
            string output_YT_Tunnit_Value_Overall = $"{yt_tunnit_Value_Overall} €.";

            string overall_Result = $"{overall_Result_value} €.";

            yht_Tunnit_Result_Label.Text = output_Tunnit_Overall;
            yht_YTTunnit_result_Label.Text = output_YT_Tunnit_Overall;
            value_YTTunnit_Result.Text = output_YT_Tunnit_Value_Overall;
            total_Result_result.Text = overall_Result;

        }

        private void tuntipalkka_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (f) hyväksytään vain numeraalit (TextBox) txtIkainput, eli iän syöttö
            // (e) accepting numerals only on (TextBox) txtIkainput, which is inputting age
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void tunnit_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (f) hyväksytään vain numeraalit (TextBox) txtIkainput, eli iän syöttö
            // (e) accepting numerals only on (TextBox) txtIkainput, which is inputting age
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void tunnit200_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (f) hyväksytään vain numeraalit (TextBox) txtIkainput, eli iän syöttö
            // (e) accepting numerals only on (TextBox) txtIkainput, which is inputting age
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void tunnit150_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (f) hyväksytään vain numeraalit (TextBox) txtIkainput, eli iän syöttö
            // (e) accepting numerals only on (TextBox) txtIkainput, which is inputting age
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }
    }
}
