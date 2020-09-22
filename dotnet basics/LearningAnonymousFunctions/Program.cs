using System;

namespace LearningAnonymousFunctions
{
    class Program
    {
        public delegate string GreetingsDelegate(string name);

        static void Main(string[] args)
        {
            GreetingsDelegate gdel = delegate (string name)
            {
                return "Hello @" + name + "Welcome to Dotnet Tutorials"; 
            };

            string GreetingsMessage = gdel.Invoke("Pranaya");

            Console.WriteLine(GreetingsMessage);
        }
    }
}
