﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
   public class CalcEngine
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Mult(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Div(int number1, int number2)
        {
            return number1 / number2;
        }
        public int Dif(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
