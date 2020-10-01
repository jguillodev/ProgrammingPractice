using System;
using System.IO;

namespace LearningSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\joshu\Desktop\DI");
            string path = (@"C:\Users\joshu\Desktop\DI\di.txt");

            if (!File.Exists(path))
            {
                //Create a file to write to 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }

              
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }


            try
            {
                if (di.Exists)
                {
                    Console.WriteLine("That path exist already.");
                    return;
                }
                else
                {
                    //Try to create the directory
                    di.Create();
                    Console.WriteLine("The directory was created successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }

          
        }
    }
}
