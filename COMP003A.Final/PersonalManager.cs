using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    internal class PersonalManager : TMB
    {
        public override void DisplayTasks()
        {
            Console.WriteLine("Personal Task List");
            base.DisplayTasks();
        }
    }
}
