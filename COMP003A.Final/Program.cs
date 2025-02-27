//Author: Colby D
//Course: COMP003A
//Faculty: Jonathan Rodrigo Cruz
//Description: Final project for the course COMP003A

using System.Transactions;

namespace COMP003A.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Task Manager: \n 1. Personal \n 2. Work \n 3.Daily ");
            int choice = int.Parse(Console.ReadLine());

            TMB taskManager;
            switch (choice)
            {
                case 1: 
                    taskManager = new PersonalManager(); 
                    break;
                case 2:
                    taskManager = new WorkManager();
                    break;
                case 3:
                    taskManager = new DailyManager();
                    break;
                default:
                    Console.WriteLine("Invalid, defaulting to the Personal Manager");
                    taskManager = new PersonalManager();
                        break;
            }

            while (true)
            {
                Console.WriteLine("|--Menu--|");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Remove");
                Console.WriteLine("4. Mark Complete");
                Console.WriteLine("5. Display");
                Console.WriteLine("6. Exit");

                int option = int.Parse(Console.ReadLine());

                try
                {
                    if (option == 1)
                    {
                        Console.Write("Enter a Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Description: ");
                        string description = Console.ReadLine();
                        Console.WriteLine("Enter the due date (year-mo-da): ");
                        DateTime dueDate = DateTime.Parse(Console.ReadLine());
                        taskManager.AddTask(title, description, dueDate);
                    }

                    else if (option == 2)
                    {
                        Console.WriteLine("Enter the task ID: ");
                        int ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the new title: ");
                        string newTitle = Console.ReadLine();
                        Console.WriteLine("Enter the new description: ");
                        string newDescription = Console.ReadLine();
                        Console.WriteLine("Enter the new Due Date (year-me-da): ");
                        DateTime newDueDate = DateTime.Parse(Console.ReadLine());
                        taskManager.UpdateTask(ID, newTitle, newDescription, newDueDate)
                    }
                }
            }
        }
    }
}
