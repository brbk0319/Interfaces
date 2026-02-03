using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    interface IMovable
    {
        void Move();
    }
    public class Player : IMovable
    {
        public void Move() 
        {
            Console.WriteLine("Player walks confidently, unafraid.");
        }
    }
    public class Enemy : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Enemy stalks menacingly, ready to pounce.");
        }
    }
    public class NPC : IMovable
    {
        public void Move()
        {
            Console.WriteLine("NPC glitches and starts walking in the wall.");
        }
    }
}
