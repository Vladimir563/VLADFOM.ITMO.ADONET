using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLADFOM.ITMO.ADONET.LoadDataSetXml
{
    public partial class LoadDataSetXml_Form : Form
    {
        DataSet NorthwindDataSet = new DataSet();
        public LoadDataSetXml_Form()
        {
            InitializeComponent();
        }

        private void LoadSchemaButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.ReadXmlSchema("Northwind.xsd");

            CustomersGrid.DataSource = NorthwindDataSet.Tables["Customers"];
            OrdersGrid.DataSource = NorthwindDataSet.Tables["Orders"];
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.ReadXml("Northwind.xml");
        }
    }
}
