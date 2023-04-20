using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_interfaces_shapes
{
    internal class Line : Shape, ILocated, IColored, IPrintable, IMovable
    {
        public int LocateX { get; set; }
        public int LocateY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Line(int Width) : base(Width, 1)
        {
            this.Width = Width;
            this.Height = 1;
        }

        void IColored.Color(string color)
        {
            Console.WriteLine($"Shape have a color {color}");
        }

        void ILocated.Location(int x, int y)
        {
            LocateX = x;
            LocateY = y;
        }
        void IMovable.Move(int x, int y)
        {
            Console.WriteLine($"Your shape move for x: {x}, y: {y}");
        }

        void IPrintable.Print(string s)
        {
            for (int i = 0; i < LocateY; i++)
            {
                Console.WriteLine();
            }

            for (int i = 0; i < Height; i++)
            {
                for (int f = 0; f < LocateX; f++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(s);
                }
            }

        }
    }
}
