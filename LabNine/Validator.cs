using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNineCircle
{
    public static class Validator
    {
        public static bool radiousIsValid (string inputRadious, out double x )
        {
            
            if (double.TryParse(inputRadious, out x))
            {
                if (x <= 0)
                    return false;
                else
                    return true;
            }
            return false;
        }
    }
}
