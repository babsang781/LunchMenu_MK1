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
                "��ġ�"
                , "��� ���"
                , "������"
                , "�ұ���"
                , "�������"
                , "����"
                , "������"
                , "�ܹ���"
                , "�и�"
                , "��������"
                , "�佺Ʈ"
                , "���"
                , "���"
                , "ī��"
                , "¥��� ������"
                , "���"
                , "���κ�"
            };
            Random rnd = new Random();
            linkLblLunch1.Text = arrLunch[rnd.Next(arrLunch.Length)];
        }

        private void linkLblLunch1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if(!(linkLblLunch1.Text == "������ ���� �޴��� ����~��??"))
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