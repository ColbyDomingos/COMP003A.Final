using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    public class DailyManager : TMB
    {
        public override void DisplayTasks()
        {
            Console.WriteLine("Daily Task List");
            base.DisplayTasks();
        }
    }
}
