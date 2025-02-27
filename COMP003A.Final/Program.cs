//Author: Colby D
//Course: COMP003A
//Faculty: Jonathan Rodrigo Cruz
//Description: Final project for the course COMP003A

using System.Linq.Expressions;
using System.Transactions;

namespace COMP003A.Final
{
    /// <summary>
    /// Connects all the classes together, allows the program to run as well
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Where all the magic happens, connecting the classes into one cool program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Select Task Manager: \n 1. Personal \n 2. Work \n 3. Daily "); // Set which manager the list will run off
            int choice = int.Parse(Console.ReadLine()); //parses a choice into an int

            TMB taskManager; //states that TMB is the task manager
            switch (choice) //switch case statement for the choice
            {
                case 1: 
                    taskManager = new PersonalManager(); //if the choice is 1 then its in the personal manager
                    break;
                case 2:
                    taskManager = new WorkManager(); //if the choice is 2 then its in the work manager
                    break;
                case 3:
                    taskManager = new DailyManager(); //if the choice is 3 then its in the daily manager
                    break;
                default:
                    Console.WriteLine("Invalid, defaulting to the Personal Manager"); //in case none of those were chosen then its invalid and just goes into the personal manager
                    taskManager = new PersonalManager(); //sets it to the personal manager
                      break;
            }

            //This is the loop for menu and all of the different inputs
            while (true)
            {
                Console.WriteLine("\n|--Menu--|");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Remove");  // this is the menu for which options to choose from
                Console.WriteLine("4. Mark Complete");
                Console.WriteLine("5. Display");
                Console.WriteLine("6. Exit");

                int option = int.Parse(Console.ReadLine()); // sets whatever is chosen to the option variable

                try //if there are no errors it will go through this
                {
                    if (option == 1)
                    {
                        Console.Write("Enter a Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Description: ");
                        string description = Console.ReadLine(); 
                        Console.WriteLine("Enter the due date (year-mo-da): ");  // simply is the add task function it gets the inputs and adds them to the addtask method where it gets cycled in
                        DateTime dueDate = DateTime.Parse(Console.ReadLine()); 
                        taskManager.AddTask(title, description, dueDate);
                    }

                    else if (option == 2)
                    {
                        Console.WriteLine("Enter the task ID: ");
                        int ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the new title: ");
                        string newTitle = Console.ReadLine();
                        Console.WriteLine("Enter the new description: ");  //Gets the id for which item to update and then changes the vaiables to whatever is set to new
                        string newDescription = Console.ReadLine();
                        Console.WriteLine("Enter the new Due Date (year-me-da): ");
                        DateTime newDueDate = DateTime.Parse(Console.ReadLine());
                        taskManager.UpdateTask(ID, newTitle, newDescription, newDueDate);
                    }

                    else if (option == 3)
                    {
                        Console.WriteLine("Enter the Task ID: ");
                        int id = int.Parse(Console.ReadLine()); // if it finds the tasks ID it will then remove it from the list with the .remove function
                        taskManager.RemoveTask(id);
                    }

                    else if (option == 4)
                    {
                        Console.WriteLine("Enter the Task ID: ");
                        int id = int.Parse(Console.ReadLine()); // if it finds the ID is will mark the task as comeplete! Yippieeeeeee
                        taskManager.MarkTaskComplete(id);
                    }

                    else if (option == 5)
                    {
                        taskManager.DisplayTasks(); //will display all the tasks that are found to have IDs
                    }

                    else if (option == 6)
                    {
                        break; //exit by breaking the loop and stopping the code
                    }
                }



                catch (Exception ex) //if there is an error
                {
                    Console.WriteLine("Invalid input: " + ex.Message); //it will tell the user of the error
                }
            }
        }
    }
}
