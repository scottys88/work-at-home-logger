
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
            this.addButton = new System.Windows.Forms.Button();
            this.currentValue = new System.Windows.Forms.TextBox();
            this.subtractButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(290, 139);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 58);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Increment";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add);
            // 
            // currentValue
            // 
            this.currentValue.Location = new System.Drawing.Point(290, 268);
            this.currentValue.Name = "currentValue";
            this.currentValue.Size = new System.Drawing.Size(250, 47);
            this.currentValue.TabIndex = 1;
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(607, 139);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(188, 58);
            this.subtractButton.TabIndex = 2;
            this.subtractButton.Text = "decrement";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.Subtract);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.currentValue);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Work from home logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox currentValue;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Label label1;
    }
}

