using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using CRUD.Database;

namespace CRUD {
    public partial class Main : Form {
        private static MySqlConnection connection = Database.Database.Connect();
        private static MySqlCommand command;
        private static MySqlDataAdapter da;
        private static MySqlDataReader dr;
        private string sql;

        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void label1_Click(object sender, EventArgs e) {}

        private void textBox1_TextChanged(object sender, EventArgs e) {}

        private void label2_Click(object sender, EventArgs e) {}

        private void label3_Click(object sender, EventArgs e) {}

        private void button5_Click(object sender, EventArgs e) {
            try {
                connection = new MySqlConnection("Server=localhost;Database=crud_dotnet;Uid=root;Pwd=");
                sql = "SELECT * FROM products";
                da = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                connection = new MySqlConnection("Server=localhost;Database=crud_dotnet;Uid=root;Pwd=");
                sql = "INSERT INTO products (name, price, cost) VALUES (@name, @price, @cost)";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", inputName.Text);
                command.Parameters.AddWithValue("@price", inputPrice.Text);
                command.Parameters.AddWithValue("@cost", inputCost.Text);
                connection.Open();
                command.ExecuteNonQuery();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            try {
                connection = new MySqlConnection("Server=localhost;Database=crud_dotnet;Uid=root;Pwd=");
                sql = "UPDATE products SET name = @name, cost = @cost, price = @price WHERE id_product = @id_product";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", inputName.Text);
                command.Parameters.AddWithValue("@price", inputPrice.Text);
                command.Parameters.AddWithValue("@cost", inputCost.Text);
                command.Parameters.AddWithValue("@id_product", inputID.Text);
                connection.Open();
                command.ExecuteNonQuery();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                connection = new MySqlConnection("Server=localhost;Database=crud_dotnet;Uid=root;Pwd=");
                sql = "DELETE FROM products WHERE id_product = @id_product";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_product", inputID.Text);
                connection.Open();
                command.ExecuteNonQuery();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnConsult_Click(object sender, EventArgs e) {
            try {
                connection = new MySqlConnection("Server=localhost;Database=crud_dotnet;Uid=root;Pwd=");
                sql = "SELECT * FROM products WHERE id_product = @id_product";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_product", inputID.Text);
                connection.Open();
                dr = command.ExecuteReader();
                while(dr.Read()) {
                    inputID.Text = Convert.ToString(dr["id_product"]);
                    inputName.Text = Convert.ToString(dr["name"]);
                    inputCost.Text = Convert.ToString(dr["cost"]);
                    inputPrice.Text = Convert.ToString(dr["price"]);
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }
    }
}