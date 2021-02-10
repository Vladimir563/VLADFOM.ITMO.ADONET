
namespace VLADFOM.ITMO.ADONET.DBCommand
{
    partial class DBCommand_Form
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.btnQueryData = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.btnPackageQuery = new System.Windows.Forms.Button();
            this.btnCallProcedure = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.btnQueryWithParam = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.btnProcedureWithParameters = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
    "True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        CustomerID, CompanyName\r\nFROM            Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // btnQueryData
            // 
            this.btnQueryData.Location = new System.Drawing.Point(13, 13);
            this.btnQueryData.Name = "btnQueryData";
            this.btnQueryData.Size = new System.Drawing.Size(122, 22);
            this.btnQueryData.TabIndex = 0;
            this.btnQueryData.Text = "Запрос данных";
            this.btnQueryData.UseVisualStyleBackColor = true;
            this.btnQueryData.Click += new System.EventHandler(this.btnQueryData_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(13, 43);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(250, 300);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // btnPackageQuery
            // 
            this.btnPackageQuery.Location = new System.Drawing.Point(141, 13);
            this.btnPackageQuery.Name = "btnPackageQuery";
            this.btnPackageQuery.Size = new System.Drawing.Size(122, 22);
            this.btnPackageQuery.TabIndex = 2;
            this.btnPackageQuery.Text = "Пакетный запрос";
            this.btnPackageQuery.UseVisualStyleBackColor = true;
            this.btnPackageQuery.Click += new System.EventHandler(this.btnPackageQuery_Click);
            // 
            // btnCallProcedure
            // 
            this.btnCallProcedure.Location = new System.Drawing.Point(12, 349);
            this.btnCallProcedure.Name = "btnCallProcedure";
            this.btnCallProcedure.Size = new System.Drawing.Size(123, 23);
            this.btnCallProcedure.TabIndex = 3;
            this.btnCallProcedure.Text = "Вызов процедуры";
            this.btnCallProcedure.UseVisualStyleBackColor = true;
            this.btnCallProcedure.Click += new System.EventHandler(this.btnCallProcedure_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "Ten Most Expensive Products";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(141, 349);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(122, 23);
            this.btnCreateTable.TabIndex = 4;
            this.btnCreateTable.Text = "Создание таблицы";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // btnQueryWithParam
            // 
            this.btnQueryWithParam.Location = new System.Drawing.Point(301, 12);
            this.btnQueryWithParam.Name = "btnQueryWithParam";
            this.btnQueryWithParam.Size = new System.Drawing.Size(155, 23);
            this.btnQueryWithParam.TabIndex = 5;
            this.btnQueryWithParam.Text = "Запрос с параметром";
            this.btnQueryWithParam.UseVisualStyleBackColor = true;
            this.btnQueryWithParam.Click += new System.EventHandler(this.btnQueryWithParam_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(301, 41);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(155, 20);
            this.CityTextBox.TabIndex = 6;
            this.CityTextBox.Text = "London";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT CustomerID, CompanyName, City FROM Customers WHERE City = @City";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // btnProcedureWithParameters
            // 
            this.btnProcedureWithParameters.Location = new System.Drawing.Point(301, 92);
            this.btnProcedureWithParameters.Name = "btnProcedureWithParameters";
            this.btnProcedureWithParameters.Size = new System.Drawing.Size(155, 23);
            this.btnProcedureWithParameters.TabIndex = 7;
            this.btnProcedureWithParameters.Text = "Процедура с параметрами";
            this.btnProcedureWithParameters.UseVisualStyleBackColor = true;
            this.btnProcedureWithParameters.Click += new System.EventHandler(this.btnProcedureWithParameters_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(301, 122);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.CategoryNameTextBox.TabIndex = 8;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(301, 148);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(155, 20);
            this.OrdYearTextBox.TabIndex = 9;
            this.OrdYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // DBCommand_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 380);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.btnProcedureWithParameters);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.btnQueryWithParam);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnCallProcedure);
            this.Controls.Add(this.btnPackageQuery);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.btnQueryData);
            this.Name = "DBCommand_Form";
            this.Text = "DBCommand_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button btnQueryData;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button btnPackageQuery;
        private System.Windows.Forms.Button btnCallProcedure;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button btnQueryWithParam;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button btnProcedureWithParameters;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

