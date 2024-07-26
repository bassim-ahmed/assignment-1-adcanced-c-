using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1_adcanced_c_.Generics
{
    internal class Point:IComparable<Point>
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int CompareTo(Point? other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{x} ,{y}";
        }
    }
}
