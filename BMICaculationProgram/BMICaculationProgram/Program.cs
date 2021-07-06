using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICaculationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            InputReader input = new InputReader();
          int weightValue=  input.GetUserWeight();
          int heightValue=  input.GetUserHeight();

            CalculateBMI bmiValue = new CalculateBMI();
           int calculatedValue= bmiValue.CalculateResult(weightValue,heightValue);

            CheckBMICondition validate = new CheckBMICondition();
           string message= validate.BMIValidate(calculatedValue);

            DisplayMessage displaymessage = new DisplayMessage();
            displaymessage.Display(message);

            


        }
    }
}
