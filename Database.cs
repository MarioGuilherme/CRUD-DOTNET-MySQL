using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace CRUD {
    public class Database {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private string sql;

        private void SetConnection() {
            connection = new MySqlConnection("Server=localhost;Database=crud_dotnet;Uid=root;Pwd=");
        }

        public void Insert(string name, float price, float cost) {
            try {
                SetConnection();

                sql = "INSERT INTO products (name, price, cost) VALUES (@name, @price, @cost)";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@cost", cost);

                connection.Open();

                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        public void SelectAll(DataGridView dataGrid) {
            try {
                SetConnection();
                sql = "SELECT * FROM products";
                da = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        public void SelectByID(int id_product, TextBox[] textBoxes) {
            try {
                SetConnection();
                sql = "SELECT * FROM products WHERE id_product = @id_product";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_product", id_product);
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read()) {
                    textBoxes[0].Text = Convert.ToString(dr["id_product"]);
                    textBoxes[1].Text = Convert.ToString(dr["name"]);
                    textBoxes[2].Text = Convert.ToString(dr["cost"]);
                    textBoxes[3].Text = Convert.ToString(dr["price"]);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        public void Update(int id_product, string name, float price, float cost) {
            try {
                SetConnection();
                sql = "UPDATE products SET name = @name, cost = @cost, price = @price WHERE id_product = @id_product";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@cost", cost);
                command.Parameters.AddWithValue("@id_product", id_product);
                connection.Open();
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        public void Delete(int id_product) {
            try {
                SetConnection();
                sql = "DELETE FROM products WHERE id_product = @id_product";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_product", id_product);
                connection.Open();
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }
    }
}