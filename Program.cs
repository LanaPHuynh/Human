using System;

namespace Human
{
    partial class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Bob = new Human("Bob");
            Human Jim = new Human("Jim", 5, 5, 5, 200);
            Console.WriteLine(Bob.Dexterity);
            Console.WriteLine(Jim.Health);
            Bob.Attack(Jim);
            Console.WriteLine(Jim.Health);
        }
    }
}
