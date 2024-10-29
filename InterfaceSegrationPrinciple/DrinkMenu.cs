using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple
{
    class DrinkMenu : IDrinkMenu
    {
        public List<string> GetDrinkItems()
        {
            return new List<string> { "water", "soda", "juice" };
        }
        void DisplayVegeterianMenu(IVegeterianMenu menu)
        {
            Console.WriteLine("Vegeterian menu");
            foreach (var item in menu.GetVegeterianItems())
            {
                Console.WriteLine(item);
            }
        }
        void DisplayNonVegeterianMenu(INonVegeterianMenu menu)
        {
            Console.WriteLine("Non-Vegeterian menu");
            foreach (var item in menu.GetNonVegeterianItems())
            {
                Console.WriteLine(item);
            }
        }
       
    }
}