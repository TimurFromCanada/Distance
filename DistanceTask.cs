using System;

namespace DistanceTask
{
    public static class DistanceTask
    {
        //Скалярное произведение векторов для первого случая
        public static double FindScalarProductOne(double ax, double ay, double bx, double by, double x, double y)
        {
            return (x - ax) * (bx - ax) + (y - ay) * (by - ay);
        }
        //Скалярное произведение векторов для второго случая
        public static double FindScalarProductTwo(double ax, double ay, double bx, double by, double x, double y)
        {
            return (x - bx) * (ax - bx) + (y - by) * (ay - by);
        }
        //Скалярное произведение для третьего случая
        public static double FindScalarProductThree(double ax, double ay, double bx, double by, double x, double y)
        {
            return (ax - x) * (bx - x) + (ay - y) * (by - y);
        }
        //Косое произведение векторов
        public static double FindSkewProductOfVectors(double ax, double ay, double bx, double by, double x, double y)
        {
            return (bx - ax) * (y - ay) - (x - ax) * (by - ay);
        }

        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            double amab = FindScalarProductOne(ax, ay, bx, by, x, y);

            double bmba = FindScalarProductTwo(ax, ay, bx, by, x, y);

            double mamb = FindScalarProductThree(ax, ay, bx, by, x, y);

            double abam = FindSkewProductOfVectors(ax, ay, bx, by, x, y);


            double d; //Длина от точки до концов отрезка
            double am = Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay));
            double bm = Math.Sqrt((x - bx) * (x - bx) + (y - by) * (y - by));

            if (amab <= 0) return d = Math.Min(am, bm);
            if (bmba <= 0) return d = Math.Min(am, bm);
            if (mamb < 0 && abam == 0) return d = 0;
            return d = Math.Abs(((bx - ax) * (y - ay) - (by - ay) * (x - ax)))
                / Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
        }
    }
}
