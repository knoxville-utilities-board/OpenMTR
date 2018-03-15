using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public static class MathUtils
    {
        private static float Sign(Point point1, Point point2, Point point3)
        {
            return (point1.X - point3.X) * (point2.Y - point3.Y) - (point2.X - point3.X) * (point1.Y - point3.Y);
        }

        public static bool IsPointInTriangle(Point point, Point pointA, Point pointB, Point pointC)
        {
            bool check1 = Sign(point, pointA, pointB) < 0.0f;
            bool check2 = Sign(point, pointB, pointC) < 0.0f;
            bool check3 = Sign(point, pointC, pointA) < 0.0f;
            return ((check1 == check2) && (check2 == check3));
        }

        public static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }
    }
}
