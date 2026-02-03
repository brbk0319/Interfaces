using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Character
    {
        public abstract string Name { get; set; }

        public abstract void Introduce();

    }

    interface IAttack
    {
        void Attack();
        void IsAttacked();
    }

    class Player : Character, IAttack
    {
        public override string Name { get; set;  }

        public Player() { Name = "Player 1"; }
        public override void Introduce()
        {
            Console.WriteLine($"Hello! My name is {Name}");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks!");
        }

        public void IsAttacked()
        {
            Console.WriteLine($"{Name} is attacked!");
        }
    }

    class Enemy : Character, IAttack
    {
        public override string Name { get; set; }
        public Enemy() { Name = "The Dark Lord"; }
        public override void Introduce()
        {
            Console.WriteLine($"Hello! My name is {Name}. FEAR ME!!!!1!");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks! 'DIEEEEE!!!!!' he says.");
        }

        public void IsAttacked()
        {
            Console.WriteLine($"{Name} is attacked! He screams and runs away.");
        }
    }

    class NPC : Character, IAttack
    {
        public override string Name { get; set; }
        public NPC() { Name = "Bob"; }
        public override void Introduce()
        {
            Console.WriteLine($"Hello! My name is {Name}. The weather sure is nice today. Stay away from The Dark Lord!");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks! He swings his sword and ends up in a tree.");
        }

        public void IsAttacked()
        {
            Console.WriteLine($"{Name} is attacked! He tries to run and ends up stuck in the door.");
        }
    }
    





    //interface IMovable
    //{
    //    void Move();
    //}
    //public class Player : IMovable
    //{
    //    public void Move() 
    //    {
    //        Console.WriteLine("Player walks confidently, unafraid.");
    //    }
    //}
    //public class Enemy : IMovable
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Enemy stalks menacingly, ready to pounce.");
    //    }
    //}
    //public class NPC : IMovable
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("NPC glitches and starts walking in the wall.");
    //    }
    //}
}
