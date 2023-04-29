using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_abstract_tank
{
    internal class Tank : CombatVehicle
    {
        public int RechargeTime { get; set; }
        public int ShotAccuracy { get; set; }
        public int ArrmorThickness { get; set; }

        public Tank(string type, string model, int health,
            int RechargeTime, int ShotAccuracy, int ArrmorThickness)
            :base(type, model, health)
        { 
            this.RechargeTime = RechargeTime;
            this.ShotAccuracy = ShotAccuracy;
            this.ArrmorThickness = ArrmorThickness;
        }

        public override void ToString()
        {
            base.ToString();
            Console.Write($"Recharge time: {RechargeTime}\n" +
                $"Shot accuracy: {ShotAccuracy}\n" +
                $"Arrmor Thickness: {ArrmorThickness}\n");
        }
        public override int Attack()
        {
            int damage = 0;
            damage = 100 * ShotAccuracy / RechargeTime;
            return damage;
        }
        public override int Damage(int damage)
        {
            if (damage <= ArrmorThickness)
            {
                ArrmorThickness = ArrmorThickness - damage;
                return Health;
            }
            else
            {
                int tmp = (damage - ArrmorThickness);
                Health -= tmp;
                if (Health < 0)
                {
                    Health = 0;
                }
                return Health;
            }
        }

    }
}
