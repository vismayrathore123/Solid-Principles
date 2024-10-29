using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class DevelopmentTeam
    {
        private readonly IVersionControl versionControl;

        public DevelopmentTeam(IVersionControl versionControl)
        {
            this.versionControl = versionControl;
        }
        public void MakeCommit(string message)
        {
            versionControl.commit(message);
        }
        public void PerformPush()
        {
            versionControl.push();
        }
        public void PerformPull()
        {
            versionControl.pull();
        }
    }
}
