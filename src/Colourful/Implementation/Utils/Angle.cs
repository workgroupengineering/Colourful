﻿using System;

namespace Colourful.Implementation
{
    /// <summary>
    /// Angle unit conversion helpers
    /// </summary>
    internal static class Angle
    {
        private const double TwoPI = 2 * Math.PI;

        public static double RadianToDegree(in double rad)
        {
            var deg = 360 * (rad / TwoPI);
            return deg;
        }

        public static double DegreeToRadian(in double deg)
        {
            var rad = TwoPI * (deg / 360d);
            return rad;
        }

        public static double NormalizeDegree(in double deg)
        {
            var d = deg % 360d;
            return d >= 0 ? d : d + 360d;
        }
    }
}