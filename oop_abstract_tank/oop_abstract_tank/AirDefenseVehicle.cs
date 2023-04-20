using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_abstract_tank
{
    internal class AirDefenseVehicle : CombatVehicle
    {
        public int Range { get; set; }
        public int RateFire { get; set; }
        public int Mobility { get; set; }

        public AirDefenseVehicle(string type, string model, int health,
            int Range, int RateFire, int Mobility)
            : base(type, model, health)
        {
            this.Range = Range;
            this.RateFire = RateFire;
            this.Mobility = Mobility;
        }

        public override void ToString()
        {
            base.ToString();
            Console.Write($"Range: {Range}\n" +
                $"Rate fire: {RateFire}\n" +
                $"Mobility: {Mobility}\n");
        }
        public override int Attack()
        {
            int damage = 150 + Range * (RateFire / 10);
            return damage;
        }
        public override int Damage(int damage)
        {
            Health = Health - (damage / Mobility);
            if (Health < 0) { Health = 0; }
            return Health;
        }
    }
}
