using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLADFOM.ITMO.ADONET.DatasetDesigner
{
    public partial class DatasetDesigner_Form : Form
    {
        public DatasetDesigner_Form()
        {
            InitializeComponent();
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            //Создаём экземпляр типизированного набора данных Northwind
            NorthwindDataSet NorthwindDataset1 = new NorthwindDataSet();

            //создаём экземпляр класса adapter
            NorthwindDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 = new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            //вызываем метод для загрузки всех клиентов в DataTable
            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);

            //передаём значения в ListBox
            foreach (NorthwindDataSet.CustomersRow NWCustomer in NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }
        }
    }
}
