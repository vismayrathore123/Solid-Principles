using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
   interface IVersionControl
    {
        void commit(string message);
        void push();
        void pull();
    }
}
