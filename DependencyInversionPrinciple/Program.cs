using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            GitVersionControl git = new GitVersionControl();
            DevelopmentTeam team = new DevelopmentTeam(git);
            team.MakeCommit("initial commit");
            team.PerformPush();
            team.PerformPull();
            Console.ReadLine();
        }
    }
}
