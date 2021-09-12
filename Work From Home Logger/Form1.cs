using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        public int Counter { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentValue.Text = Counter.ToString();
        }

        private void SetCurrentValue()
        {
            currentValue.Text = Counter.ToString();
        }


        private void Add(object sender, EventArgs e)
        {
            Counter += 1;
            SetCurrentValue();
        }

        private void Subtract(object sender, EventArgs e)
        {
            if(Counter <= 0)
            {
                label1.Text = "Cannot go below 0";
                return;
            }
            Counter -= 1;
            SetCurrentValue();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
