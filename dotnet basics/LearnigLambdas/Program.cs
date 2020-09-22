using System;

namespace LearnigLambdas
{
    class Program
    {
        public delegate string GreetingsDelegate(string name);
        static void Main(string[] args)
        {
            //Different ways of decelaring a delegate
            GreetingsDelegate del1 = new GreetingsDelegate(Greetings);
            GreetingsDelegate del2 = Greetings;
            GreetingsDelegate del3 = delegate (string name) 
            {
                return "Hello @" + name + " welcome to Dotnet Tutorials this is an Anonymous Function";
            };

            GreetingsDelegate del4 = (theName) => 
            {
                return "Hello @" + theName + " welcome to DotNet Tutorials"; 
            };

            string GreetingMsg = del1.Invoke("Pranaya");
            string GreetingMsg2 = del2("Pranaya");
            string GreetingMsg3 = del3("Pranaya");
            string GreetingMsg4 = del4.Invoke("This Name Lambda");

            Console.WriteLine(GreetingMsg);
            Console.WriteLine(GreetingMsg2);
            Console.WriteLine(GreetingMsg3);
            Console.WriteLine(GreetingMsg4);


        }

        public static string Greetings(string name) 
        {
            return "Hello @" + name + " welcome  to DotNet Tutorials";
        }
    }
}
