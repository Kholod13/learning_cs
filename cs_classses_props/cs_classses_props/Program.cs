using System.Reflection;

namespace _cs_classes_props
{
    internal class Program
    {
        public class Phone
        {
            private static double inches;
            private string color;
            private int battery;
            private static double cameraMegaPixels;
            private readonly string company;

            public static double Inches { get { return inches; } set { inches = value; } }
            public string Color { get { return color; } set { color = value; } }
            public int Battery { get { return battery;} set { battery = value; } }
            public int BatteryPower { get; set ; }
            public static double CameraMegaPixels { get { return cameraMegaPixels; } set { cameraMegaPixels = value; } }
            public string Company { get { return company;} }
            public bool Power { get; set; }

            public Phone(double inches, string color, int battery, double cameraMegaPixels, string company)
            {
                Inches = inches;
                Color = color;
                Battery = battery;
                CameraMegaPixels = cameraMegaPixels;
                this.company = company;
                BatteryPower = battery;
            }

            static Phone() { 
                Inches= 0;
                CameraMegaPixels = 0;
            }
            public Phone(string company)
            {
                Inches = 0;
                Color = "";
                Battery = 0;
                CameraMegaPixels = 0;
                this.company = company;
            }
            public void PowerPhone() {
                if (Power == false) {
                    Power= true;
                    Console.WriteLine("Your phone is ON!");
                }
                else
                {
                    Power = false;
                    Console.WriteLine("Your phone is OFF!");
                }
            }

            public void TakePhoto() {
                Console.WriteLine("Photo done!");
            }
            public void UsePhone()
            {
                Console.Write("Input number minutes using >> ");
                int min = int.Parse(Console.ReadLine());

                int p = min / 6;

                int a = BatteryPower / 100 * p;

                BatteryPower = BatteryPower - a;
                Console.WriteLine($"{BatteryPower}mah left, with({Battery})");
            }
            public void EditBattery(ref int value)
            {
                Battery = value;
            }

        }
        void Main(string[] args)
        {
            Phone[] phone =
            {
                new Phone("Xiaomi"),
                new Phone("Apple"),
                new Phone("Huawei"),
                new Phone("Samsung"),
                new Phone("Nokia"),
            };
        }
    }
}