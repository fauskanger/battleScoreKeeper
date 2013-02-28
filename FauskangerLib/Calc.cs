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

        static public bool isInRange(int value, int lowLimit, int highLimit, int[] exceptions)
        {
            bool ret = isInRange(value,lowLimit,highLimit);

            if (!ret) return false; // Out of range

            foreach (int e in exceptions) 
            {
                if (value == e) return false; // Value equal to exceptions
            }
            return ret;
        }


    }
}
