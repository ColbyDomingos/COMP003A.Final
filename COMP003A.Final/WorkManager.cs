using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    /// <summary>
    /// The manager for the work tasks
    /// </summary>
    public class WorkManager : TMB //Passes with the Task Manager Base, makes it a derived class
    {
        public override void DisplayTasks()  //overrides the displaytask method
        {
            Console.WriteLine("Work Task List"); //simply display the tasks for the selected manager
            base.DisplayTasks();// changes the display task method
        }
    }
}
