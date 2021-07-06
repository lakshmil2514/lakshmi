﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICaculationProgram
{
    class CheckBMICondition
    {
   
        public string BMIValidate(int bmivalue)
        {
            if (bmivalue < 18.5)
            {
                return "UnderWeight";

            }
            else if (bmivalue > 25)
            {
                return "Overweight";
            }
            else
            {
                return "Normal";
            }
        }

    }
}
