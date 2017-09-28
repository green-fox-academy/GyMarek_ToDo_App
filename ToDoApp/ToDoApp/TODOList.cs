using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ToDoApp
{
    public class TODOList
    {
        string path = @"./TODO.txt";

        public void ListWrite()
        {
            try
            {
                string[] content;
                content = File.ReadAllLines(path);

                if (content.Length == 0)
                {
                    Console.WriteLine("No todos for today! :)");
                }

                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine((i + 1) + " - " + content[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: TODO.txt");
            }
        }

        public void AddTask(string newTask)
        {

            try
            {
                if (newTask.Equals(string.Empty))
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(path))
                    {
                        writer.WriteLine(newTask);
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: TODO.txt");
            }
        }
    }
}
