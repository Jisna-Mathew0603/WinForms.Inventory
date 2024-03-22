using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Inventory
{
    public class InventoryDB
    {
        //Path to the file
        private static readonly string Path = @"C:\Users\JISNA\Downloads\grocery_inventory_items.txt";

        private const string Delimiter = " | ";

        //Getting the items from the file
        public static List<InventoryItem> GetItems()
        {
            List<InventoryItem> items = new List<InventoryItem>();


            using (StreamReader textIn = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIn.ReadLine()) != null)
                {
                    string[] columns = row.Split(Delimiter);


                    if (columns.Length == 3)
                    {
                        InventoryItem item = new InventoryItem
                        {
                            ItemNo = Convert.ToInt32(columns[0]),
                            Description = columns[1],
                            Price = Convert.ToDecimal(columns[2])
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }

        //Saving  items to the file 

        public static void SaveItems(List<InventoryItem> items)
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (InventoryItem item in items)
                {
                    textOut.Write(item.ItemNo + Delimiter);
                    textOut.Write(item.Description + Delimiter);
                    textOut.WriteLine(item.Price);
                }
               
            }
        }

        //Deleting  item from the list and saving the updated list to the file using index
        public static void DeleteItem(int index)
        {
            List<InventoryItem> items = GetItems();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                items.RemoveAt(index);
                SaveItems(items);
            }
            else
            {
                MessageBox.Show("");
            }
        }
    }
}