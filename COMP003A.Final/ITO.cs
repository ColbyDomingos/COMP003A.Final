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
    public interface ITO
    {
        void AddTask(string title, string description, DateTime dueDate);

        void UpdateTask(int taskID, string newTitle, string newDescription, DateTime newDueDate);

        void RemoveTask(int taskID);

        void MarkTaskComplete(int taskID);

        void DisplayTasks();
    }
}
