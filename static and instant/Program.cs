using System;

namespace static_and_instant
{
    class Circle
    {
        static float _pi;
        int _radius;
        static Circle()
        {
            Console.WriteLine("static constructor called");
            Circle._pi = 3.141f;
        }
        public Circle(int radius)
        {
            Console.WriteLine("Instance constructor called");
            this._radius = radius;
        }
        public float area()
        {
            return Circle._pi * this._radius * this._radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float area1 = c1.area();
            Console.WriteLine("Area = {0}",area1);

            Circle c2 = new Circle(6);
            float area2 = c2.area();
            Console.WriteLine("Area = {0}", area2);
        }
    }
}
