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

        private static int DotProduct(Point a, Point b, Point c)
        {
            Point AB = new Point(b.X - a.X, b.Y - a.Y);
            Point BC = new Point(c.X - b.X, c.Y - b.Y);
            return AB.X * BC.X + AB.Y * BC.Y;
        }

        public static bool IsPointNearLine(Point point, Point center, Point pointA)
        {
            // https://stackoverflow.com/a/910916
            // https://www.topcoder.com/community/data-science/data-science-tutorials/geometry-concepts-basic-concepts/
            double distance = Math.Abs(((pointA.X - center.X) * (center.Y - point.Y)) - ((center.X - point.X) * (pointA.Y - center.Y))) / Math.Sqrt(Math.Pow((pointA.X - center.X), 2) + Math.Pow((pointA.Y - center.Y), 2));
            bool isBetween = DotProduct(center, pointA, point) < 0 && DotProduct(pointA, center, point) < 0;
            return isBetween && distance >= -5 && distance <= 5;
        }
    }
}
