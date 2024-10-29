/* Single Responsibility Principle--> This principle states that "A class should have only one reason to change"
                                   which means every clas should have  single responsibility or single job or single purpose */


using System;

namespace SolidPrinciplesInC_
{
    class BreadBaker
    {
        public void bakeBreak()
        {
            Console.WriteLine("baking high quality bread");
        }
    }
    class InventoryManager
    {
        public void manageInventory()
        {
            Console.WriteLine("Manage all the inventories");
        }
    }
    class SupplyOrder
    {
        public void orderSupplies()
        {
            Console.WriteLine("ordering supplies");
        }
    }
    class CustomerService
    {
        public void serviceCustomer()
        {
           Console.WriteLine("servicing customer");
        }
    }
    class BakeryCleaner
    {
        public void cleanBakery()
        {
            Console.WriteLine("Bakery is Cleaning");
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            BreadBaker bk=new BreadBaker();
            InventoryManager im = new InventoryManager();
            SupplyOrder so = new SupplyOrder();
            CustomerService cs = new CustomerService();
            BakeryCleaner bc = new BakeryCleaner();

            // each class focus on its specific responsiblity
            
            bk.bakeBreak();
            im.manageInventory();
            so.orderSupplies();
            cs.serviceCustomer();
            bc.cleanBakery();
            Console.ReadLine();

        }
    }
}
