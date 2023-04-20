using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_interfaces_shapes
{
    interface ILocated
    {
        int LocateX { get; set; }
        int LocateY { get; set; }

        void Location(int x, int y);
    }
    interface IColored
    {
        void Color(string color);
    }
    interface IPrintable
    {
        void Print(string s);
    }
    interface IMovable
    {
        void Move(int x, int y);
    }
    abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int width, int height) { Width = width; Height = height; }

        public void Area()
        {
            int res = Width* Height;
            Console.WriteLine($"Area: {res}");
        }
        public void Perimeter()
        {
            int res = (Width + Height) * 2;
            Console.WriteLine($"Perimeter: {res}");
        }
        public void ToString()
        {
            Console.WriteLine($"Width: {Width}\nHeight: {Height}");
        }
    }
}
