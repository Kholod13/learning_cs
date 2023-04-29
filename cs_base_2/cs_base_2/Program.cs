using System.Collections.Specialized;

namespace _01_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            /*
            Console.Write("Input radius of circle >> ");
            int radius = int.Parse(Console.ReadLine());

            double S = 3.14 * Math.Pow(radius, 2);

            Console.WriteLine($"S = {S}");
            */
            //task 2
            /*
            Random rnd = new Random();
            int lucky_num = rnd.Next(0, 10);
            Console.WriteLine(lucky_num);
            for(int i =0; i < 3;i++)
            {
                Console.Write($"Input number #{i+1} >> ");
                int num = int.Parse(Console.ReadLine());

                if (num == lucky_num)
                {
                    Console.WriteLine("You guessed!");
                    return;
                }
                if (i == 2 && num != lucky_num)
                {
                    Console.WriteLine("Sorry, you not guessed!");
                    return;
                }
                if(i < 2 && num != lucky_num)
                {
                    Console.WriteLine("Incorrect number.");
                }
            }
            */
            //task 3
            /*
            int x, y;
            int width, height;

            Console.Write("Input coords(x,y) >> ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Console.Write("Input size(width,height) >> ");
            width = int.Parse(Console.ReadLine()); 
            height = int.Parse(Console.ReadLine());

            for(int i = 0; i < y;i++)
            {
                Console.WriteLine();
            }
            for(int i = 0; i < height; i++)
            {
                for (int a = 0; a < x; a++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            */
            //task 4
            /*
            int N, m;
            int a = 10;
            int res;

            Console.WriteLine("Input number hay mower >> ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the time when the first lawnmower worked >> ");
            m = int.Parse(Console.ReadLine());
            res = m;
            for(int i = 1; i < N; i++)
            {
                res += m + (i*a);
            }
            int min = res % 60;
            res = res / 60;
            Console.WriteLine($"The team worked for {res}:{min}.")
            */
        }

    }

}