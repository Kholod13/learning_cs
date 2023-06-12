using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_serialization
{
    struct MyFloat
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public MyFloat(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
