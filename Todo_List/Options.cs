using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List
{
    internal class Options
    {
        public int Option {  get; set; }

        public Options(int option)
        {
            Option = option;
        }
        
        // Prints out options and returns one of the selected options
        public void OptionPrinter()
        {
            Console.Clear();
            string[] options = new string[]
            {
                "1. Add a new task",
                "2. Show tasks",
                "3. Complete a Task",
                "4. Remove Task",
                "5. Create task Group",
                "6. Add task to Group",
                "7. Remove task from Group",
                "8. Remove Group",
                "9. Exit"
            };

            foreach (string item in options)
            {
                Console.WriteLine(item);
            }
        }

        public int OptionSelector(int option)
        {
            Console.Write(Environment.NewLine + "Pick a option: ");
            option = Convert.ToInt32(Console.ReadLine());

            return option;
        }
    }
}
