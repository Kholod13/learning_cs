using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_classses_props
{
    public partial class Class1
    {
        public int p1 { get; set; }
        public int p2 { get; set; }
        public void Swap(ref Class1 a1, ref Class1 a2)
        {
            Class1 temp = a1;
            a1 = a2;
            a2 = temp;
        }

        public void InputProperties(out int p1, out int p2)
        {
            Console.Write($"Input property 1 >> ");
            int.TryParse( Console.ReadLine(), out p1 );

            Console.Write($"Input property 2 >> ");
            int.TryParse(Console.ReadLine(), out p2);

        }
    }
}
