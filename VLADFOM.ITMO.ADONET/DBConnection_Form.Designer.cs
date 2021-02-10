
namespace VLADFOM.ITMO.ADONET
{
    partial class DBConnection_Form
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
            this.btnHowMuchProducts = new System.Windows.Forms.Button();
            this.labelHowMuchProducts = new System.Windows.Forms.Label();
            this.btnHowMuchProductsWithStaticMethod = new System.Windows.Forms.Button();
            this.labelHowMuchProductsWithStaticMethod = new System.Windows.Forms.Label();
            this.btnGetProductsList = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStartTransaction = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workingWithDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
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
            // btnHowMuchProducts
            // 
            this.btnHowMuchProducts.Location = new System.Drawing.Point(13, 27);
            this.btnHowMuchProducts.Name = "btnHowMuchProducts";
            this.btnHowMuchProducts.Size = new System.Drawing.Size(224, 23);
            this.btnHowMuchProducts.TabIndex = 1;
            this.btnHowMuchProducts.Text = "Сколько продуктов";
            this.btnHowMuchProducts.UseVisualStyleBackColor = true;
            this.btnHowMuchProducts.Click += new System.EventHandler(this.btnHowMuchProducts_Click);
            // 
            // labelHowMuchProducts
            // 
            this.labelHowMuchProducts.AutoSize = true;
            this.labelHowMuchProducts.Location = new System.Drawing.Point(243, 37);
            this.labelHowMuchProducts.Name = "labelHowMuchProducts";
            this.labelHowMuchProducts.Size = new System.Drawing.Size(0, 13);
            this.labelHowMuchProducts.TabIndex = 2;
            // 
            // btnHowMuchProductsWithStaticMethod
            // 
            this.btnHowMuchProductsWithStaticMethod.Location = new System.Drawing.Point(13, 56);
            this.btnHowMuchProductsWithStaticMethod.Name = "btnHowMuchProductsWithStaticMethod";
            this.btnHowMuchProductsWithStaticMethod.Size = new System.Drawing.Size(224, 23);
            this.btnHowMuchProductsWithStaticMethod.TabIndex = 3;
            this.btnHowMuchProductsWithStaticMethod.Text = "Сколько продуктов (отдельный метод)";
            this.btnHowMuchProductsWithStaticMethod.UseVisualStyleBackColor = true;
            this.btnHowMuchProductsWithStaticMethod.Click += new System.EventHandler(this.btnHowMuchProductsWithStaticMethod_Click);
            // 
            // labelHowMuchProductsWithStaticMethod
            // 
            this.labelHowMuchProductsWithStaticMethod.AutoSize = true;
            this.labelHowMuchProductsWithStaticMethod.Location = new System.Drawing.Point(243, 66);
            this.labelHowMuchProductsWithStaticMethod.Name = "labelHowMuchProductsWithStaticMethod";
            this.labelHowMuchProductsWithStaticMethod.Size = new System.Drawing.Size(0, 13);
            this.labelHowMuchProductsWithStaticMethod.TabIndex = 4;
            // 
            // btnGetProductsList
            // 
            this.btnGetProductsList.Location = new System.Drawing.Point(13, 323);
            this.btnGetProductsList.Name = "btnGetProductsList";
            this.btnGetProductsList.Size = new System.Drawing.Size(224, 23);
            this.btnGetProductsList.TabIndex = 5;
            this.btnGetProductsList.Text = "Список продуктов";
            this.btnGetProductsList.UseVisualStyleBackColor = true;
            this.btnGetProductsList.Click += new System.EventHandler(this.btnGetProductsList_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(12, 85);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(386, 232);
            this.listViewProducts.TabIndex = 6;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фасовка";
            this.columnHeader3.Width = 150;
            // 
            // btnStartTransaction
            // 
            this.btnStartTransaction.Location = new System.Drawing.Point(13, 353);
            this.btnStartTransaction.Name = "btnStartTransaction";
            this.btnStartTransaction.Size = new System.Drawing.Size(224, 23);
            this.btnStartTransaction.TabIndex = 7;
            this.btnStartTransaction.Text = "Транзакция";
            this.btnStartTransaction.UseVisualStyleBackColor = true;
            this.btnStartTransaction.Click += new System.EventHandler(this.btnStartTransaction_Click);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 388);
            this.Controls.Add(this.btnStartTransaction);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.btnGetProductsList);
            this.Controls.Add(this.labelHowMuchProductsWithStaticMethod);
            this.Controls.Add(this.btnHowMuchProductsWithStaticMethod);
            this.Controls.Add(this.labelHowMuchProducts);
            this.Controls.Add(this.btnHowMuchProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBConnection";
            this.Text = "Working with DataBase";
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
        private System.Windows.Forms.Button btnHowMuchProducts;
        private System.Windows.Forms.Label labelHowMuchProducts;
        private System.Windows.Forms.Button btnHowMuchProductsWithStaticMethod;
        private System.Windows.Forms.Label labelHowMuchProductsWithStaticMethod;
        private System.Windows.Forms.Button btnGetProductsList;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnStartTransaction;
    }
}

