using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    public class PersonalManager : TMB // passes with the task manager base to make it a derived class
    {
        /// <summary>
        /// The manager for personal tasks, you might say it could also be daily but I don't think so
        /// </summary>
        public override void DisplayTasks() //overrides the display task method
        {
            Console.WriteLine("Personal Task List"); //simply display the tasks for the selected manager
            base.DisplayTasks(); //changes the display task method
        }
    }
}
