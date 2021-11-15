using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20190140091;

namespace ServerConfigForm_P5_20190140091
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonon_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            buttonon.Enabled = false;
            buttonoff.Enabled = true;
        }

        private void buttonoff_Click(object sender, EventArgs e)
        {
            buttonon.Enabled = true;
            buttonoff.Enabled = false;
            Host.Close();
            labelOnOrOff.Text = "Server OFF";
            labelKet.Text = "Klik ON untuk Menjalankan Server";
        }
    }
}
