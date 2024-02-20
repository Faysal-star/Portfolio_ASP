using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine("number = {0}, i = {1} , {0}", number, i);
            point a = new point(1, 1);
            a.getLength();
            point3D b = new point3D(1, 1, 1);
            b.getLength();
        }
    }
}
