using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Final
{
    /// <summary>
    /// This class controls the base variables for all other classes to take 
    /// </summary>
    public class Task
    {
        public int ID {  get; set; } //retrieves ID and sets it

        public DateTime DueDate { get; set; } //retrieves Date and time then sets it 

        public string Title { get; set; } //gets title and sets it

        public string Description { get; set; } // gets desc then sets it

        public bool IsCompleted { get; set; } //gets the is completed bool and sets it 

    }
}
