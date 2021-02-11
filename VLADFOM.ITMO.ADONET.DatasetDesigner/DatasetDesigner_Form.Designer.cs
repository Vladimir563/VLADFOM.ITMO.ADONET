
namespace VLADFOM.ITMO.ADONET.DatasetDesigner
{
    partial class DatasetDesigner_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetCustomers = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetCustomers
            // 
            this.btnGetCustomers.Location = new System.Drawing.Point(13, 13);
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(200, 23);
            this.btnGetCustomers.TabIndex = 0;
            this.btnGetCustomers.Text = "GetCustomersButton";
            this.btnGetCustomers.UseVisualStyleBackColor = true;
            this.btnGetCustomers.Click += new System.EventHandler(this.btnGetCustomers_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(13, 43);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(200, 238);
            this.CustomersListBox.TabIndex = 1;
            // 
            // DatasetDesigner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 324);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.btnGetCustomers);
            this.Name = "DatasetDesigner_Form";
            this.Text = "DatasetDesigner_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetCustomers;
        private System.Windows.Forms.ListBox CustomersListBox;
    }
}

