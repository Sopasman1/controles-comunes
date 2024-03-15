
using System.Diagnostics;
namespace controles_comunes

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dark soul es la cabra");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=ti-8C6od6ME";

            Process.Start(url);
        }
    }
}
