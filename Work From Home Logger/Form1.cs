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
            user = new User(1);
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

        private void SetUserIpAddressLabel()
        {
            if(String.IsNullOrWhiteSpace(user.Name))
            {
                userIpAddressesLabel.Text = "Your saved IP Addresses";
                return;
            }
            userIpAddressesLabel.Text = $"{user.Name}'s IP Addresses";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {          
        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {
             user.Name = NameTextBox.Text;
            SetUserIpAddressLabel();
        }

        private void saveIpAddressButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userIpAddressTextBox.Text)) { }
            if (String.IsNullOrWhiteSpace(IpAddressNameTextBox.Text)) { }

            var ipAddress = new IpAddressDetail();
            ipAddress.Name = IpAddressNameTextBox.Text;
            ipAddress.IpAddress = userIpAddressTextBox.Text;

            user.IpAddresses.Add(ipAddress);
            
            userIpAddressesListView.Items.Add($"{ipAddress.Name}: {ipAddress.IpAddress}");
        }

        private void UserIPLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

// Save an IP address
// Save a workday

