using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_ShirtInventoryTracker
{
    /// <summary>
    /// To test the inventory class.
    /// </summary>
    internal class DriverClass
    {
        
        static void Main(string[] args)
        {
            //Create an instance of inventory to test against.
            InventoryManager inventory = new InventoryManager();

            //Create shirt objects to populate inventory
            Shirt shirt1 = new Shirt() { ShirtID = 1121, Description = "GCU Standard", Qty = 100 };
            Shirt shirt2 = new Shirt() { ShirtID = 7813, Description = "GCU Basketball", Qty = 50};
            Shirt shirt3 = new Shirt() { ShirtID = 9898, Description = "GCU Softball", Qty = 20};
            Shirt shirt4 = new Shirt() { ShirtID = 2341, Description = "GCU Soccer", Qty = 5};
            Shirt shirt5 = new Shirt() { ShirtID = 5821, Description = "GCU E-Sports", Qty = 404 };
            
            //Test adding shirts
            inventory.AddShirt(shirt1);
            inventory.AddShirt(shirt2);
            inventory.AddShirt(shirt3);
            inventory.AddShirt(shirt4);
            inventory.AddShirt(shirt5);

            //Output current inventory to see add.
            Console.WriteLine("\nThe following is the current Shirt Inventory after adding:");
            inventory.OutputInventory();


            //Test removing a shirt.
            inventory.RemoveShirt(shirt3);
            inventory.RemoveShirt(shirt4);

            //Output current inventory to see remove.
            Console.WriteLine("\nThe following is the current Shirt Inventory after removing:");
            inventory.OutputInventory();

            Console.WriteLine();

            //Test searching by ShirtID
            Shirt searchShirt1 = inventory.SearchShirt(5821);
            
            //Should find shirt.
            if (searchShirt1 != null)
                Console.WriteLine("Found shirt with ShirtID: " + searchShirt1.ShirtID);
            else
            {
                Console.WriteLine("Error - Search did not find shirt with specified ShirtID");
            }


            //Test searching by Description
            Shirt searchShirt2 = inventory.SearchShirt("GCU E-Sports");


            //Should find shirt.
            if (searchShirt2 != null)
                Console.WriteLine("Found shirt with Description: " + searchShirt2.Description);
            else
            {
                Console.WriteLine("Error - Search did not find shirt with specified Description");
            }


            //Test restocking remaining shirts.
            inventory.Restock(1121, 10);
            inventory.Restock(7813, 100);
            inventory.Restock(5821, 1000);

            //Output current inventory to see restocking.
            Console.WriteLine("\nThe following is the current Shirt Inventory after restocking:");
            inventory.OutputInventory();


            //Wait for user to end program.
            Console.ReadKey();


        }
    }
}
