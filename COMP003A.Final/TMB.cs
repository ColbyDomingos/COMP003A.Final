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
    public class TMB : ITO //Pass in the Interface to get all the values from here and set them
    {
        protected List<Task> Tasks = new List<Task>(); //initializes the list for the tasks
        private int taskIDCounter = 1; //sets the task counter to 1 to prevent 0 which would lead to an error

        /// <summary>
        /// This is the addTask method which adds a task and has a max of 50, more than 50 might just be torture
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="dueDate"></param>
        public void AddTask(string title, string description, DateTime dueDate) //passes through all the values to add a task
        {
            try //try to do this process
            {
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description)) //in case both title and description 
                {
                    Console.WriteLine("Invalid Input. Please try once more."); //tell the user "no"
                }
                if (Tasks.Count >= 50) //if there are more than 50 tasks in the list
                {
                    Console.WriteLine("Task List is full! Do some stuff!"); //tell the user to finish the tasks they already have in the list
                    return;
                }

                Task newTask = new Task { ID = taskIDCounter++, Title = title, Description = description, DueDate = dueDate }; //incriment the IDcounter, set the title to the one given, as well as the date and description
                Tasks.Add(newTask); //add the new task to the list
            }

            catch (Exception ex) //in case of an error
            {
                Console.WriteLine("Error when adding task: " + ex.ToString()); //tell the user about the error
            }
        }

        /// <summary>
        /// This is the update task method where you can of course, update a task
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="newTitle"></param>
        /// <param name="newDescription"></param>
        /// <param name="newDueDate"></param>
        public void UpdateTask(int taskID, string newTitle, string newDescription, DateTime newDueDate) //pass through the taskId set in the addtask method, as well as the new title, description, and duedate
        {
            try //try this first if no error is seen.
            {
                Task task = Tasks.Find(t => t.ID == taskID); //finds the task ID from the tasks list
                if (task != null) //if the task is real
                {
                    task.Title = newTitle; 
                    task.Description = newDescription; //change all the parts of the task
                    task.DueDate = newDueDate;
                }

                else //if there is no tasks with that id
                {
                    Console.WriteLine("\nTASK WASN'T FOUND"); //if not then no task is found
                }
            }

            catch(Exception ex) //if there is an error
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

                else //if there is no task with that id
                {
                    Console.WriteLine("Task was not Found!!!"); //if not then there is not a task there
                }
            }

            catch (Exception ex) // if there is an error
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
                if (task != null) //if the task selected is not null
                {
                    task.IsCompleted = true; //mark task as complete changing the bool for it
                }
                else //if the task is null
                {
                    Console.WriteLine("Task was not found!"); //tell the user about it and hope they can fix it
                }
            }

            catch (Exception ex) //if there is an error
            {
                Console.WriteLine("Cannot mark task complete!: " + ex.Message); //tell the user about it
            }
        }

        /// <summary>
        /// Displays all the tasks in the list
        /// </summary>
        public virtual void DisplayTasks()
        {
            if(Tasks.Count == 0) //if there are no tasks set yet
            {
                Console.WriteLine("No tasks available"); // say no tasks available
            }

            else //if there IS tasks in the list
            {
                foreach (var task in Tasks) //for every task in the list tasks
                {
                    Console.WriteLine("ID: " + task.ID + ", Title: "  + task.Title + ", Due: " + task.DueDate + ", Completed: " + task.IsCompleted); //Display all tasks and their respective descriptions and such
                }
            }
        }
    }
}
