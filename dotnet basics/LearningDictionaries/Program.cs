using System;
using System.Collections.Generic;

namespace LearningDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> config = new Dictionary<string,string>();

            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebsite");

            Console.WriteLine(config["title"]);

            foreach (var setting in config)
            {
                Console.WriteLine(setting.Value);
            }
        }
    }
}
