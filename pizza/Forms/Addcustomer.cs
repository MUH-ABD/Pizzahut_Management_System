using MySql.Data.MySqlClient;
using pizza.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace pizza.Forms
{
    public partial class Addcustomer : Form
    {
        public Addcustomer()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

            private void Addcustomer_Load(object sender, EventArgs e)
        {
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; port=3307;user id=root;password=1234;database=pizza_order_db;";

            string customerName = txtcustomername.Text.Trim();
            string phoneNo = txtphoneno.Text.Trim();
            string pizzaName = txtpizzaname.Text.Trim();
            string salad = txtsalad.Text.Trim();
            string coldDrink = txtdrink.Text.Trim();

            // Validation for required fields
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNo))
            {
                MessageBox.Show("Please enter Customer Name and Phone No.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse decimal values
            if (!decimal.TryParse(txtgovttax.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal govttax))

            {
                MessageBox.Show("Please enter a valid number for Govt Tax.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txttotal.Text.Trim(), out decimal total))
            {
                MessageBox.Show("Please enter a valid number for Total.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Customers (CustomerName, PhoneNo, PizzaName, Salad, ColdDrink, GovtTax, Total) " +
                           "VALUES (@CustomerName, @PhoneNo, @PizzaName, @Salad, @ColdDrink, @GovtTax, @Total)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@CustomerName", customerName);
                        cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
                        cmd.Parameters.AddWithValue("@PizzaName", pizzaName);
                        cmd.Parameters.AddWithValue("@Salad", salad);
                        cmd.Parameters.AddWithValue("@ColdDrink", coldDrink);
                        cmd.Parameters.AddWithValue("@GovtTax", govttax);
                        cmd.Parameters.AddWithValue("@Total", total);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void ClearFields()
        {
            txtcustomername.Text = "";
            txtphoneno.Text = "";
            txtpizzaname.Text = "";
            txtsalad.Text = "";
            txtdrink.Text = "";
            label69.Text = "";
            label9.Text = "";
        }
    }
}
