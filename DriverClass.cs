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
            Inventory inventory = new Inventory();

            //Create shirt objects to populate inventory
            Shirt shirt1 = new Shirt() { ShirtID = 1121, Description = "GCU Standard", Qty = 100 };
            Shirt shirt2 = new Shirt() { ShirtID = 7813, Description = "GCU Basketball", Qty = 50};
            Shirt shirt3 = new Shirt() { ShirtID = 9898, Description = "GCU Softball", Qty = 20};
            Shirt shirt4 = new Shirt() { ShirtID = 2341, Description = "GCU Soccer", Qty = 5};
            Shirt shirt5 = new Shirt() { ShirtID = 5821, Description = "GCU E-Sports", Qty = 404 };
            
            //Test adding shirts
            inventory.addShirt(shirt1);
            inventory.addShirt(shirt2);
            inventory.addShirt(shirt3);
            inventory.addShirt(shirt4);
            inventory.addShirt(shirt5);


            Console.WriteLine("Number of shirts in inventory after adding: " + inventory.getInventoryCount());



            //Test removing a shirt.
            inventory.removeShirt(shirt3);
            inventory.removeShirt(shirt4);

            Console.WriteLine("Number of shirts in inventory after removing: " + inventory.getInventoryCount());


            Shirt gotShirt = inventory.getShirtAtIndex(0);
            Console.WriteLine("Got Shirt with ShirtID: " + gotShirt.ShirtID);

            //Show current inventory
            inventory.OutputInventory();


            //Wait for user to end program.
            Console.ReadKey();


        }
    }
}
