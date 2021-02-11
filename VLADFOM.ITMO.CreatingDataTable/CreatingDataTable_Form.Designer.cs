
namespace VLADFOM.ITMO.CreatingDataTable
{
    partial class CreatingDataTable_Form
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
            this.btnFillChildTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFillMainTable = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillChildTable
            // 
            this.btnFillChildTable.Location = new System.Drawing.Point(13, 13);
            this.btnFillChildTable.Name = "btnFillChildTable";
            this.btnFillChildTable.Size = new System.Drawing.Size(168, 23);
            this.btnFillChildTable.TabIndex = 0;
            this.btnFillChildTable.Text = "Заполнить дочернюю таблицу";
            this.btnFillChildTable.UseVisualStyleBackColor = true;
            this.btnFillChildTable.Click += new System.EventHandler(this.btnFillChildTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnFillMainTable
            // 
            this.btnFillMainTable.Location = new System.Drawing.Point(13, 199);
            this.btnFillMainTable.Name = "btnFillMainTable";
            this.btnFillMainTable.Size = new System.Drawing.Size(168, 23);
            this.btnFillMainTable.TabIndex = 2;
            this.btnFillMainTable.Text = "Заполнить основную таблицу";
            this.btnFillMainTable.UseVisualStyleBackColor = true;
            this.btnFillMainTable.Click += new System.EventHandler(this.btnFillMainTable_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // CreatingDataTable_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 389);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnFillMainTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFillChildTable);
            this.Name = "CreatingDataTable_Form";
            this.Text = "CreatingDataTable_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFillChildTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFillMainTable;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

