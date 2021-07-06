﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICaculationProgram
{
   public class InputReader
    {
        public int GetUserHeight()
        {
            int height = int.Parse(this.ReadFromConsole("Enter your height in meter:"));
            return height;
        }

        public int GetUserWeight()
        {
            int weight = int.Parse(this.ReadFromConsole("Enter your weight in kg:"));
            return weight;
        }
        private string ReadFromConsole(string message)
        {

            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

    }
}
