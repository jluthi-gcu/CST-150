using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_ShirtInventoryTracker
{
    public class Shirt
    {
        public int ShirtID { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        public override string ToString()
        {
            return "ShirtID: " + this.ShirtID + " | Description: " + this.Description + " | QTY: " + this.Qty;
        }

        public string ToStringLong()
        {
            return "ShirtID: " + this.ShirtID + " | Description: " + this.Description + " | Gender: " + this.Gender + " | Color: " + this.Color + " | Size: " + this.Size + " | Price: $" + this.Price + " | QTY: " + this.Qty;
        }
    }


}
