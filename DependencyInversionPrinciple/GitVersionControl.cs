using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class GitVersionControl : IVersionControl
    {
        public void commit(string message)
        {
            Console.WriteLine("committing chages to git"+ message);
        }

        public void pull()
        {
            Console.WriteLine("pulling changes to remote git repository");
        }

        public void push()
        {
            Console.WriteLine("pushing changes to remote git repository");

        }
    }
}
