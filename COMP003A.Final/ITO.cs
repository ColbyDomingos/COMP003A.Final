using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    public interface ITO
    {
        void AddTask(string title, string description, DateTime dueDate);

        void UpdateTask(int taskID, string newTitle, string newDescription, DateTime newDueDate);

        void RemoveTask(int taskID);

        void MarkTaskCompleted(int taskID);

        void DisplayTasks();
    }
}
