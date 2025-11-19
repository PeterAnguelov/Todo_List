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
            // loops until exited
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

            Console.Write(Environment.NewLine + "Pick a option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            

            return option;
        }

        // This decides what tasks to perform based on option selected
        static void OptionPerformer(int option) 
        {
            int index;
            switch (option)
            {
                case 1:
                    tasks.Add(AddNewTask());
                    break;
                case 2:
                    CurrentTasks();
                    Console.ReadLine();

                    break;
                case 3:
                    index = CompleteTask() - 1;
                    tasks[index] = tasks[index] + " (Completed)";

                    break;
                case 4:
                    index = RemoveTask() - 1;
                    tasks.RemoveAt(index);

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

        // 1. Add a new task
        static string AddNewTask()
        {
            Console.Write("Please task: ");
            string task = Console.ReadLine();

            return task;
        }

        // 2. Show tasks
        static void CurrentTasks()
        {
            Console.Clear();
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        // 3. Complete a Task
        static int CompleteTask()
        {
            CurrentTasks();
            Console.Write("Enter which task you would like to complete: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        // 4. Remove Task
        static int RemoveTask()
        {
            CurrentTasks();
            Console.Write("Enter which task you would like to remove: ");

            return Convert.ToInt32(Console.ReadLine());
        }

    }
}

/*
When the user selects an option depending on the option it will perform the right thing. 
Still deciding if I must put it in the Main class
*/
