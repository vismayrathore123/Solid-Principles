/* InterfaceSegrationPrinciple --> It states that "do not force any client to implement an interface which is irrelevant to them."
                                   ex=> Suppose if you enter a restaurant and you are pure vegeterin. The waiter in that restaurant
                                        give you them menu card which includes vegeterian items, non-vegeterian items, drinks and sweets.
 
 */

using System;

namespace InterfaceSegrationPrinciple
{
     class Program
    {
        static void Main(string[] args)
        {
            var vegMenu = new VegeterianMenu();
            var nonvegMenu= new NonVegeterianMenu();
            var drinkMenu= new DrinkMenu();
            DisplayVegeterianMenu(vegMenu);
            DisplayNonVegeterianMenu(nonvegMenu);
            Console.ReadLine();
        }
        static void DisplayVegeterianMenu(IVegeterianMenu menu)
        {
            Console.WriteLine("vegeterian menu");
            foreach (var item in menu.GetVegeterianItems())
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayNonVegeterianMenu(INonVegeterianMenu menu)
        {
            Console.WriteLine("Non-vegeterian menu");
            foreach (var item in menu.GetNonVegeterianItems())
            {
                Console.WriteLine(item);
            }
        }
           
    }
}
