using System;

namespace Human
{
    partial class Program
    {
        class Human
        {
            // Fields for Human
            public string Name;
            public int Strength = 3;
            public int Intelligence = 3;
            public int Dexterity = 3;
            private int health = 100;
            
            // add a public "getter" property to access health
            public int Health
            {
                get { return health; }
            }
            
            // Add a constructor that takes a value to set Name, and set the remaining fields to default values
            public Human(string name)
            {
                Name = name;
            }
            
            // Add a constructor to assign custom values to all fields
            public Human(string name, int strength, int intelligence, int dexterity, int hp)
            {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                health = hp;
            }
            
            // Build Attack method
            public int Attack(Human target)
            {
                int damage = Strength * 5;
                Console.WriteLine($"{target.Name} has been attacked by {Name}!"); 
                Console.WriteLine($"{target.Name}'s strength has depleted by {damage}");
                target.health -= damage;
                return target.health;
            }
        }

    }
}
