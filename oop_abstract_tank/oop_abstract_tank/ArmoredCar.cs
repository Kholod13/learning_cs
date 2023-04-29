using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_abstract_tank
{
    internal class ArmoredCar : CombatVehicle
    {
        public int NumberWeapons { get; set; }
        public int Speed { get; set; }

        public ArmoredCar(string type, string model, int health,
           int NumberWeapons, int Speed)
           : base(type, model, health)
        {
            this.NumberWeapons= NumberWeapons;
            this.Speed = Speed;
        }

        public override void ToString()
        {
            base.ToString();
            Console.Write($"Number weapons: {NumberWeapons}\n" +
               $"Speed: {Speed}\n");
        }

        public override int Attack()
        {
            int damage = 50 * NumberWeapons;
            return damage;
        }
        public override int Damage(int damage)
        {
            damage = damage - Speed / 2;
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
            return Health;
        }
    }
}
