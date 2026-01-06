using System;
using System.Collections.Generic;
using System.Drawing;

namespace xAcademics
{
    internal class DistanceCalculator
    {
        public double CalculateDistance(List<Point> points)
        {
            if (points == null || points.Count < 2)
                return 0;

            double totalDistance = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                int dx = points[i + 1].X - points[i].X;
                int dy = points[i + 1].Y - points[i].Y;

                double segment = Math.Sqrt(dx * dx + dy * dy);
                totalDistance += segment;
            }

            double meters = totalDistance * 0.8;

            return meters;
        }
    }
}
