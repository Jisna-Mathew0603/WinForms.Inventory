using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Inventory
{
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {

            // Check if any of the input fields are empty.
            if (string.IsNullOrWhiteSpace(ItemNumbertxt.Text) || string.IsNullOrWhiteSpace(pricetxt.Text) || string.IsNullOrWhiteSpace(Desctxt.Text))
            {
                MessageBox.Show("Please fill in all fields."); // Display a message box prompting to fill all fields.
            }
            else
            {
                // Parse the item number from the text box.
                if (!int.TryParse(ItemNumbertxt.Text, out int itemNo))
                {
                    MessageBox.Show("Invalid item number entered. Please enter a valid integer."); // Display a message box for invalid item number.
                }
                // Parse the price from the text box.
                else if (!decimal.TryParse(pricetxt.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price entered. Please enter a valid digit."); // Display a message box for invalid price.
                }
                else
                {
                    // Create a new InventoryItem object with the entered values.
                    InventoryItem item = new InventoryItem(itemNo, Desctxt.Text, price);

                    // Retrieve existing items from the database.
                    List<InventoryItem> items = InventoryDB.GetItems();

                    // Add the new item to the list of items.
                    items.Add(item);
                    // Save the updated list of items to the database.
                    InventoryDB.SaveItems(items);

                    // Close the form.
                    this.Close();
                }
            }

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
