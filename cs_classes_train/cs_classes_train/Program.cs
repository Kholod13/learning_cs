



using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _cs_classes_train
{
    enum Type
    {
        cargo,
        passengers,
    }
    struct Car
    {
        public int number;
        public Type type;
        public int numPlaces;
        public int numPassengers;
    }
    class Train
    {
        private readonly int number;
        private Type type;
        private Car car;
        private string nameWay;
        private DateTime dateDispatch;
        private DateTime timeArrival;

        public readonly int Number;
        public Type Type { get { return type; } set { type = value; } }
        public Car Car { get { return car; } set { car = value; } }
        public string NameWay { get { return nameWay; } set { nameWay = value; } }
        public DateTime DateDispatch { get { return dateDispatch; } set { dateDispatch = value; } } 
        public DateTime TimeArrival { get { return timeArrival; } set { timeArrival = value; } }

        public Train(int n, int numPlaces, int numPassengers, string nameWay, int numDaysArrival, int numCars)
        {
            this.number = n;
            type = Type.passengers;
            car.number = numCars;
            car.type = Type.passengers;
            car.numPlaces = numPlaces;
            car.numPassengers = numPassengers;
            this.nameWay = nameWay;
            dateDispatch = DateTime.Now;
            timeArrival = dateDispatch.AddDays(numDaysArrival);
        }

        public void CreateNewWay()
        {
            Console.Write("Input new way >> ");
            string a = Console.ReadLine();
            nameWay = a;
        }

        public void RecrateDate()
        {
            Console.WriteLine("1 - date dispath\n2 - time arrival");
            Console.Write("Input item >> ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    dateDispatch= DateTime.Now;
                    break;
                case 2:
                    Console.Write("Input num days trip >> ");
                    int numDaysArrival = int.Parse(Console.ReadLine());
                    timeArrival = dateDispatch.AddDays(numDaysArrival);
                    break;
                default: Console.WriteLine("Incorrect! --- Error");break;
            }
        }

        public void AApassengers()
        {
            double res = car.numPassengers / car.number;
            Console.WriteLine($"AA passengers: {res}");
        }

        public void NumCarsFreePlaces()
        {
            Console.WriteLine($"Cars num: {car.number}");

            Console.Write("Input occupid places >> ");
            int occPlaces = int.Parse(Console.ReadLine());

            Console.WriteLine($"Free places: {FreePlaces(occPlaces)}");
        }

        public string TimeToArrival()
        {
            TimeSpan dif = timeArrival.Subtract(dateDispatch);
            return dif.ToString();
        }

        public int FreePlaces(int occPlaces)
        {
            int num = 0;
            num = car.numPlaces - occPlaces;
            return num;
        }

        public override string ToString()
        {
            StringBuilder bd = new StringBuilder();
            bd.Append($"Number: {number}\n");
            bd.Append($"Type: {type}\n");
            bd.Append($"Car: \n\tCar type: {car.type}\n\tCar number: {car.number}\n\tCar places: {car.numPlaces}\n\tCar passengers: {car.numPassengers}\n");
            bd.Append($"Name way: {nameWay}\n");
            bd.Append($"Date dispath: {dateDispatch}\n");
            bd.Append($"Date arrival: {timeArrival}\n");
            return bd.ToString();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}