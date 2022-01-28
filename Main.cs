using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace CRUD {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            Database db = new Database();
            db.SelectAll(dataGrid);
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void ToggleButtons(int[] indexesButtons) {
            Button[] buttons = { btnNew, btnGet, btnShowAll, btnUpdate, btnDelete };
            foreach (Button i in buttons) {
                i.Enabled = false;
            }
            foreach (int i in indexesButtons) {
                buttons[i].Enabled = true;
            }
        }

        private void ToggleTextBoxes(int[] indexesTextBoxes) {
            TextBox[] textBoxes = { inputID, inputName, inputCost, inputPrice };
            foreach (TextBox i in textBoxes) {
                i.Enabled = false;
            }
            foreach (int i in indexesTextBoxes) {
                textBoxes[i].Enabled = true;
            }
        }

        private void CleanFields() {
            TextBox[] textBoxes = { inputID, inputName, inputCost, inputPrice };
            foreach (TextBox i in textBoxes) {
                i.Text = "";
            }
        }

        private void btnForm_Click(object sender, EventArgs e) {
            ToggleButtons(new int[] { 0, 2 });
            ToggleTextBoxes(new int[] { 1, 2, 3 });
            CleanFields();
        }

        private void btnList_Click(object sender, EventArgs e) {
            ToggleButtons(new int[] { 1, 2 });
            ToggleTextBoxes(new int[] { 0 });
            CleanFields();
        }

        private void btnNew_Click(object sender, EventArgs e) {
            if(inputName.Text == "" || inputPrice.Text == "" || inputCost.Text == "") {
                MessageBox.Show("There are fields to be filled in!");
            } else {
                Database db = new Database();
                string name = inputName.Text;
                float price = float.Parse(inputPrice.Text);
                float cost = float.Parse(inputCost.Text);
                db.Insert(name, price, cost);
                CleanFields();
                db.SelectAll(dataGrid);
            }
        }

        private void btnGet_Click(object sender, EventArgs e) {
            if (inputID.Text == "") {
                MessageBox.Show("There are fields to be filled in!");
            } else {
                Database db = new Database();
                int id_product = Int32.Parse(inputID.Text);
                db.SelectByID(id_product, new TextBox[] { inputID, inputName, inputCost, inputPrice });
                ToggleButtons(new int[] { 2, 3, 4 });
                ToggleTextBoxes(new int[] { 1, 2, 3 });
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e) {
            Database db = new Database();
            db.SelectAll(dataGrid);
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (inputID.Text == "" || inputName.Text == "" || inputPrice.Text == "" || inputCost.Text == "") {
                MessageBox.Show("There are fields to be filled in!");
            } else {
                Database db = new Database();
                int id_product = Int32.Parse(inputID.Text);
                string name = inputName.Text;
                float price = float.Parse(inputPrice.Text);
                float cost = float.Parse(inputCost.Text);
                db.Update(id_product, name, price, cost);
                CleanFields();
                db.SelectAll(dataGrid);
                ToggleButtons(new int[] {2});
                ToggleTextBoxes(new int[] {});
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            Database db = new Database();
            int id_product = Int32.Parse(inputID.Text);
            db.Delete(id_product);
            CleanFields();
            db.SelectAll(dataGrid);
            ToggleButtons(new int[] {2});
            ToggleTextBoxes(new int[] {});
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void inputName_TextChanged(object sender, EventArgs e) { }
    }
}