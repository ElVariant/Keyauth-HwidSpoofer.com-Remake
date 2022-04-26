using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variant.Rust
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string name = "";
        static string ownerid = "";
        static string secret = "";
        static string version = "1.0";
        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            KeyAuthApp.license(Logintxt.Text);
            if (KeyAuthApp.response.success)
            {
                this.Hide();
                Form5 main = new Form5();
                main.Show();
            }
            else
            { MessageBox.Show("Invalid Key!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            KeyAuthApp.license(Logintxt.Text);
            if (KeyAuthApp.response.success)
            {
                this.Hide();
                Form5 main = new Form5();
                main.Show();
            }
            else
            { MessageBox.Show("Invalid Key!"); }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/w64MEHXA7a");
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void gunaCircleButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/muXxrTpNYY");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
