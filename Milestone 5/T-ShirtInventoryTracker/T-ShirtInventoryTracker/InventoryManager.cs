using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        //Returns list of shirts.
        public List<Shirt> GetShirts()
        {
            return _List;
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
                if (shirt.Description.ToLower() == description.ToLower())
                {
                    return shirt;
                }
            }

            return null;
        }



        //Displays all shirts in inventory
        public void OutputInventory(ListBox lb = null)
        {
            if (lb != null)
                lb.Items.Clear();

            foreach (Shirt shirt in _List)
            {
                if (lb != null)
                {
                    lb.Items.Add(shirt);
                }
                else
                {
                    Console.WriteLine(shirt);
                }

            }

        }

    }





}

