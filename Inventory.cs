using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace T_ShirtInventoryTracker
{

    public class Inventory
    {
        //A list to track the types of shirts.
        private List<Shirt> list = null;

        public Inventory()
        {
            list = new List<Shirt>();
        }

       
        //Adds shirt into the list.
        public void addShirt(Shirt shirt)
        {
            list.Add(shirt);
        }

        //Removes shirt from the list.
        public void removeShirt(Shirt shirt)
        {
            list.Remove(shirt);
        }

        //Returns the shirt at the spefied index.
        public Shirt getShirtAtIndex(int index)
        {
            if (index >= list.Count)
            {
                return null;
            }

            return list[index];
        }


        //Returns the number of type of shirts in the list.
        public int getInventoryCount()
        {
            return list.Count;
        }

        //Outputs all shirts in the inventory.
        public void OutputInventory()
        {

            foreach (Shirt shirt in list)
            {
                Console.WriteLine("Shirt " + shirt.ShirtID + " | Description: " + shirt.Description + " | QTY: " + shirt.Qty);

            }

            
        }

    }


    //This will be in it's own file eventually. Wanted to keep only one file per this mileston requirements.
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

