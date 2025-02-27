using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    /// <summary>
    /// This is the base class meant to be changedby the derived classes
    /// </summary>
    public class TMB : ITO
    {
        protected List<Task> Tasks = new List<Task>();
        private int taskIDCounter = 1;

        /// <summary>
        /// This is the addTask method which adds a task and has a max of 50, more than 50 might just be torture
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="dueDate"></param>
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

        /// <summary>
        /// This is the update task method where you can of course, update a task
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="newTitle"></param>
        /// <param name="newDescription"></param>
        /// <param name="newDueDate"></param>
        public void UpdateTask(int taskID, string newTitle, string newDescription, DateTime newDueDate)
        {
            try
            {
                Task task = Tasks.Find(t => t.ID == taskID); //finds the task ID from the tasks list
                if (task != null) //if the task is real
                {
                    task.Title = newTitle;
                    task.Description = newDescription; //change all the parts of the task
                    task.DueDate = newDueDate;
                }

                else
                {
                    Console.WriteLine("\nTASK WASN'T FOUND"); //if not then no task is found
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine("Error when updating task: " + ex.Message);//if there was something wrong with the input it will give a message
            }
        }


        /// <summary>
        /// This is the remove task method where you can remove a task!!!!!!!
        /// </summary>
        /// <param name="taskID"></param>
        public void RemoveTask(int taskID)
        {
            try
            {
                Task task = Tasks.Find(t => t.ID == taskID); //find the task in the tasks list
                if (task != null) //if there is a task with that ID
                {
                    Tasks.Remove(task); //use the list .remove to remove the task
                }

                else
                {
                    Console.WriteLine("Task was not Found!!!"); //if not then there is not a task there
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Cannot remove task!: " + ex.Message); //in case there is an issue with the input at any point
            }
        }



        /// <summary>
        /// This marks a task as complete, pretty cool
        /// </summary>
        /// <param name="taskID"></param>
        public void MarkTaskComplete(int taskID)
        {
            try
            {
                Task task = Tasks.Find(t => t.ID == taskID); //find the task in the list
                if (task != null)
                {
                    task.IsCompleted = true; //mark task as complete changing the bool for it
                }
                else
                {
                    Console.WriteLine("Task was not found!");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Cannot mark task complete!: " + ex.Message);
            }
        }

        
    }
}
