using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedArchitectureExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Using block is used...When we want to call dispose method automatically
            using (MySqlConnection CN = new MySqlConnection("Data Source=127.0.0.1;Port=3306;Database=netdb;User Id=root;Password=Lsd@5030"))
            {
                MySqlDataAdapter DA
                    = new MySqlDataAdapter("Select * from Customers", CN);
                DataSet DS = new DataSet();
                DA.Fill(DS, "Customers");
                customersDataGridView.DataSource = DS.Tables[0];
            }
        }
    }
}
