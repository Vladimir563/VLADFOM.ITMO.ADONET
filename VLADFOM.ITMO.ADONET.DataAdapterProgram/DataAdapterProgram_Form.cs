using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VLADFOM.ITMO.ADONET.DataAdapterProgram
{
    public partial class DataAdapterProgram_Form : Form
    {
        static SqlConnection NorthwindConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=northwind;Integrated Security=True");
        static string query = "SELECT * FROM Customers";
        static SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter(query, NorthwindConnection);
        DataSet NorthwindDataset = new DataSet("Northwind");

        //позволяет автоматически сгенерировать выражения вставки, обновления и удаления
        SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);
        public DataAdapterProgram_Form()
        {
            InitializeComponent();
        }

        private void DataAdapterProgram_Form_Load(object sender, EventArgs e)
        {
            //заполнение набора данных
            SqlDataAdapter1.Fill(NorthwindDataset, "Customers");

            //связываем заполненный набор с элементом формы для отображения
            dataGridView1.DataSource = NorthwindDataset.Tables["Customers"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //использование методов BeginInit и EndInit предотвращает 
            //использование элемента управления до полной инициализации
            NorthwindDataset.EndInit();

            //сохранение изменений в базе данных
            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            //создание новой строки
            DataRow CustRow = NorthwindDataset.Tables["Customers"].NewRow();
            Object[] CustRecord = 
            { 
                "AAAAA", 
                "Alfreds Futterkiste", 
                "Maria Anders", 
                "Sales Representative", 
                "Obere Str. 57", 
                "Berlin", 
                null,
                "12209", 
                "Germany", 
                "030-0074321", 
                "030-0076545" 
            };

            //заполнение созданной строки массивом
            CustRow.ItemArray = CustRecord;
            
            //добавление созданной строки в dataset
            NorthwindDataset.Tables["Customers"].Rows.Add(CustRow);

            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            NorthwindDataset.EndInit();
            //получаем индекс строки с активной ячейкой
            var index = dataGridView1.CurrentRow.Index; 
            //удаляем строку и обновляем dataset
            NorthwindDataset.Tables["Customers"].Rows[index].Delete();
            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
        }
    }
}
