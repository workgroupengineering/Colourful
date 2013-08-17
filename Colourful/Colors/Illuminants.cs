﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colourful.Colors
{
    /// <summary>
    /// Standard illuminants
    /// </summary>
    /// <remarks>
    /// Coefficients taken from:
    /// http://www.brucelindbloom.com/index.html?Eqn_ChromAdapt.html
    /// <br />
    /// Descriptions taken from:
    /// http://en.wikipedia.org/wiki/Standard_illuminant
    /// </remarks>
    public static class Illuminants
    {
        /// <summary>
        /// Incandescent / Tungsten
        /// </summary>
        public static XYZColorBase A = new XYZColorBase(1.09850, 1, 0.35585);

        /// <summary>
        /// {obsolete} Direct sunlight at noon
        /// </summary>
        public static XYZColorBase B = new XYZColorBase(0.99072, 1, 0.85223);

        /// <summary>
        /// {obsolete} Average / North sky Daylight
        /// </summary>
        public static XYZColorBase C = new XYZColorBase(0.98074, 1, 1.18232);

        /// <summary>
        /// Horizon Light. ICC profile PCS
        /// </summary>
        public static XYZColorBase D50 = new XYZColorBase(0.96422, 1, 0.82521);

        /// <summary>
        /// Mid-morning / Mid-afternoon Daylight
        /// </summary>
        public static XYZColorBase D55 = new XYZColorBase(0.95682, 1, 0.92149);

        /// <summary>
        /// Noon Daylight: Television, sRGB color space
        /// </summary>
        public static XYZColorBase D65 = new XYZColorBase(0.95047, 1, 1.08883);

        /// <summary>
        /// North sky Daylight
        /// </summary>
        public static XYZColorBase D75 = new XYZColorBase(0.94972, 1, 1.22638);

        /// <summary>
        /// Equal energy
        /// </summary>
        public static XYZColorBase E = new XYZColorBase(1, 1, 1);

        /// <summary>
        /// Cool White Fluorescent
        /// </summary>
        public static XYZColorBase F2 = new XYZColorBase(0.99186, 1, 0.67393);

        /// <summary>
        /// D65 simulator, Daylight simulator
        /// </summary>
        public static XYZColorBase F7 = new XYZColorBase(0.95041, 1, 1.08747);

        /// <summary>
        /// Philips TL84, Ultralume 40
        /// </summary>
        public static XYZColorBase F11 = new XYZColorBase(1.00962, 1, 0.64350);
    }
}