
using System.Windows.Forms;

namespace Work_From_Home_Logger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIpAddressesLabel = new System.Windows.Forms.Label();
            this.currentIpAddressListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserIPLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.saveIpAddressButton = new System.Windows.Forms.Button();
            this.IpAddressNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIpAddressTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.userIpAddressesLabel);
            this.panel1.Controls.Add(this.currentIpAddressListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1102, 81);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50);
            this.panel1.Size = new System.Drawing.Size(791, 980);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(685, 375);
            this.dataGridView1.TabIndex = 4;
            // 
            // userIpAddressesLabel
            // 
            this.userIpAddressesLabel.AutoSize = true;
            this.userIpAddressesLabel.Location = new System.Drawing.Point(53, 353);
            this.userIpAddressesLabel.Name = "userIpAddressesLabel";
            this.userIpAddressesLabel.Size = new System.Drawing.Size(334, 41);
            this.userIpAddressesLabel.TabIndex = 3;
            this.userIpAddressesLabel.Text = "Your saved IP addresses";
            this.userIpAddressesLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // currentIpAddressListBox
            // 
            this.currentIpAddressListBox.FormattingEnabled = true;
            this.currentIpAddressListBox.ItemHeight = 41;
            this.currentIpAddressListBox.Location = new System.Drawing.Point(53, 152);
            this.currentIpAddressListBox.Name = "currentIpAddressListBox";
            this.currentIpAddressListBox.Size = new System.Drawing.Size(685, 168);
            this.currentIpAddressListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your machines current IP Addresses";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveNameButton);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(53, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 320);
            this.panel2.TabIndex = 1;
            // 
            // saveNameButton
            // 
            this.saveNameButton.Location = new System.Drawing.Point(53, 209);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(296, 58);
            this.saveNameButton.TabIndex = 2;
            this.saveNameButton.Text = "Save your name";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(53, 94);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(833, 47);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UserIPLabel);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(53, 450);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(50);
            this.panel3.Size = new System.Drawing.Size(977, 611);
            this.panel3.TabIndex = 2;
            // 
            // UserIPLabel
            // 
            this.UserIPLabel.AutoSize = true;
            this.UserIPLabel.Location = new System.Drawing.Point(75, 53);
            this.UserIPLabel.Name = "UserIPLabel";
            this.UserIPLabel.Size = new System.Drawing.Size(261, 41);
            this.UserIPLabel.TabIndex = 0;
            this.UserIPLabel.Text = "Add an IP Address";
            this.UserIPLabel.Click += new System.EventHandler(this.UserIPLabel_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.saveIpAddressButton);
            this.panel5.Controls.Add(this.IpAddressNameTextBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.userIpAddressTextBox);
            this.panel5.Location = new System.Drawing.Point(51, 106);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(50, 50, 50, 25);
            this.panel5.Size = new System.Drawing.Size(873, 318);
            this.panel5.TabIndex = 4;
            // 
            // saveIpAddressButton
            // 
            this.saveIpAddressButton.Location = new System.Drawing.Point(52, 215);
            this.saveIpAddressButton.Name = "saveIpAddressButton";
            this.saveIpAddressButton.Size = new System.Drawing.Size(310, 58);
            this.saveIpAddressButton.TabIndex = 2;
            this.saveIpAddressButton.Text = "Save your IP Address";
            this.saveIpAddressButton.UseVisualStyleBackColor = true;
            this.saveIpAddressButton.Click += new System.EventHandler(this.saveIpAddressButton_Click);
            // 
            // IpAddressNameTextBox
            // 
            this.IpAddressNameTextBox.Location = new System.Drawing.Point(426, 123);
            this.IpAddressNameTextBox.Name = "IpAddressNameTextBox";
            this.IpAddressNameTextBox.Size = new System.Drawing.Size(311, 47);
            this.IpAddressNameTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ip Address Name (e.g. Home)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ip Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // userIpAddressTextBox
            // 
            this.userIpAddressTextBox.Location = new System.Drawing.Point(53, 123);
            this.userIpAddressTextBox.Name = "userIpAddressTextBox";
            this.userIpAddressTextBox.Size = new System.Drawing.Size(309, 47);
            this.userIpAddressTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2003, 1142);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Work from home logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }




        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox currentIpAddressListBox;
        private Panel panel2;
        private Label label2;
        private TextBox NameTextBox;
        private Button saveNameButton;
        private Panel panel3;
        private Label UserIPLabel;
        private Button saveIpAddressButton;
        private TextBox userIpAddressTextBox;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private TextBox IpAddressNameTextBox;
        private Label userIpAddressesLabel;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
    }
}

