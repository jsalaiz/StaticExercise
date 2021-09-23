using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double f)
        {
            double c = (f - 32) * (5/9);
            return c;
        }

        public static double CelsiusToFahrenheit(double c)
        {
            double f = (c * 1.8) + 32;
            return f;
        }
    }
}
