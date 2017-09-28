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

                foreach (string line in content)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: TODO.txt");                
            }
        }
    }
}
