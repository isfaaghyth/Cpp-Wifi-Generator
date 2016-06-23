using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace CreateWIFI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextWriter tulis = new StreamWriter(@"C:\WINDOWS\wificreate.bat");
            //menulis file teks sesuai yang isi textbox1.text
            tulis.WriteLine("");
            tulis.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter tulis = new StreamWriter(@"C:\WINDOWS\wificreate.bat");
            //menulis file teks sesuai yang isi textbox1.text
            tulis.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + txtName.Text + " key=" + txtPass.Text);
            tulis.WriteLine("netsh wlan start hostednetwork");
            tulis.Close();
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@"C:\WINDOWS\wificreate.bat");
            psi.RedirectStandardOutput = true;
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            psi.UseShellExecute = false;
            System.Diagnostics.Process.Start(psi);

            //system.Diagnostics.Process.Start(@"C:\WINDOWS\wificreate.bat");
        }
    }

}
