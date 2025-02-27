using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    /// <summary>
    /// This is the interface for all the task operations that are possible.
    /// </summary>
    public interface ITO //Interface Task Organizer 
    {
        void AddTask(string title, string description, DateTime dueDate); //gets the inputs for AddTask

        void UpdateTask(int taskID, string newTitle, string newDescription, DateTime newDueDate); //Gets the inputs for Updating Tasks

        void RemoveTask(int taskID); // Gets the inputs for Removinv Tasks

        void MarkTaskComplete(int taskID); // Gets the input for Marking Tasks Complete

        void DisplayTasks(); // makes a method to be overrode
    }
}
