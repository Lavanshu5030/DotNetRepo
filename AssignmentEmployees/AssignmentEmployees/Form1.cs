using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentEmployees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection CN = new MySqlConnection("Data Source=127.0.0.1;Port=3306;Database=netdb;User Id=root;Password=Lsd@5030"))
            {
                MySqlDataAdapter DA1 = new MySqlDataAdapter("Select * from Customers", CN);
                MySqlDataAdapter DA2 = new MySqlDataAdapter("Select * from Employees", CN);
                MySqlDataAdapter DA3 = new MySqlDataAdapter("Select * from Products", CN);

                DataSet DS = new DataSet();
                DA1.Fill(DS, "Customers");
                DA2.Fill(DS, "Employees");
                DA3.Fill(DS, "Products");
                foreach (DataTable table in DS.Tables)
                {
                    Console.WriteLine(table.TableName);
                }
                if (DS.Tables.Count >= 3)
                {
                    customersDataGridView.DataSource = DS.Tables[1]; // Use index 1 for the second table
                }
            }
        }
    }
}
