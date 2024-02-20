using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_app
{
    class point3D : point
    {
        public int z;
        public point3D(int x, int y , int z):base(x,y)
        {
            this.z = z;
        }
        public override void getLength()
        {
            r = Math.Sqrt(x * x + y * y + z*z);
            Console.WriteLine("Lenght {0}", this.r);
        }
    }
}
