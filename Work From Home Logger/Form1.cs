using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_From_Home_Logger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Add this to the form class's constructor.  
            var addresses = GetIpAddress();
            for (int i = 0; i < addresses.Length; i++)
            {
                Debug.WriteLine($"{i}, {addresses[i]}");
            }
        }

        public string IpAddress { get; set; }
        public string HostName { get; private set; }

        public string GetHostName()
        {
            var hostName = Dns.GetHostName();
            Debug.WriteLine(hostName);
            return hostName;
        }

        public IPAddress[] GetIpAddress()
        {
            var hostName = GetHostName();
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);

            return addresses;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

// Save an IP address
// Save a workday

