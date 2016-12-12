using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitProject
{
    public class TemperatureConverter
    {
        private static double _absoluteZeroCelsius = -273.15;

        public static double CelsiusFarenheit(double temp, int direction = 0)
        {
            if (direction == 0)
            {
                return temp * 2.5;
                //return temp * 1.8 + 32;
            } else
            {
                return temp / 2.5;
                //return (temp - 32) / 1.8;
            }
        }

        public static double CelsiusKelvin(double temp, int direction = 0)
        {
            if (direction == 0)
            {
                if (temp < _absoluteZeroCelsius)
                {
                    var msg = $"Temperature in celsius cannot be lower than absolute zero [{_absoluteZeroCelsius} deg]";
                    throw new Exception(msg);
                    //throw new LowerThanAbsoluteZeroException(msg);
                }
                else
                {
                    return temp + 273.1;
                }
            } else
            {
                if (temp < 0)
                {
                    var msg = $"Temperature in kelvin cannot be lower than absolute zero [{_absoluteZeroCelsius} deg]";
                    throw new Exception(msg);
                    //throw new LowerThanAbsoluteZeroException(msg);
                }
                else
                {
                    return temp - 273.1;
                }
            }
        }
    }
}
