﻿
namespace VLADFOM.ITMO.ADONET
{
    partial class DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workingWithDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncConnectToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workingWithDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // workingWithDBToolStripMenuItem
            // 
            this.workingWithDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDBToolStripMenuItem,
            this.disconnectFromDBToolStripMenuItem,
            this.asyncConnectToDBToolStripMenuItem,
            this.connectionsListToolStripMenuItem});
            this.workingWithDBToolStripMenuItem.Name = "workingWithDBToolStripMenuItem";
            this.workingWithDBToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.workingWithDBToolStripMenuItem.Text = "Working with DB";
            // 
            // connectToDBToolStripMenuItem
            // 
            this.connectToDBToolStripMenuItem.Name = "connectToDBToolStripMenuItem";
            this.connectToDBToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.connectToDBToolStripMenuItem.Text = "Connect to DB";
            this.connectToDBToolStripMenuItem.Click += new System.EventHandler(this.connectToDBToolStripMenuItem_Click);
            // 
            // disconnectFromDBToolStripMenuItem
            // 
            this.disconnectFromDBToolStripMenuItem.Name = "disconnectFromDBToolStripMenuItem";
            this.disconnectFromDBToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.disconnectFromDBToolStripMenuItem.Text = "Disconnect from DB";
            this.disconnectFromDBToolStripMenuItem.Click += new System.EventHandler(this.disconnectFromDBToolStripMenuItem_Click);
            // 
            // asyncConnectToDBToolStripMenuItem
            // 
            this.asyncConnectToDBToolStripMenuItem.Name = "asyncConnectToDBToolStripMenuItem";
            this.asyncConnectToDBToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.asyncConnectToDBToolStripMenuItem.Text = "Async connect to DB";
            this.asyncConnectToDBToolStripMenuItem.Click += new System.EventHandler(this.asyncConnectToDBToolStripMenuItem_Click);
            // 
            // connectionsListToolStripMenuItem
            // 
            this.connectionsListToolStripMenuItem.Name = "connectionsListToolStripMenuItem";
            this.connectionsListToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.connectionsListToolStripMenuItem.Text = "Connections List";
            this.connectionsListToolStripMenuItem.Click += new System.EventHandler(this.connectionsListToolStripMenuItem_Click);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBConnection";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DBConnection_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem workingWithDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncConnectToDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsListToolStripMenuItem;
    }
}
