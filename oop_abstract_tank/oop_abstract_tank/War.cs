using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_abstract_tank
{
    internal class War
    {
        public War()
        {

        }

        public bool Round(CombatVehicle bm1, CombatVehicle bm2)
        {
            Console.WriteLine("\t\tROUND\t\t");

            int hp1 = bm1.Health, hp2 = bm2.Health;

            for (int i = 0; hp1 > 0 || hp1 > 0; i++)
            {
                Console.WriteLine($"HP1: {hp1} HP2: {hp2}");

                Console.WriteLine("BM1 attack!");
                hp2 = bm2.Damage(bm1.Attack());
                bm2.SetHealth(hp2);

                if (hp2 <= 0)
                {
                    hp2 = 0;
                    break;
                }

                Console.WriteLine("BM2 attack!");
                hp1 = bm1.Damage(bm2.Attack());
                bm1.SetHealth(hp1);

                if (hp1 <= 0)
                {
                    hp1 = 0;
                    break;
                }
            }

            if (hp1 == 0) {
                Console.WriteLine("BM2 is WIN!");
                return false;
            }
            if (hp2 == 0)
            {
                Console.WriteLine("BM1 is WIN!");
                return true;
            }
            return true;
        }
        public void Fight(CombatVehicle[] a1, CombatVehicle[] a2, int size)
        {
            int hp, a, b, c;
            Random rand= new Random();

            int par1, par2;
            par1 = size / 3;
            for (int i = 0; i < par1; i++)
            {
                hp = rand.Next(100);
                a = rand .Next(30);
                b = rand.Next(30);
                a1[i] = new ArmoredCar("tiger", "yalo", hp, a, b);
                hp = rand.Next(100);
                a = rand.Next(30);
                b = rand.Next(30);
                a2[i] = new ArmoredCar("tiger", "yalo", hp, a, b);
            }
            par2 = par1 * 2;
            for (int i = par1; i < par2; i++)
            {
                hp = rand.Next(100);
                a = rand.Next(30);
                b = rand.Next(30);
                c = rand.Next(100);
                a1[i] = new Tank("bredly", "t-34", hp, a, b,c);
                hp = rand.Next(100);
                a = rand.Next(30);
                b = rand.Next(30);
                c = rand.Next(100);
                a2[i] = new Tank("bredly", "t-34", hp, a, b, c);
            }
            for (int i = par2; i < size; i++)
            {
                hp = rand.Next(100);
                a = rand.Next(30);
                b = rand.Next(30);
                c = rand.Next(10);
                a1[i] = new AirDefenseVehicle("patriot", "up", hp, a, b, c);
                hp = rand.Next(100);
                a = rand.Next(30);
                b = rand.Next(30);
                c = rand.Next(10);
                a2[i] = new AirDefenseVehicle("patriot", "up", hp, a, b, c);
            }

            int rnd1, rnd2;
            int count1 = size, count2 = size;

            for(int i = 0; count1 != 0 && count2 != 0; i++)
            {
                rnd1 = rand.Next(count1);
                rnd2 = rand.Next(count2);

                Console.WriteLine($"Start round #{i+1}");

                Round(a1[rnd1], a2[rnd2]);

                if (a1[rnd1].Health == 0)
                {
                    count1--;
                }
                if (a2[rnd2].Health == 0)
                {
                    count2--;
                }
            }

            if (count1 == 0)
            {
                Console.WriteLine("\n\t\tArmy 2 Win war!\t\t\n");
            }
            if (count2 == 0)
            {
                Console.WriteLine("\n\t\tArmy 1 Win war!\t\t\n");
            }
        }
    }
}
