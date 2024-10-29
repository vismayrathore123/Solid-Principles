using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple
{
    internal interface INonVegeterianMenu
    {
        List<string> GetNonVegeterianItems();
    }
}
