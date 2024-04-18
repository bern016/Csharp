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
using System.Xml.Linq;

namespace Appsdev1
{
    public partial class Form1 : Form
    {
        string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = Appsdev1; Integrated Security = True"; 
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataLoad();
        }


        private void DataLoad()
        {
            string query = "SELECT * FROM [User]";

            SqlDataAdapter da = new SqlDataAdapter(query, _connectionString);

            DataSet ds = new DataSet();

            da.Fill(ds, "User");

            dataGridView1.DataSource = ds.Tables["User"].DefaultView;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGrid = sender as DataGridView;

                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
                label4.Text = selectedRow.Cells["Id"].Value.ToString();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            string newId = (dataGridView1.RowCount).ToString();

            string query = "INSERT INTO [User] (Id, Name, Age)" +
                $"VALUES ('{newId}', '{name}', '{age}')";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex} ");

                }
                connection.Close();
                DataLoad();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            string newId = (dataGridView1.RowCount).ToString();

            string query = $"UPDATE [User] SET Column_1 = '{name}'," +
                $"Column_2 =  '{age}'" +
                $"WHERE Id = '{newId}'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex} ");

                }
                connection.Close();
            
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string newId = (dataGridView1.RowCount).ToString();

            string query = $"DELETE FROM [User] WHERE Id = '{}'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex} ");

                }
                connection.Close();
            
            }
        }
    }
}
