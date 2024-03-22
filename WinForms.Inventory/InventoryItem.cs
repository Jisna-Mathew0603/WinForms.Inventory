using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForms.Inventory
{

    // This class represents an inventory item with properties such as ItemNo, Description, and Price.
    public class InventoryItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public InventoryItem() 
        {

        }

        // Assigning values to the properties.
        public InventoryItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }
       // Overrides the ToString method to represent the InventoryItem as a string.
        public override string ToString()
        {
            return $"{ItemNo}|{Description}|{Price}";
        }
    }
}
