using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    /// <summary>
    /// Derived class for daily tasks
    /// </summary>
    public class DailyManager : TMB //Passes through the base, makes this another derived class
    {
        public override void DisplayTasks() //affects display task
        {
            Console.WriteLine("Daily Task List"); //simply display the tasks for the selected manager
            
            base.DisplayTasks(); //changes base display task
        }
    }
}
