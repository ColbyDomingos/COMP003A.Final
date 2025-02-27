﻿using System;
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
    }
}
