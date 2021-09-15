
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentIpAddressListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveIpAddressButton = new System.Windows.Forms.Button();
            this.userIpAddressTextBox = new System.Windows.Forms.TextBox();
            this.UserIPLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentIpAddressListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1102, 81);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50);
            this.panel1.Size = new System.Drawing.Size(791, 980);
            this.panel1.TabIndex = 0;
            // 
            // currentIpAddressListBox
            // 
            this.currentIpAddressListBox.FormattingEnabled = true;
            this.currentIpAddressListBox.ItemHeight = 41;
            this.currentIpAddressListBox.Location = new System.Drawing.Point(53, 152);
            this.currentIpAddressListBox.Name = "currentIpAddressListBox";
            this.currentIpAddressListBox.Size = new System.Drawing.Size(600, 168);
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
            this.panel3.Controls.Add(this.saveIpAddressButton);
            this.panel3.Controls.Add(this.userIpAddressTextBox);
            this.panel3.Controls.Add(this.UserIPLabel);
            this.panel3.Location = new System.Drawing.Point(53, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 364);
            this.panel3.TabIndex = 2;
            // 
            // saveIpAddressButton
            // 
            this.saveIpAddressButton.Location = new System.Drawing.Point(57, 229);
            this.saveIpAddressButton.Name = "saveIpAddressButton";
            this.saveIpAddressButton.Size = new System.Drawing.Size(310, 58);
            this.saveIpAddressButton.TabIndex = 2;
            this.saveIpAddressButton.Text = "Save your IP Address";
            this.saveIpAddressButton.UseVisualStyleBackColor = true;
            this.saveIpAddressButton.Click += new System.EventHandler(this.saveIpAddressButton_Click);
            // 
            // userIpAddressTextBox
            // 
            this.userIpAddressTextBox.Location = new System.Drawing.Point(53, 130);
            this.userIpAddressTextBox.Name = "userIpAddressTextBox";
            this.userIpAddressTextBox.Size = new System.Drawing.Size(833, 47);
            this.userIpAddressTextBox.TabIndex = 1;
            // 
            // UserIPLabel
            // 
            this.UserIPLabel.AutoSize = true;
            this.UserIPLabel.Location = new System.Drawing.Point(53, 49);
            this.UserIPLabel.Name = "UserIPLabel";
            this.UserIPLabel.Size = new System.Drawing.Size(314, 41);
            this.UserIPLabel.TabIndex = 0;
            this.UserIPLabel.Text = "Your Home IP Address";
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
    }
}

