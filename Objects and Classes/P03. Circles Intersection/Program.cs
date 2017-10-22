using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Circles_Intersection
{
    public class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] circleOne = Console.ReadLine().Split(' ');
            string[] circleTwo = Console.ReadLine().Split(' ');

            //create the first center point and set the first circle properties
            Circle one = new Circle();
            one.X = double.Parse(circleOne[0]);
            one.Y = double.Parse(circleOne[1]);
            one.Radius = double.Parse(circleOne[2]);

            //create the second center point and set the second circle properties
            Circle two = new Circle();
            two.X = double.Parse(circleTwo[0]);
            two.Y = double.Parse(circleTwo[1]);
            two.Radius = double.Parse(circleTwo[2]);

            bool circlesIntersect = Intersect(one, two);

            if (circlesIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static public bool Intersect(Circle one, Circle two)
        {
            //find the distance between the points
            double deltaX = Math.Abs(one.X - two.X);
            double deltaY = Math.Abs(one.Y - two.Y);
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            double sumRadiuses = one.Radius + two.Radius;
            //if the distance between the points is greater than the sum of the radiuses AND
            //if the radius of the smaller circle + the distance between the points is NOT
            //less than the radius of the larger circle, the circles intersect
            /* !(Math.Min(firstCircle.Radius, secondCircle.Radius) +
                distance < Math.Max(firstCircle.Radius, secondCircle.Radius)) */
            if (sumRadiuses >= distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}