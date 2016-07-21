using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Circle
    {
        public static float _PI;
        int _Radius;

        static Circle()
        {
            Console.WriteLine("static member called");
            Circle._PI = 3.141f;
        }
        public Circle(int Radius)
        {
            Console.WriteLine("instance member called");
            this._Radius = Radius;
        }

    
        public float CalculatArea()
        {
            return Circle._PI * this._Radius * this._Radius;

        }
    }



    class Program
    {
        public static void Main()
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculatArea();
            Console.WriteLine("Area  = {0}", Area1);

            Circle C2 = new Circle(15);
            float Area2 = C2.CalculatArea();
            Console.WriteLine("Area = {0}", Area2);

            Console.WriteLine("push the changes to github");
        }
    }

}
