using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FauskangerLib
{

    public class Misc
    {

        static public bool isNullOrEmpty(string value)
        {
            return (value == null || value.Length <= 0);
        }

    }
}
