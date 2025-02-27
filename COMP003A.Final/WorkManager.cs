using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    public class WorkManager : TMB
    {
        public override void DisplayTasks()
        {
            Console.WriteLine("Work Task List");
            base.DisplayTasks();
        }
    }
}
