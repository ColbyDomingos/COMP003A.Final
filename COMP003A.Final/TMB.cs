using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    public class TMB : ITO
    {
        protected List<Task> Tasks = new List<Task>();
        private int taskIDCounter = 1;

        public void AddTask(string title, string description, DateTime dueDate)
        {
            try
            {
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
                {
                    Console.WriteLine("Invalid Input. Please try once more.");
                }
                if (Tasks.Count >= 50)
                {
                    Console.WriteLine("Task List is full! Do some stuff!");
                    return;
                }

                Task newTask = new Task { ID = taskIDCounter++, Title = title, Description = description, DueDate = dueDate };
                Tasks.Add(newTask);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error when adding task: " + ex.ToString());
            }
        }


        public void UpdateTask(int taskID, string newTitle, string newDescription, DateTime newDueDate)
        {
            try
            {
                Task task = Tasks.Find(t => t.ID == taskID);
                if (task != null)
                {
                    task.Title = newTitle;
                    task.Description = newDescription;
                    task.DueDate = newDueDate;
                }

                else
                {
                    Console.WriteLine("\nTASK WASN'T FOUND");
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine("Error when updating task: " + ex.Message);
            }
        }


        public void RemoveTask(int taskID)
        {
            try
            {
                Task task = Tasks.Find(t => t.ID == taskID);
                if (task != null)
                {
                    Tasks.Remove(task);
                }

                else
                {
                    Console.WriteLine("Task was not Found!!!");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Cannot remove task!: " + ex.Message);
            }
        }



        
    }
}
