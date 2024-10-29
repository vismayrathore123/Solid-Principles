using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple
{
    class NonVegeterianMenu : INonVegeterianMenu
    {
        public List<string> GetNonVegeterianItems()
        {
            return new List<string> { "Fish Curry", "Beaf", "Pork" };
        }
    }
}
