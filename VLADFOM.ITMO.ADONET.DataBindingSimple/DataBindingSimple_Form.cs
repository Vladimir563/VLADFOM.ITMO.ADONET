using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLADFOM.ITMO.ADONET.DataBindingSimple
{
    public partial class DataBindingSimple_Form : Form
    {
        private BindingSource productsBindingSource;
        public DataBindingSimple_Form()
        {
            InitializeComponent();
        }

        private void DataBindingSimple_Form_Load(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(northwindDataSet1.Products);

            productsBindingSource = new BindingSource(northwindDataSet1, "Products");

            ProductIDTextBox.DataBindings.Add("Text", productsBindingSource, "ProductID");
            ProductNameTextBox.DataBindings.Add("Text", productsBindingSource, "ProductName");
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }
    }
}
