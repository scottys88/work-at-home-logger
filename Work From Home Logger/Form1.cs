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

            var userRepository = new UserRepository();
            User = userRepository.Retrieve(1);
            //user = new User(1);
            //user.IpAddresses = new List<IpAddressDetail>();
            setBindingLists();            
        }

        public User User { get; private set; }
        public BindingList<IpAddressDetail> ipAddressBindingList { get; private set; } = new BindingList<IpAddressDetail>();
        public BindingList<WorkDay> workDayAddressBindingList { get; private set; } = new BindingList<WorkDay>();

        private void setBindingLists()
        {
            dataGridView1.DataSource = ipAddressBindingList;
            workdayDataGridView.DataSource = workDayAddressBindingList;
        }


        private void Form1_Load(object sender, EventArgs e)
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
            if(String.IsNullOrWhiteSpace(User.Name))
            {
                userIpAddressesLabel.Text = "Your saved IP Addresses";
                return;
            }
            userIpAddressesLabel.Text = $"{User.Name}'s IP Addresses";
        }
        

        private void saveNameButton_Click(object sender, EventArgs e)
        {
             User.Name = NameTextBox.Text;
            SetUserIpAddressLabel();
        }

        private void saveIpAddressButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userIpAddressTextBox.Text)) { }
            if (String.IsNullOrWhiteSpace(IpAddressNameTextBox.Text)) { }

            var isIpAddressMatching = IpAddress.IsIpAddressActive(userIpAddressTextBox.Text);

            var ipAddressDetail = new IpAddressDetail()
            {
                Name = IpAddressNameTextBox.Text,
                IpAddress = userIpAddressTextBox.Text,
                IsActive = isIpAddressMatching
            };


            User.IpAddresses.Add(ipAddressDetail); ;
            ipAddressBindingList.Add(ipAddressDetail);

            if(User.HasMatchingIpAddress())
            {
                var workday = User.CreateNewWorkDay();
                User.WorkDayList.Add(workday);
                workDayAddressBindingList.Add(workday);
            }
        }
    }
}

// Save an IP address
// Save a workday

