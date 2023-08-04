using System.Diagnostics;


namespace LunchMenu_MK1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLunch1_Click(object sender, EventArgs e)
        {
            string[] arrLunch = {
                "±èÄ¡Âî°³"
                , "¶ó¸é ±è¹ä"
                , "µ·°¡½º"
                , "½Ò±¹¼ö"
                , "»þºê»þºê"
                , "ÇÇÀÚ"
                , "»ø·¯µå"
                , "ÇÜ¹ö°Å"
                , "¹Ð¸é"
                , "µÅÁö±¹¹ä"
                , "Åä½ºÆ®"
                , "Âò´ß"
                , "¶ó¸à"
                , "Ä«·¹"
                , "Â¥Àå¸é ÅÁ¼öÀ°"
                , "¹é¹Ý"
                , "¼øµÎºÎ"
            };
            Random rnd = new Random();
            linkLblLunch1.Text = arrLunch[rnd.Next(arrLunch.Length)];
        }

        private void linkLblLunch1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if(!(linkLblLunch1.Text == "¿À´ÃÀÇ Á¡½É ¸Þ´º´Â ¹»±î~¿ä??"))
            {
                try
                {
                    //WebLunch1 webLunch1 = new WebLunch1();
                    //webLunch1.Show();
                    Process.Start("Chrome.exe", "https://www.google.com/search?q=" + linkLblLunch1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }
        }
    }
}