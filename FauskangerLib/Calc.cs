using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FauskangerLib
{
    public class Calc
    {
        static public bool isInRange(int value, int lowLimit, int highLimit)
        {
            return (value <= highLimit && value >= lowLimit);
        }

        static public bool isInRange(int value, int lowLimit, int highLimit, int[] omitValues)
        {
            if (!isInRange(value,lowLimit,highLimit)) return false; // Out of range

            foreach (int omittedValue in omitValues) 
            {
                if (value == omittedValue) return false; // Value equal to exceptions
            }
            return true; // In range and not found among exceptions
        }


    }
}
