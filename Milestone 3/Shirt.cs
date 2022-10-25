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
    }


}
