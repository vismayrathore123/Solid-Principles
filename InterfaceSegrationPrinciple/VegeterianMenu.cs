using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple
{
     class VegeterianMenu:IVegeterianMenu
    {
        public List<string> GetVegeterianItems()
        {
            return new  List<string> {"Panner Tikka","Fried Rice","Aalu Paratha" };
        }

    
    }
}
