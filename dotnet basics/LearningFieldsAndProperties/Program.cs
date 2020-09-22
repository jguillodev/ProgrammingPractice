using System;

namespace LearningFieldsAndProperties
{
    class Player 
    {
        public bool IsAlive 
        {
            get { return Health > 0; }
        }
        //int health = 100;

        //public int Health 
        //{
        //    get { return health; }
        //}

        public int Health { get; private set; } = 100;
        public void Hit()
        {
            Random r = new Random();
            Health -= r.Next(5, 50);
        }
       

    }

    class Program
    {
        static void Main(string[] args)
        {

           
            Player player = new Player();

          
            for (int i = 0; i < 20; i++) 
            {
                player.Hit();
                Console.WriteLine("Is player alive: " + player.IsAlive);
            }
        }
    }
}
