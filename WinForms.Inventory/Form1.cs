namespace WinForms.Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            listBox1Inventory.Items.Clear();
            List<InventoryItem> items = InventoryDB.GetItems();
            foreach (InventoryItem item in items)
            {
                listBox1Inventory.Items.Add(item);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //Open the AddInventory form add Add the operations
            AddInventory addInventory = new AddInventory();
            addInventory.ShowDialog();
            RefreshList();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            //button will exit
            this.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //Delete the selected item from the list
            int selectedIndex = listBox1Inventory.SelectedIndex;
            if (listBox1Inventory.SelectedIndex != -1)
            {
                InventoryDB.DeleteItem(selectedIndex);
                RefreshList();
                MessageBox.Show(" The selected item  deleted successfully");
            }
            else
            {
                MessageBox.Show("Please select an item to delete", "Error");
            }
        }


        private void listBox1Inventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
