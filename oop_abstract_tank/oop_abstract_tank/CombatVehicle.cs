using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop_abstract_tank
{
    public class CombatVehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int Health { get; set; }

        public CombatVehicle(string type, string model, int health)
        {
            this.Type = type;
            this.Model = model;
            this.Health = health;
        }

        public void SetHealth(int hp)
        {
            Health = hp;
        }
        public bool IsDestroyed()
        {
            if (Health == 0)
            {
                return true;
            }
            return false;
        }
        public virtual void ToString()
        {
            Console.Write("\n\t\tCombatVehicle\t\t\n");
            Console.Write($"Type: {Type}\nModel: {Model}\nHealth: {Health}\n");
        }
        public virtual int Attack()
        {
            return 0;
        }
        public virtual int Damage(int damage)
        {
            return 0;
        }
    }
}
