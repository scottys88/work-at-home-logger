using ClassLibrary;
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
            
            DisplayCurrentIpAddresses();
        }

        public User user { get; set; }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayCurrentIpAddresses()
        {
            var addresses = IpAddress.GetIpAddresses();

            for(var i = 0; i < addresses.Length; i++)
            {
                currentIpAddressListBox.Items.Add(addresses[i]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {          
        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {
            if(user == null)
            {
                user = new User();
            }
            user.Name = NameTextBox.Text;
        }

        private void saveIpAddressButton_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new User();
            }

            user.IpAddresses = userIpAddressTextBox.Text;
        }
    }
}

// Save an IP address
// Save a workday

