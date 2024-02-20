using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_app
{
    class point
    {
        public int x;
        public int y;

        public double r;

        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void getLength()
        {
            r = Math.Sqrt(x * x + y * y);
            Console.WriteLine("Lenght {0}", this.r);
        }
    }
    
}
