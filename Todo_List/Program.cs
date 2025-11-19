using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List
{
    internal class Program
    {
        static List<string> tasks = new List<string>();
        static void Main(string[] args)
        {
            int option = -1;
            while (option != 9)
            {
                option = OptionSelector();
                OptionPerformer(option);
            }
        }

        // Prints out options and returns one of the selected options
        static int OptionSelector()
        {
            Console.Clear();
            string[] options = new string[] 
            { 
                "1. Add a new task",
                "2. Complete a Task",
                "3. Remove Task",
                "4. Show tasks",
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

            Console.Write(Environment.NewLine + "Pick a option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            

            return option;
        }

        // This decides what tasks to perform based on option selected
        static void OptionPerformer(int option) 
        {
            switch (option)
            {
                case 1:
                    tasks.Add(AddNewTask());
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    CurrentTasks();
                    Console.ReadLine();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    break;
            }
        }

        static string AddNewTask()
        {
            Console.Write("Please task: ");
            string task = Console.ReadLine();

            return task;
        }

        static void CurrentTasks()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}

/*
When the user selects an option depending on the option it will perform the right thing. 
Still deciding if I must put it in the Main class
*/
