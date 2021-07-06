using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICaculationProgram
{
    public class CalculateBMI
    {
       
        public int CalculateResult(int weight,int height)
        {
          int res=weight / height;
            return res;

        }
    }
}
