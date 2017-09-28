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
    }
}
