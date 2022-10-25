using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace T_ShirtInventoryTracker
{

    public class InventoryManager
    {
        //A list to track the types of shirts.
        private List<Shirt> _List = null;

        public InventoryManager()
        {
            _List = new List<Shirt>();
        }


        //Adds shirt into the list.
        public void AddShirt(Shirt shirt)
        {
            _List.Add(shirt);
        }

        //Removes shirt from the list.
        public void RemoveShirt(Shirt shirt)
        {
            _List.Remove(shirt);
        }

        //Restock a shirt with specified amount.
        public void Restock(int shirtID, int restockAmount)
        {

            SearchShirt(shirtID).Qty += restockAmount;
            
        }


        //Search for shirt by ShirtID
        public Shirt SearchShirt(int shirtID)
        {
            foreach (var shirt in _List)
            {
                if (shirt.ShirtID == shirtID)
                {
                    return shirt;
                }
            }

            return null;
        }


        //Search for shirt by description.
        public Shirt SearchShirt(string description)
        {
            foreach (var shirt in _List)
            {
                if (shirt.Description == description)
                {
                    return shirt;
                }
            }

            return null;
        }



        //Displays all shirts in inventory
        public void OutputInventory()
        {

            foreach (Shirt shirt in _List)
            {
                Console.WriteLine("Shirt " + shirt.ShirtID + " | Description: " + shirt.Description + " | QTY: " + shirt.Qty);

            }


        }

    }





}

